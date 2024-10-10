namespace Simulation
{
    partial class Form1
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
            this.textBoxServers = new System.Windows.Forms.TextBox();
            this.textBoxPenetrationProbability = new System.Windows.Forms.TextBox();
            this.textBoxAttackers = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxServers
            // 
            this.textBoxServers.Location = new System.Drawing.Point(148, 487);
            this.textBoxServers.Name = "textBoxServers";
            this.textBoxServers.Size = new System.Drawing.Size(190, 22);
            this.textBoxServers.TabIndex = 0;
            this.textBoxServers.Text = "Enter Server Number";
            // 
            // textBoxPenetrationProbability
            // 
            this.textBoxPenetrationProbability.Location = new System.Drawing.Point(931, 487);
            this.textBoxPenetrationProbability.Name = "textBoxPenetrationProbability";
            this.textBoxPenetrationProbability.Size = new System.Drawing.Size(139, 22);
            this.textBoxPenetrationProbability.TabIndex = 1;
            this.textBoxPenetrationProbability.Text = "Enter Probability";
            // 
            // textBoxAttackers
            // 
            this.textBoxAttackers.Location = new System.Drawing.Point(572, 487);
            this.textBoxAttackers.Name = "textBoxAttackers";
            this.textBoxAttackers.Size = new System.Drawing.Size(132, 22);
            this.textBoxAttackers.TabIndex = 2;
            this.textBoxAttackers.Text = "Enter Attacker Number";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(688, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Start";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(171, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 405);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxAttackers);
            this.Controls.Add(this.textBoxPenetrationProbability);
            this.Controls.Add(this.textBoxServers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServers;
        private System.Windows.Forms.TextBox textBoxPenetrationProbability;
        private System.Windows.Forms.TextBox textBoxAttackers;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}

