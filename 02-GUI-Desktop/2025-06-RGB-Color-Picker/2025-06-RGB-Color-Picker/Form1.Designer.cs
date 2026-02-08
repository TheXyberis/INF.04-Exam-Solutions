namespace _2025_06_RGB_Color_Picker
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
            this.panelColorPreview = new System.Windows.Forms.Panel();
            this.labelSavedResults = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.buttonSaveColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColorPreview
            // 
            this.panelColorPreview.BackColor = System.Drawing.Color.White;
            this.panelColorPreview.Location = new System.Drawing.Point(73, 25);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(624, 92);
            this.panelColorPreview.TabIndex = 0;
            // 
            // labelSavedResults
            // 
            this.labelSavedResults.BackColor = System.Drawing.Color.White;
            this.labelSavedResults.Location = new System.Drawing.Point(240, 405);
            this.labelSavedResults.Name = "labelSavedResults";
            this.labelSavedResults.Size = new System.Drawing.Size(242, 42);
            this.labelSavedResults.TabIndex = 4;
            this.labelSavedResults.Text = "255, 255, 255";
            this.labelSavedResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(73, 168);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(624, 56);
            this.trackBarRed.TabIndex = 5;
            this.trackBarRed.Value = 255;
            this.trackBarRed.Scroll += new System.EventHandler(this.OnSliderScroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(73, 230);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(624, 56);
            this.trackBarGreen.TabIndex = 6;
            this.trackBarGreen.Value = 255;
            this.trackBarGreen.Scroll += new System.EventHandler(this.OnSliderScroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(73, 292);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(624, 56);
            this.trackBarBlue.TabIndex = 7;
            this.trackBarBlue.Value = 255;
            this.trackBarBlue.Scroll += new System.EventHandler(this.OnSliderScroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adjust color with sliders and save with button:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "R";
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(703, 168);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(28, 16);
            this.labelRedValue.TabIndex = 14;
            this.labelRedValue.Text = "255";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(703, 230);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(28, 16);
            this.labelGreenValue.TabIndex = 15;
            this.labelGreenValue.Text = "255";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(703, 292);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(28, 16);
            this.labelBlueValue.TabIndex = 16;
            this.labelBlueValue.Text = "255";
            // 
            // buttonSaveColor
            // 
            this.buttonSaveColor.BackColor = System.Drawing.Color.Peru;
            this.buttonSaveColor.Location = new System.Drawing.Point(240, 354);
            this.buttonSaveColor.Name = "buttonSaveColor";
            this.buttonSaveColor.Size = new System.Drawing.Size(242, 48);
            this.buttonSaveColor.TabIndex = 17;
            this.buttonSaveColor.Text = "Get Color";
            this.buttonSaveColor.UseVisualStyleBackColor = false;
            this.buttonSaveColor.Click += new System.EventHandler(this.buttonSaveColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.buttonSaveColor);
            this.Controls.Add(this.labelBlueValue);
            this.Controls.Add(this.labelGreenValue);
            this.Controls.Add(this.labelRedValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.labelSavedResults);
            this.Controls.Add(this.panelColorPreview);
            this.Name = "MainForm";
            this.Text = "RGB Color Sampler";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColorPreview;
        private System.Windows.Forms.Label labelSavedResults;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Button buttonSaveColor;
    }
}

