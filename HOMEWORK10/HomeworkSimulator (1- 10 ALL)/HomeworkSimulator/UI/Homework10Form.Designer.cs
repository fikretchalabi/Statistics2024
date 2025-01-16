namespace HomeworkSimulator.UI
{
    partial class Homework10Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelLowerBound;
        private System.Windows.Forms.Label labelUpperBound;
        private System.Windows.Forms.TextBox textBoxLowerBound;
        private System.Windows.Forms.TextBox textBoxUpperBound;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelRiemannResult;
        private System.Windows.Forms.Label labelLebesgueResult;
        private OxyPlot.WindowsForms.PlotView plotView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelLowerBound = new System.Windows.Forms.Label();
            this.labelUpperBound = new System.Windows.Forms.Label();
            this.textBoxLowerBound = new System.Windows.Forms.TextBox();
            this.textBoxUpperBound = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelRiemannResult = new System.Windows.Forms.Label();
            this.labelLebesgueResult = new System.Windows.Forms.Label();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();

            // Lower Bound Label
            this.labelLowerBound.AutoSize = true;
            this.labelLowerBound.Location = new System.Drawing.Point(20, 20);
            this.labelLowerBound.Name = "labelLowerBound";
            this.labelLowerBound.Size = new System.Drawing.Size(90, 16);
            this.labelLowerBound.TabIndex = 0;
            this.labelLowerBound.Text = "Lower Bound:";

            // Upper Bound Label
            this.labelUpperBound.AutoSize = true;
            this.labelUpperBound.Location = new System.Drawing.Point(20, 60);
            this.labelUpperBound.Name = "labelUpperBound";
            this.labelUpperBound.Size = new System.Drawing.Size(90, 16);
            this.labelUpperBound.TabIndex = 1;
            this.labelUpperBound.Text = "Upper Bound:";

            // Lower Bound TextBox
            this.textBoxLowerBound.Location = new System.Drawing.Point(120, 20);
            this.textBoxLowerBound.Name = "textBoxLowerBound";
            this.textBoxLowerBound.Size = new System.Drawing.Size(100, 22);
            this.textBoxLowerBound.TabIndex = 2;

            // Upper Bound TextBox
            this.textBoxUpperBound.Location = new System.Drawing.Point(120, 60);
            this.textBoxUpperBound.Name = "textBoxUpperBound";
            this.textBoxUpperBound.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpperBound.TabIndex = 3;

            // Calculate Button
            this.buttonCalculate.Location = new System.Drawing.Point(250, 20);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // Riemann Result Label
            this.labelRiemannResult.AutoSize = true;
            this.labelRiemannResult.Location = new System.Drawing.Point(20, 100);
            this.labelRiemannResult.Name = "labelRiemannResult";
            this.labelRiemannResult.Size = new System.Drawing.Size(118, 16);
            this.labelRiemannResult.TabIndex = 5;
            this.labelRiemannResult.Text = "Riemann Integral:";

            // Lebesgue Result Label
            this.labelLebesgueResult.AutoSize = true;
            this.labelLebesgueResult.Location = new System.Drawing.Point(20, 130);
            this.labelLebesgueResult.Name = "labelLebesgueResult";
            this.labelLebesgueResult.Size = new System.Drawing.Size(123, 16);
            this.labelLebesgueResult.TabIndex = 6;
            this.labelLebesgueResult.Text = "Lebesgue Integral:";

            // PlotView
            this.plotView.Location = new System.Drawing.Point(20, 160);
            this.plotView.Name = "plotView";
            this.plotView.Size = new System.Drawing.Size(500, 300);
            this.plotView.TabIndex = 7;

            // Homework10Form
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.labelLowerBound);
            this.Controls.Add(this.textBoxLowerBound);
            this.Controls.Add(this.labelUpperBound);
            this.Controls.Add(this.textBoxUpperBound);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelRiemannResult);
            this.Controls.Add(this.labelLebesgueResult);
            this.Controls.Add(this.plotView);
            this.Name = "Homework10Form";
            this.Text = "Homework 10 - Numerical Integration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
