namespace HomeworkSimulator.UI
{
    partial class Homework6Form
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
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.lblTheoreticalMean = new System.Windows.Forms.Label();
            this.lblTheoreticalVariance = new System.Windows.Forms.Label();
            this.lblEmpiricalMean = new System.Windows.Forms.Label();
            this.lblEmpiricalVariance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Location = new System.Drawing.Point(20, 20);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSampleSize.TabIndex = 0;
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Location = new System.Drawing.Point(20, 5);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(77, 15);
            this.labelSampleSize.TabIndex = 1;
            this.labelSampleSize.Text = "Sample Size";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(140, 20);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // plotView
            // 
            this.plotView.Location = new System.Drawing.Point(20, 60);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(600, 300);
            this.plotView.TabIndex = 3;
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // lblTheoreticalMean
            // 
            this.lblTheoreticalMean.AutoSize = true;
            this.lblTheoreticalMean.Location = new System.Drawing.Point(20, 370);
            this.lblTheoreticalMean.Name = "lblTheoreticalMean";
            this.lblTheoreticalMean.Size = new System.Drawing.Size(106, 15);
            this.lblTheoreticalMean.TabIndex = 4;
            this.lblTheoreticalMean.Text = "Theoretical Mean:";
            // 
            // lblTheoreticalVariance
            // 
            this.lblTheoreticalVariance.AutoSize = true;
            this.lblTheoreticalVariance.Location = new System.Drawing.Point(20, 390);
            this.lblTheoreticalVariance.Name = "lblTheoreticalVariance";
            this.lblTheoreticalVariance.Size = new System.Drawing.Size(122, 15);
            this.lblTheoreticalVariance.TabIndex = 5;
            this.lblTheoreticalVariance.Text = "Theoretical Variance:";
            // 
            // lblEmpiricalMean
            // 
            this.lblEmpiricalMean.AutoSize = true;
            this.lblEmpiricalMean.Location = new System.Drawing.Point(20, 410);
            this.lblEmpiricalMean.Name = "lblEmpiricalMean";
            this.lblEmpiricalMean.Size = new System.Drawing.Size(97, 15);
            this.lblEmpiricalMean.TabIndex = 6;
            this.lblEmpiricalMean.Text = "Empirical Mean:";
            // 
            // lblEmpiricalVariance
            // 
            this.lblEmpiricalVariance.AutoSize = true;
            this.lblEmpiricalVariance.Location = new System.Drawing.Point(20, 430);
            this.lblEmpiricalVariance.Name = "lblEmpiricalVariance";
            this.lblEmpiricalVariance.Size = new System.Drawing.Size(113, 15);
            this.lblEmpiricalVariance.TabIndex = 7;
            this.lblEmpiricalVariance.Text = "Empirical Variance:";
            // 
            // Homework6Form
            // 
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.lblEmpiricalVariance);
            this.Controls.Add(this.lblEmpiricalMean);
            this.Controls.Add(this.lblTheoreticalVariance);
            this.Controls.Add(this.lblTheoreticalMean);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelSampleSize);
            this.Controls.Add(this.textBoxSampleSize);
            this.Name = "Homework6Form";
            this.Text = "Homework 6 - Probability Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.Button buttonGenerate;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.Label lblTheoreticalMean;
        private System.Windows.Forms.Label lblTheoreticalVariance;
        private System.Windows.Forms.Label lblEmpiricalMean;
        private System.Windows.Forms.Label lblEmpiricalVariance;
    }
}
