namespace coursework1
{
	partial class authorization
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
			this.lbLogin = new System.Windows.Forms.Label();
			this.lbPass = new System.Windows.Forms.Label();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.btEnter = new System.Windows.Forms.Button();
			this.lbName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Location = new System.Drawing.Point(73, 63);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(80, 26);
			this.lbLogin.TabIndex = 0;
			this.lbLogin.Text = "        Имя \r\nПользователя";
			// 
			// lbPass
			// 
			this.lbPass.AutoSize = true;
			this.lbPass.Location = new System.Drawing.Point(89, 144);
			this.lbPass.Name = "lbPass";
			this.lbPass.Size = new System.Drawing.Size(45, 13);
			this.lbPass.TabIndex = 1;
			this.lbPass.Text = "Пароль";
			// 
			// tbLog
			// 
			this.tbLog.Location = new System.Drawing.Point(51, 92);
			this.tbLog.Name = "tbLog";
			this.tbLog.Size = new System.Drawing.Size(123, 20);
			this.tbLog.TabIndex = 2;
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(51, 160);
			this.tbPass.Name = "tbPass";
			this.tbPass.Size = new System.Drawing.Size(123, 20);
			this.tbPass.TabIndex = 3;
			// 
			// btEnter
			// 
			this.btEnter.Location = new System.Drawing.Point(76, 218);
			this.btEnter.Name = "btEnter";
			this.btEnter.Size = new System.Drawing.Size(77, 31);
			this.btEnter.TabIndex = 4;
			this.btEnter.Text = "Войти";
			this.btEnter.UseVisualStyleBackColor = true;
			this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbName.Location = new System.Drawing.Point(50, 9);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(129, 24);
			this.lbName.TabIndex = 5;
			this.lbName.Text = "Авторизация";
			// 
			// authorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 261);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.btEnter);
			this.Controls.Add(this.tbPass);
			this.Controls.Add(this.tbLog);
			this.Controls.Add(this.lbPass);
			this.Controls.Add(this.lbLogin);
			this.Name = "authorization";
			this.Text = "Организация бара";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label lbPass;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Button btEnter;
		private System.Windows.Forms.Label lbName;
	}
}