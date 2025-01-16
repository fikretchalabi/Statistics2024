using System;
using System.Windows.Forms;
using HomeworkSimulator.Simulations; // Reference the Simulations logic

namespace HomeworkSimulator.UI
{
    public partial class Homework8Form : Form
    {
        private CaesarCipherSimulation simulation;

        public Homework8Form()
        {
            InitializeComponent();
            simulation = new CaesarCipherSimulation();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            int shift = int.Parse(txtShift.Text);

            string encryptedText = simulation.Encrypt(inputText, shift);
            txtOutput.Text = encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = txtOutput.Text;

            int detectedShift = simulation.DetectShiftUsingFrequencyAnalysis(encryptedText);
            string decryptedText = simulation.Decrypt(encryptedText, detectedShift);

            lblDetectedShift.Text = $"Detected Shift: {detectedShift}";
            txtDecrypted.Text = decryptedText;
        }
    }
}
