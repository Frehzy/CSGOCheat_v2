namespace enFrenzyHack
{
    partial class LegitControl
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
            this.GlowChecked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "LegitBot";
            // 
            // GlowChecked
            // 
            this.GlowChecked.AutoSize = true;
            this.GlowChecked.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlowChecked.ForeColor = System.Drawing.Color.Gray;
            this.GlowChecked.Location = new System.Drawing.Point(23, 68);
            this.GlowChecked.Name = "GlowChecked";
            this.GlowChecked.Size = new System.Drawing.Size(107, 26);
            this.GlowChecked.TabIndex = 13;
            this.GlowChecked.Text = "GlowESP";
            this.GlowChecked.UseVisualStyleBackColor = true;
            this.GlowChecked.CheckedChanged += new System.EventHandler(this.GlowChecked_CheckedChanged);
            // 
            // LegitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.GlowChecked);
            this.Controls.Add(this.label1);
            this.Name = "LegitControl";
            this.Size = new System.Drawing.Size(614, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GlowChecked;
    }
}
