using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2026_06_Caesar_Cipher_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Encrypt(string text, int key)
        {
            string result = "";

            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int charIndex = c - 'a';
                    int newIndex = (charIndex + (key % 26) + 26) % 26;
                    result += (char)('a' + newIndex);
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxKey.Text, out int key))
            {
                key = 0;
            }

            labelResult.Text = Encrypt(textBoxInput.Text, key);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelResult.Text))
            {
                MessageBox.Show("Nothing to save!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            saveDialog.Title = "Save Ciphertext";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, labelResult.Text);
            }
        }

        private void labelResult_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(250, 235, 215), 2))
            {
                int radius = 30;
                GraphicsPath path = new GraphicsPath();
                Rectangle rect = new Rectangle(1, 1, labelResult.Width - 3, labelResult.Height - 3);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
