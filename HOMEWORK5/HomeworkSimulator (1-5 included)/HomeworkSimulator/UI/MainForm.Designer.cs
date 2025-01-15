namespace HomeworkSimulator.UI
{
    partial class MainForm
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
            this.comboSimulationSelection = new System.Windows.Forms.ComboBox();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSimulationSelection
            // 
            this.comboSimulationSelection.FormattingEnabled = true;
            this.comboSimulationSelection.Location = new System.Drawing.Point(306, 27);
            this.comboSimulationSelection.Name = "comboSimulationSelection";
            this.comboSimulationSelection.Size = new System.Drawing.Size(121, 21);
            this.comboSimulationSelection.TabIndex = 0;
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(306, 71);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(124, 23);
            this.btnStartSimulation.TabIndex = 1;
            this.btnStartSimulation.Text = "Start Simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.comboSimulationSelection);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSimulationSelection;
        private System.Windows.Forms.Button btnStartSimulation;
    }
}