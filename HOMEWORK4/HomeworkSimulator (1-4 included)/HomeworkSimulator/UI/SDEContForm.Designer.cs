namespace HomeworkSimulator.UI
{
    partial class SDEContForm
    {
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

        private void InitializeComponent()
        {
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.textBoxIntervals = new System.Windows.Forms.TextBox();
            this.textBoxInitialPosition = new System.Windows.Forms.TextBox();
            this.buttonStartSimulation = new System.Windows.Forms.Button();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelIntervals = new System.Windows.Forms.Label();
            this.labelInitialPosition = new System.Windows.Forms.Label();
            this.panelGraph = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Location = new System.Drawing.Point(30, 30);
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.Size = new System.Drawing.Size(120, 22);
            this.textBoxTotalTime.TabIndex = 0;
            // 
            // textBoxIntervals
            // 
            this.textBoxIntervals.Location = new System.Drawing.Point(170, 30);
            this.textBoxIntervals.Name = "textBoxIntervals";
            this.textBoxIntervals.Size = new System.Drawing.Size(120, 22);
            this.textBoxIntervals.TabIndex = 1;
            // 
            // textBoxInitialPosition
            // 
            this.textBoxInitialPosition.Location = new System.Drawing.Point(310, 30);
            this.textBoxInitialPosition.Name = "textBoxInitialPosition";
            this.textBoxInitialPosition.Size = new System.Drawing.Size(120, 22);
            this.textBoxInitialPosition.TabIndex = 2;
            // 
            // buttonStartSimulation
            // 
            this.buttonStartSimulation.Location = new System.Drawing.Point(450, 30);
            this.buttonStartSimulation.Name = "buttonStartSimulation";
            this.buttonStartSimulation.Size = new System.Drawing.Size(100, 23);
            this.buttonStartSimulation.TabIndex = 3;
            this.buttonStartSimulation.Text = "Start Simulation";
            this.buttonStartSimulation.UseVisualStyleBackColor = true;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(30, 10);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(73, 16);
            this.labelTotalTime.TabIndex = 4;
            this.labelTotalTime.Text = "Total Time:";
            // 
            // labelIntervals
            // 
            this.labelIntervals.AutoSize = true;
            this.labelIntervals.Location = new System.Drawing.Point(170, 10);
            this.labelIntervals.Name = "labelIntervals";
            this.labelIntervals.Size = new System.Drawing.Size(61, 16);
            this.labelIntervals.TabIndex = 5;
            this.labelIntervals.Text = "Intervals:";
            // 
            // labelInitialPosition
            // 
            this.labelInitialPosition.AutoSize = true;
            this.labelInitialPosition.Location = new System.Drawing.Point(310, 10);
            this.labelInitialPosition.Name = "labelInitialPosition";
            this.labelInitialPosition.Size = new System.Drawing.Size(92, 16);
            this.labelInitialPosition.TabIndex = 6;
            this.labelInitialPosition.Text = "Initial Position:";
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(30, 80);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(700, 400);
            this.panelGraph.TabIndex = 7;
            // 
            // SDEContForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.labelInitialPosition);
            this.Controls.Add(this.labelIntervals);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.buttonStartSimulation);
            this.Controls.Add(this.textBoxInitialPosition);
            this.Controls.Add(this.textBoxIntervals);
            this.Controls.Add(this.textBoxTotalTime);
            this.Name = "SDEContForm";
            this.Text = "SDE Continuous Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.TextBox textBoxIntervals;
        private System.Windows.Forms.TextBox textBoxInitialPosition;
        private System.Windows.Forms.Button buttonStartSimulation;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelIntervals;
        private System.Windows.Forms.Label labelInitialPosition;
        private OxyPlot.WindowsForms.PlotView panelGraph;
    }
}
