namespace NonogramOfficial.Views
{
    partial class Settings
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
            Settingslabel = new Label();
            lettertypeComboBox = new ComboBox();
            fontLabel = new Label();
            SaveSettingsButton = new Button();
            label1 = new Label();
            DefaultSize_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // Settingslabel
            // 
            Settingslabel.AutoSize = true;
            Settingslabel.Font = new Font("Segoe UI", 30F);
            Settingslabel.Location = new Point(41, 28);
            Settingslabel.Name = "Settingslabel";
            Settingslabel.Size = new Size(167, 54);
            Settingslabel.TabIndex = 0;
            Settingslabel.Text = "Settings";
            // 
            // lettertypeComboBox
            // 
            lettertypeComboBox.DisplayMember = "Arial";
            lettertypeComboBox.FormattingEnabled = true;
            lettertypeComboBox.Location = new Point(52, 149);
            lettertypeComboBox.Name = "lettertypeComboBox";
            lettertypeComboBox.Size = new Size(121, 23);
            lettertypeComboBox.TabIndex = 1;
            lettertypeComboBox.Text = "Arial";
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Font = new Font("Segoe UI", 11F);
            fontLabel.Location = new Point(93, 111);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(41, 20);
            fontLabel.TabIndex = 2;
            fontLabel.Text = "Font:";
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Location = new Point(12, 415);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(75, 23);
            SaveSettingsButton.TabIndex = 3;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(78, 208);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Start size:";
            // 
            // DefaultSize_comboBox
            // 
            DefaultSize_comboBox.FormattingEnabled = true;
            DefaultSize_comboBox.Items.AddRange(new object[] { "5x5", "10x10", "15x15", "20x20" });
            DefaultSize_comboBox.Location = new Point(52, 243);
            DefaultSize_comboBox.Name = "DefaultSize_comboBox";
            DefaultSize_comboBox.Size = new Size(121, 23);
            DefaultSize_comboBox.TabIndex = 5;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 450);
            Controls.Add(DefaultSize_comboBox);
            Controls.Add(label1);
            Controls.Add(SaveSettingsButton);
            Controls.Add(fontLabel);
            Controls.Add(lettertypeComboBox);
            Controls.Add(Settingslabel);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Settingslabel;
        private ComboBox lettertypeComboBox;
        private Label fontLabel;
        private Button SaveSettingsButton;
        private Label label1;
        private ComboBox DefaultSize_comboBox;
    }
}