namespace HomeworkSimulator.UI
{
    partial class RandomWalkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.textBoxN.Location = new System.Drawing.Point(22, 24);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(91, 20);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "100";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(128, 24);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(91, 20);
            this.textBoxP.TabIndex = 1;
            this.textBoxP.Text = "0.5";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(22, 8);
            this.labelSteps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(99, 15);
            this.labelSteps.TabIndex = 2;
            this.labelSteps.Text = "Number of Steps";
            // 
            // labelProbability
            // 
            this.labelProbability.AutoSize = true;
            this.labelProbability.Location = new System.Drawing.Point(128, 8);
            this.labelProbability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProbability.Name = "labelProbability";
            this.labelProbability.Size = new System.Drawing.Size(64, 15);
            this.labelProbability.TabIndex = 3;
            this.labelProbability.Text = "Probability";
            // 
            // buttonStartSim
            // 
            this.buttonStartSim.Location = new System.Drawing.Point(502, 24);
            this.buttonStartSim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartSim.Name = "buttonStartSim";
            this.buttonStartSim.Size = new System.Drawing.Size(75, 19);
            this.buttonStartSim.TabIndex = 4;
            this.buttonStartSim.Text = "Start Simulation";
            this.buttonStartSim.UseVisualStyleBackColor = true;
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(22, 65);
            this.panelGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.panelGraph.Size = new System.Drawing.Size(525, 325);
            this.panelGraph.TabIndex = 5;
            this.panelGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBoxHacker
            // 
            this.textBoxHacker.Location = new System.Drawing.Point(242, 24);
            this.textBoxHacker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHacker.Name = "textBoxHacker";
            this.textBoxHacker.Size = new System.Drawing.Size(76, 20);
            this.textBoxHacker.TabIndex = 6;
            this.textBoxHacker.Text = "Number of Hackers";
            // 
            // textBoxServers
            // 
            this.textBoxServers.Location = new System.Drawing.Point(359, 24);
            this.textBoxServers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxServers.Name = "textBoxServers";
            this.textBoxServers.Size = new System.Drawing.Size(76, 20);
            this.textBoxServers.TabIndex = 7;
            this.textBoxServers.Text = "Number of Servers";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(480, 73);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(76, 20);
            this.textBoxTime.TabIndex = 8;
            this.textBoxTime.Text = "Time";
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(22, 406);
            this.labelMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(39, 15);
            this.labelMean.TabIndex = 9;
            this.labelMean.Text = "Mean";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(22, 431);
            this.labelVariance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(55, 15);
            this.labelVariance.TabIndex = 10;
            this.labelVariance.Text = "Variance";
            // 
            // RandomWalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RandomWalkForm";
            this.Text = "Random Walk Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonStartSim;
        private OxyPlot.WindowsForms.PlotView panelGraph; // Correct type for PlotView
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label labelProbability;
        private System.Windows.Forms.TextBox textBoxHacker;
        private System.Windows.Forms.TextBox textBoxServers;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelVariance;
    }
}
