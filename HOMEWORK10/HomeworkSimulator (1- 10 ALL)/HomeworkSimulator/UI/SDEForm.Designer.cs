namespace HomeworkSimulator.UI
{
    partial class SDEForm
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
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxIntervals = new System.Windows.Forms.TextBox();
            this.buttonStartSDE = new System.Windows.Forms.Button();
            this.panelGraph = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(22, 24);
            this.textBoxLambda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(91, 20);
            this.textBoxLambda.TabIndex = 0;
            this.textBoxLambda.Text = "Rate (λ)";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(128, 24);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(91, 20);
            this.textBoxTime.TabIndex = 1;
            this.textBoxTime.Text = "Total Time (T)";
            // 
            // textBoxIntervals
            // 
            this.textBoxIntervals.Location = new System.Drawing.Point(232, 24);
            this.textBoxIntervals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIntervals.Name = "textBoxIntervals";
            this.textBoxIntervals.Size = new System.Drawing.Size(91, 20);
            this.textBoxIntervals.TabIndex = 2;
            this.textBoxIntervals.Text = "Intervals (n)";
            // 
            // buttonStartSDE
            // 
            this.buttonStartSDE.Location = new System.Drawing.Point(338, 24);
            this.buttonStartSDE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartSDE.Name = "buttonStartSDE";
            this.buttonStartSDE.Size = new System.Drawing.Size(75, 37);
            this.buttonStartSDE.TabIndex = 3;
            this.buttonStartSDE.Text = "Start SDE";
            this.buttonStartSDE.UseVisualStyleBackColor = true;
            this.buttonStartSDE.Click += new System.EventHandler(this.buttonStartSDE_Click_1);
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(22, 65);
            this.panelGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.panelGraph.Size = new System.Drawing.Size(525, 325);
            this.panelGraph.TabIndex = 4;
            this.panelGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // SDEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.buttonStartSDE);
            this.Controls.Add(this.textBoxIntervals);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxLambda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SDEForm";
            this.Text = "SDE Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxIntervals;
        private System.Windows.Forms.Button buttonStartSDE;
        private OxyPlot.WindowsForms.PlotView panelGraph; // Defined correctly
    }
}
