namespace enFrenzyHack
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GlowUpdate = new System.Windows.Forms.TrackBar();
            this.glowUpdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GlowUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.GlowUpdate);
            this.panel1.Controls.Add(this.glowUpdLabel);
            this.panel1.Location = new System.Drawing.Point(23, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 86);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GlowUpdate
            // 
            this.GlowUpdate.Location = new System.Drawing.Point(7, 25);
            this.GlowUpdate.Maximum = 250;
            this.GlowUpdate.Minimum = 1;
            this.GlowUpdate.Name = "GlowUpdate";
            this.GlowUpdate.Size = new System.Drawing.Size(553, 56);
            this.GlowUpdate.TabIndex = 15;
            this.GlowUpdate.Value = 125;
            this.GlowUpdate.Scroll += new System.EventHandler(this.GlowUpdate_Scroll);
            // 
            // glowUpdLabel
            // 
            this.glowUpdLabel.AutoSize = true;
            this.glowUpdLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold);
            this.glowUpdLabel.ForeColor = System.Drawing.Color.Silver;
            this.glowUpdLabel.Location = new System.Drawing.Point(3, 0);
            this.glowUpdLabel.Name = "glowUpdLabel";
            this.glowUpdLabel.Size = new System.Drawing.Size(167, 22);
            this.glowUpdLabel.TabIndex = 14;
            this.glowUpdLabel.Text = "Glow update: 125";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(614, 426);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GlowUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label glowUpdLabel;
        private System.Windows.Forms.TrackBar GlowUpdate;
    }
}
