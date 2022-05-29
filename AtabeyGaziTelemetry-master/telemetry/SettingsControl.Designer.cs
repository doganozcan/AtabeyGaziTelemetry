namespace telemetry
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_logs = new System.Windows.Forms.CheckBox();
            this.bt_saveSettings = new System.Windows.Forms.Button();
            this.cb_logType = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ayarlar";
            // 
            // cb_logs
            // 
            this.cb_logs.AutoSize = true;
            this.cb_logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_logs.Checked = true;
            this.cb_logs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_logs.ForeColor = System.Drawing.Color.White;
            this.cb_logs.Location = new System.Drawing.Point(14, 109);
            this.cb_logs.Name = "cb_logs";
            this.cb_logs.Size = new System.Drawing.Size(420, 46);
            this.cb_logs.TabIndex = 1;
            this.cb_logs.Text = "Logları otomatik kaydet";
            this.cb_logs.UseVisualStyleBackColor = true;
            this.cb_logs.CheckedChanged += new System.EventHandler(this.cb_logs_CheckedChanged);
            // 
            // bt_saveSettings
            // 
            this.bt_saveSettings.FlatAppearance.BorderSize = 0;
            this.bt_saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.bt_saveSettings.Location = new System.Drawing.Point(226, 601);
            this.bt_saveSettings.Name = "bt_saveSettings";
            this.bt_saveSettings.Size = new System.Drawing.Size(267, 78);
            this.bt_saveSettings.TabIndex = 2;
            this.bt_saveSettings.Text = "Kaydet";
            this.bt_saveSettings.UseVisualStyleBackColor = true;
            this.bt_saveSettings.Click += new System.EventHandler(this.bt_saveSettings_Click);
            // 
            // cb_logType
            // 
            this.cb_logType.AutoSize = true;
            this.cb_logType.Checked = true;
            this.cb_logType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_logType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_logType.Location = new System.Drawing.Point(114, 163);
            this.cb_logType.Name = "cb_logType";
            this.cb_logType.Size = new System.Drawing.Size(404, 35);
            this.cb_logType.TabIndex = 1;
            this.cb_logType.Text = "Tek dosya halinde kaydediliyor";
            this.cb_logType.UseVisualStyleBackColor = true;
            this.cb_logType.CheckedChanged += new System.EventHandler(this.cb_logType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "© Mehmet SÜMER ©";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_saveSettings);
            this.Controls.Add(this.cb_logType);
            this.Controls.Add(this.cb_logs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(744, 706);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_logs;
        private System.Windows.Forms.Button bt_saveSettings;
        private System.Windows.Forms.CheckBox cb_logType;
        private System.Windows.Forms.Label label2;
    }
}
