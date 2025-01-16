using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HomeWorkSimulator.UI
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Declare variables
            int n, m;
            double p;

            // Validate and parse input for number of servers
            if (!int.TryParse(textBoxServers.Text, out n))
            {
                MessageBox.Show("Please enter a valid number for servers.");
                return;
            }

            // Validate and parse input for number of attackers
            if (!int.TryParse(textBoxAttackers.Text, out m))
            {
                MessageBox.Show("Please enter a valid number for attackers.");
                return;
            }

            // Validate and parse input for penetration probability
            if (!double.TryParse(textBoxPenetrationProbability.Text, out p) || p < 0 || p > 1)
            {
                MessageBox.Show("Please enter a valid penetration probability (between 0 and 1).");
                return;
            }

            // Call the function to simulate and draw
            SimulateAndDraw(n, m, p);
        }

        private void SimulateAndDraw(int n, int m, double p)
        {
            // Get the panel's graphics object
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);  // Clear previous drawings

            int width = panel1.Width;
            int height = panel1.Height;

            int xSpacing = width / n;  // Space between each server's representation

            // Colors for different attackers
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Purple, Color.Brown };

            // Different line styles for each attacker
            DashStyle[] lineStyles = { DashStyle.Solid, DashStyle.Dash, DashStyle.Dot, DashStyle.DashDot, DashStyle.DashDotDot };

            // Track results for statistics
            int[] penetrationCounts = new int[n];  // Track penetration counts for each server

            // Loop over the attackers
            for (int attacker = 0; attacker < m; attacker++)
            {
                // Vary the penetration probability more significantly for each attacker
                double attackerP = p + (attacker * 0.1);  // Increase the variation in probability

                // Get color and line style for the attacker
                Color attackerColor = colors[attacker % colors.Length];
                Pen pen = new Pen(attackerColor, 2);
                pen.DashStyle = lineStyles[attacker % lineStyles.Length];  // Assign different line styles

                int previousYPos = height - 30;  // Start from just above the X-axis

                // Loop over the servers for each attacker
                for (int server = 0; server < n; server++)
                {
                    // Determine if this attacker penetrates this server
                    bool isPenetrated = random.NextDouble() < attackerP;
                    if (isPenetrated)
                    {
                        penetrationCounts[server]++;
                    }

                    // X position for the server
                    int xPos = server * xSpacing;

                    // Y position: jump to the top if penetrated, stay at the bottom otherwise
                    int yPos = isPenetrated ? height / 4 : height - 30;

                    // Draw the line from the previous server to the current one
                    g.DrawLine(pen, xPos, previousYPos, xPos + xSpacing, yPos);

                    // Draw a marker (circle) at the current point to help differentiate attackers
                    g.FillEllipse(new SolidBrush(attackerColor), xPos + xSpacing - 4, yPos - 4, 8, 8);

                    // Update the previous Y position for the next server
                    previousYPos = yPos;
                }
            }

            // Draw the X and Y axis with labels
            DrawAxisAndLabels(g, n, m, height, width);

            // Display penetration stats
            DrawPenetrationStats(g, penetrationCounts, n, height, width, m);

            // Display dynamic legend for attackers
            DrawDynamicLegend(g, colors, m);
        }

        private void DrawAxisAndLabels(Graphics g, int n, int m, int height, int width)
        {
            Pen axisPen = new Pen(Color.Black, 2);

            // X-axis (Servers)
            g.DrawLine(axisPen, 0, height - 30, width, height - 30);  // X-axis line
            g.DrawString("Servers", new Font("Arial", 12), Brushes.Black, width - 80, height - 25);

            // Y-axis (Penetration Status)
            g.DrawLine(axisPen, 0, 0, 0, height);  // Y-axis line
            g.DrawString("Penetration (Success)", new Font("Arial", 12), Brushes.Black, 10, 10);
            g.DrawString("No Penetration", new Font("Arial", 10), Brushes.Black, 10, height - 50);

            // Add markers for each server on X-axis
            for (int i = 0; i < n; i++)
            {
                int xPos = i * (width / n);
                g.DrawString((i + 1).ToString(), new Font("Arial", 10), Brushes.Black, xPos, height - 20);
            }
        }

        private void DrawPenetrationStats(Graphics g, int[] counts, int n, int height, int width, int m)
        {
            // Display total successful penetrations
            int xStart = 50;
            int yStart = 50;

            // Display successful penetration count in a cleaner format
            for (int i = 0; i < n; i++)
            {
                string penetrationText = $"Server {i + 1}: {counts[i]} penetrations";
                g.DrawString(penetrationText, new Font("Arial", 10), Brushes.Black, xStart, yStart + (i * 15));
            }
        }

        private void DrawDynamicLegend(Graphics g, Color[] colors, int m)
        {
            int xStart = panel1.Width - 120;  // Position the legend on the right side
            int yStart = 10;

            // Display each attacker's color in the legend
            for (int i = 0; i < m; i++)
            {
                string attackerText = $"Attacker {i + 1}";
                Brush brush = new SolidBrush(colors[i % colors.Length]);

                g.FillRectangle(brush, xStart, yStart + (i * 20), 20, 10);  // Color box
                g.DrawString(attackerText, new Font("Arial", 10), Brushes.Black, xStart + 25, yStart + (i * 20));
            }
        }
    }
}
