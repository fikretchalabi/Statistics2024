namespace HomeworkSimulator.UI
{
    partial class Homework9Form
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
            this.textBoxNumSamples = new System.Windows.Forms.TextBox();
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.lblNumSamples = new System.Windows.Forms.Label();
            this.lblSampleSize = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.lblSamplingMean = new System.Windows.Forms.Label();
            this.lblSamplingVariance = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // textBoxNumSamples
            // 
            this.textBoxNumSamples.Location = new System.Drawing.Point(20, 20);
            this.textBoxNumSamples.Name = "textBoxNumSamples";
            this.textBoxNumSamples.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumSamples.TabIndex = 0;

            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Location = new System.Drawing.Point(140, 20);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSampleSize.TabIndex = 1;

            // 
            // lblNumSamples
            // 
            this.lblNumSamples.AutoSize = true;
            this.lblNumSamples.Location = new System.Drawing.Point(20, 5);
            this.lblNumSamples.Name = "lblNumSamples";
            this.lblNumSamples.Size = new System.Drawing.Size(105, 16);
            this.lblNumSamples.TabIndex = 2;
            this.lblNumSamples.Text = "Number of Samples";

            // 
            // lblSampleSize
            // 
            this.lblSampleSize.AutoSize = true;
            this.lblSampleSize.Location = new System.Drawing.Point(140, 5);
            this.lblSampleSize.Name = "lblSampleSize";
            this.lblSampleSize.Size = new System.Drawing.Size(78, 16);
            this.lblSampleSize.TabIndex = 3;
            this.lblSampleSize.Text = "Sample Size";

            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(260, 20);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);

            // 
            // plotView
            // 
            this.plotView.Location = new System.Drawing.Point(20, 60);
            this.plotView.Name = "plotView";
            this.plotView.Size = new System.Drawing.Size(600, 300);
            this.plotView.TabIndex = 5;

            // 
            // lblSamplingMean
            // 
            this.lblSamplingMean.AutoSize = true;
            this.lblSamplingMean.Location = new System.Drawing.Point(20, 370);
            this.lblSamplingMean.Name = "lblSamplingMean";
            this.lblSamplingMean.Size = new System.Drawing.Size(117, 16);
            this.lblSamplingMean.TabIndex = 6;
            this.lblSamplingMean.Text = "Mean of Variances:";

            // 
            // lblSamplingVariance
            // 
            this.lblSamplingVariance.AutoSize = true;
            this.lblSamplingVariance.Location = new System.Drawing.Point(20, 390);
            this.lblSamplingVariance.Name = "lblSamplingVariance";
            this.lblSamplingVariance.Size = new System.Drawing.Size(135, 16);
            this.lblSamplingVariance.TabIndex = 7;
            this.lblSamplingVariance.Text = "Variance of Variances:";

            // 
            // Homework9Form
            // 
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lblSamplingVariance);
            this.Controls.Add(this.lblSamplingMean);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.lblSampleSize);
            this.Controls.Add(this.lblNumSamples);
            this.Controls.Add(this.textBoxSampleSize);
            this.Controls.Add(this.textBoxNumSamples);
            this.Name = "Homework9Form";
            this.Text = "Homework 9 - Sampling Variance Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumSamples;
        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.Label lblNumSamples;
        private System.Windows.Forms.Label lblSampleSize;
        private System.Windows.Forms.Button buttonGenerate;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.Label lblSamplingMean;
        private System.Windows.Forms.Label lblSamplingVariance;

    }
}
