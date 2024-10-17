namespace RandomWalkSimulation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelSteps = new System.Windows.Forms.Label();
            this.labelProbability = new System.Windows.Forms.Label();
            this.buttonStartSim = new System.Windows.Forms.Button();
            this.panelGraph = new OxyPlot.WindowsForms.PlotView();
            this.textBoxHacker = new System.Windows.Forms.TextBox();
            this.textBoxServers = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(30, 30);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(120, 22);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "100";

            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(170, 30);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(120, 22);
            this.textBoxP.TabIndex = 2;
            this.textBoxP.Text = "0.5";

            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(30, 10);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(107, 16);
            this.labelSteps.TabIndex = 1;
            this.labelSteps.Text = "Number of Steps";

            // 
            // labelProbability
            // 
            this.labelProbability.AutoSize = true;
            this.labelProbability.Location = new System.Drawing.Point(170, 10);
            this.labelProbability.Name = "labelProbability";
            this.labelProbability.Size = new System.Drawing.Size(71, 16);
            this.labelProbability.TabIndex = 3;
            this.labelProbability.Text = "Probability";

            // 
            // buttonStartSim
            // 
            this.buttonStartSim.Location = new System.Drawing.Point(670, 29);
            this.buttonStartSim.Name = "buttonStartSim";
            this.buttonStartSim.Size = new System.Drawing.Size(100, 23);
            this.buttonStartSim.TabIndex = 4;
            this.buttonStartSim.Text = "Start Simulation";
            this.buttonStartSim.UseVisualStyleBackColor = true;

            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(30, 80);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.panelGraph.Size = new System.Drawing.Size(700, 400);
            this.panelGraph.TabIndex = 5;
            this.panelGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;

            // 
            // textBoxHacker
            // 
            this.textBoxHacker.Location = new System.Drawing.Point(322, 30);
            this.textBoxHacker.Name = "textBoxHacker";
            this.textBoxHacker.Size = new System.Drawing.Size(100, 22);
            this.textBoxHacker.TabIndex = 6;
            this.textBoxHacker.Text = "Number of Hackers";

            // 
            // textBoxServers
            // 
            this.textBoxServers.Location = new System.Drawing.Point(479, 29);
            this.textBoxServers.Name = "textBoxServers";
            this.textBoxServers.Size = new System.Drawing.Size(100, 22);
            this.textBoxServers.TabIndex = 7;
            this.textBoxServers.Text = "Number of Servers";

            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(640, 90);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(98, 22);
            this.textBoxTime.TabIndex = 8;
            this.textBoxTime.Text = "Time";

            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(62, 500);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(44, 16);
            this.labelMean.TabIndex = 9;
            this.labelMean.Text = "Mean";

            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(62, 530);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(64, 16);
            this.labelVariance.TabIndex = 10;
            this.labelVariance.Text = "Variance";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelMean);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxServers);
            this.Controls.Add(this.textBoxHacker);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.buttonStartSim);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelProbability);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelSteps);
            this.Name = "Form1";
            this.Text = "Random Walk Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonStartSim;
        private OxyPlot.WindowsForms.PlotView panelGraph; // Ensure only one declaration
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label labelProbability;
        private System.Windows.Forms.TextBox textBoxHacker;
        private System.Windows.Forms.TextBox textBoxServers;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelMean; // Ensure only one declaration
        private System.Windows.Forms.Label labelVariance; // Ensure only one declaration
    }
}
