namespace HomeworkSimulator.UI
{
    partial class Homework7Form
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
            this.labelNumSamples = new System.Windows.Forms.Label();
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.labelSampleSize = new System.Windows.Forms.Label();
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
            // labelNumSamples
            // 
            this.labelNumSamples.AutoSize = true;
            this.labelNumSamples.Location = new System.Drawing.Point(20, 5);
            this.labelNumSamples.Name = "labelNumSamples";
            this.labelNumSamples.Size = new System.Drawing.Size(130, 16);
            this.labelNumSamples.TabIndex = 1;
            this.labelNumSamples.Text = "Number of Samples (m)";

            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Location = new System.Drawing.Point(150, 20);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSampleSize.TabIndex = 2;

            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Location = new System.Drawing.Point(150, 5);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(110, 16);
            this.labelSampleSize.TabIndex = 3;
            this.labelSampleSize.Text = "Sample Size (n)";

            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(270, 20);
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
            this.lblSamplingMean.Size = new System.Drawing.Size(170, 16);
            this.lblSamplingMean.TabIndex = 6;
            this.lblSamplingMean.Text = "Mean of Sampling Averages:";

            // 
            // lblSamplingVariance
            // 
            this.lblSamplingVariance.AutoSize = true;
            this.lblSamplingVariance.Location = new System.Drawing.Point(20, 390);
            this.lblSamplingVariance.Name = "lblSamplingVariance";
            this.lblSamplingVariance.Size = new System.Drawing.Size(185, 16);
            this.lblSamplingVariance.TabIndex = 7;
            this.lblSamplingVariance.Text = "Variance of Sampling Averages:";

            // 
            // Homework7Form
            // 
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lblSamplingVariance);
            this.Controls.Add(this.lblSamplingMean);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelSampleSize);
            this.Controls.Add(this.textBoxSampleSize);
            this.Controls.Add(this.labelNumSamples);
            this.Controls.Add(this.textBoxNumSamples);
            this.Name = "Homework7Form";
            this.Text = "Homework 7 - Sampling Averages";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumSamples;
        private System.Windows.Forms.Label labelNumSamples;
        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.Button buttonGenerate;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.Label lblSamplingMean;
        private System.Windows.Forms.Label lblSamplingVariance;
    }
}
