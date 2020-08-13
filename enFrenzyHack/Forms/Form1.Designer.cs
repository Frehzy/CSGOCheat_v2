namespace enFrenzyHack
{
    partial class enFrenzyHackForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enFrenzyHackForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.InjectButton = new System.Windows.Forms.Button();
            this.DebugButton = new System.Windows.Forms.Button();
            this.LegitBotButton = new System.Windows.Forms.Button();
            this.RageBotButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.settingsControl1 = new enFrenzyHack.SettingsControl();
            this.rageControl1 = new enFrenzyHack.RageControl();
            this.legitControl1 = new enFrenzyHack.LegitControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.ProjectLabel);
            this.panel1.Controls.Add(this.InjectButton);
            this.panel1.Controls.Add(this.DebugButton);
            this.panel1.Controls.Add(this.LegitBotButton);
            this.panel1.Controls.Add(this.RageBotButton);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 426);
            this.panel1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(25, 378);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(112, 37);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.ForeColor = System.Drawing.Color.Silver;
            this.ProjectLabel.Location = new System.Drawing.Point(10, 13);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(139, 37);
            this.ProjectLabel.TabIndex = 7;
            this.ProjectLabel.Text = "enFrenzy";
            // 
            // InjectButton
            // 
            this.InjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectButton.ForeColor = System.Drawing.Color.Gray;
            this.InjectButton.Location = new System.Drawing.Point(11, 319);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(143, 56);
            this.InjectButton.TabIndex = 0;
            this.InjectButton.Text = "Inject";
            this.InjectButton.UseVisualStyleBackColor = true;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // DebugButton
            // 
            this.DebugButton.Enabled = false;
            this.DebugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugButton.ForeColor = System.Drawing.Color.Gray;
            this.DebugButton.Location = new System.Drawing.Point(11, 230);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(143, 50);
            this.DebugButton.TabIndex = 5;
            this.DebugButton.Text = "Debug";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // LegitBotButton
            // 
            this.LegitBotButton.Enabled = false;
            this.LegitBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LegitBotButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegitBotButton.ForeColor = System.Drawing.Color.Gray;
            this.LegitBotButton.Location = new System.Drawing.Point(11, 62);
            this.LegitBotButton.Name = "LegitBotButton";
            this.LegitBotButton.Size = new System.Drawing.Size(143, 50);
            this.LegitBotButton.TabIndex = 2;
            this.LegitBotButton.Text = "LegitBot";
            this.LegitBotButton.UseVisualStyleBackColor = true;
            this.LegitBotButton.Click += new System.EventHandler(this.LegitBotButton_Click);
            // 
            // RageBotButton
            // 
            this.RageBotButton.Enabled = false;
            this.RageBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RageBotButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RageBotButton.ForeColor = System.Drawing.Color.Gray;
            this.RageBotButton.Location = new System.Drawing.Point(11, 118);
            this.RageBotButton.Name = "RageBotButton";
            this.RageBotButton.Size = new System.Drawing.Size(143, 50);
            this.RageBotButton.TabIndex = 3;
            this.RageBotButton.Text = "RageBot";
            this.RageBotButton.UseVisualStyleBackColor = true;
            this.RageBotButton.Click += new System.EventHandler(this.RageBotButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Enabled = false;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Gray;
            this.SettingsButton.Location = new System.Drawing.Point(11, 174);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(143, 50);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Gray;
            this.ExitButton.Location = new System.Drawing.Point(738, 25);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 50);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.settingsControl1.Location = new System.Drawing.Point(186, 12);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(614, 426);
            this.settingsControl1.TabIndex = 19;
            // 
            // rageControl1
            // 
            this.rageControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.rageControl1.Location = new System.Drawing.Point(186, 12);
            this.rageControl1.Name = "rageControl1";
            this.rageControl1.Size = new System.Drawing.Size(614, 426);
            this.rageControl1.TabIndex = 20;
            // 
            // legitControl1
            // 
            this.legitControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.legitControl1.Location = new System.Drawing.Point(186, 12);
            this.legitControl1.Name = "legitControl1";
            this.legitControl1.Size = new System.Drawing.Size(614, 426);
            this.legitControl1.TabIndex = 21;
            // 
            // enFrenzyHackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.legitControl1);
            this.Controls.Add(this.rageControl1);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "enFrenzyHackForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Button InjectButton;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.Button LegitBotButton;
        private System.Windows.Forms.Button RageBotButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private SettingsControl settingsControl1;
        private RageControl rageControl1;
        private LegitControl legitControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

