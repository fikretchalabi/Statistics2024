namespace HomeworkSimulator.UI
{
    partial class EMForm
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
            this.textBoxInitialPosition = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.textBoxIntervals = new System.Windows.Forms.TextBox();
            this.buttonStartSimulation = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxInitialPosition
            // 
            this.textBoxInitialPosition.Location = new System.Drawing.Point(20, 20);
            this.textBoxInitialPosition.Name = "textBoxInitialPosition";
            this.textBoxInitialPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxInitialPosition.TabIndex = 0;
            this.textBoxInitialPosition.Text = "0.0";
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Location = new System.Drawing.Point(140, 20);
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalTime.TabIndex = 1;
            this.textBoxTotalTime.Text = "1.0";
            // 
            // textBoxIntervals
            // 
            this.textBoxIntervals.Location = new System.Drawing.Point(260, 20);
            this.textBoxIntervals.Name = "textBoxIntervals";
            this.textBoxIntervals.Size = new System.Drawing.Size(100, 22);
            this.textBoxIntervals.TabIndex = 2;
            this.textBoxIntervals.Text = "100";
            // 
            // buttonStartSimulation
            // 
            this.buttonStartSimulation.Location = new System.Drawing.Point(380, 20);
            this.buttonStartSimulation.Name = "buttonStartSimulation";
            this.buttonStartSimulation.Size = new System.Drawing.Size(150, 23);
            this.buttonStartSimulation.TabIndex = 3;
            this.buttonStartSimulation.Text = "Start Simulation";
            this.buttonStartSimulation.UseVisualStyleBackColor = true;
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(20, 60);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(600, 400);
            this.panelGraph.TabIndex = 4;
            // 
            // EMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.buttonStartSimulation);
            this.Controls.Add(this.textBoxIntervals);
            this.Controls.Add(this.textBoxTotalTime);
            this.Controls.Add(this.textBoxInitialPosition);
            this.Name = "EMForm";
            this.Text = "Euler-Maruyama Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInitialPosition;
        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.TextBox textBoxIntervals;
        private System.Windows.Forms.Button buttonStartSimulation;
        private System.Windows.Forms.Panel panelGraph;
    }
}
