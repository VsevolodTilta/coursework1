namespace coursework1
{
	partial class FormContact
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
			this.btnFind = new System.Windows.Forms.Button();
			this.numID = new System.Windows.Forms.NumericUpDown();
			this.lbContact = new System.Windows.Forms.Label();
			this.tBAdress = new System.Windows.Forms.TextBox();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lID = new System.Windows.Forms.Label();
			this.lbAdress = new System.Windows.Forms.Label();
			this.tBNumber = new System.Windows.Forms.TextBox();
			this.lbNumber = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(192, 70);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(57, 23);
			this.btnFind.TabIndex = 55;
			this.btnFind.Text = "Найти";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// numID
			// 
			this.numID.Location = new System.Drawing.Point(150, 71);
			this.numID.Name = "numID";
			this.numID.Size = new System.Drawing.Size(37, 20);
			this.numID.TabIndex = 53;
			// 
			// lbContact
			// 
			this.lbContact.AutoSize = true;
			this.lbContact.Location = new System.Drawing.Point(106, 25);
			this.lbContact.Name = "lbContact";
			this.lbContact.Size = new System.Drawing.Size(56, 13);
			this.lbContact.TabIndex = 52;
			this.lbContact.Text = "Контакты";
			// 
			// tBAdress
			// 
			this.tBAdress.Location = new System.Drawing.Point(149, 205);
			this.tBAdress.Name = "tBAdress";
			this.tBAdress.Size = new System.Drawing.Size(100, 20);
			this.tBAdress.TabIndex = 51;
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(172, 270);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(78, 33);
			this.btUpdate.TabIndex = 50;
			this.btUpdate.Text = "Изменить";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(41, 270);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(78, 33);
			this.btnAdd.TabIndex = 49;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lID
			// 
			this.lID.AutoSize = true;
			this.lID.Location = new System.Drawing.Point(38, 70);
			this.lID.Name = "lID";
			this.lID.Size = new System.Drawing.Size(67, 13);
			this.lID.TabIndex = 48;
			this.lID.Text = "ID контакта";
			// 
			// lbAdress
			// 
			this.lbAdress.AutoSize = true;
			this.lbAdress.Location = new System.Drawing.Point(38, 208);
			this.lbAdress.Name = "lbAdress";
			this.lbAdress.Size = new System.Drawing.Size(38, 13);
			this.lbAdress.TabIndex = 46;
			this.lbAdress.Text = "Адрес";
			// 
			// tBNumber
			// 
			this.tBNumber.Location = new System.Drawing.Point(150, 137);
			this.tBNumber.Name = "tBNumber";
			this.tBNumber.Size = new System.Drawing.Size(100, 20);
			this.tBNumber.TabIndex = 45;
			// 
			// lbNumber
			// 
			this.lbNumber.AutoSize = true;
			this.lbNumber.Location = new System.Drawing.Point(38, 137);
			this.lbNumber.Name = "lbNumber";
			this.lbNumber.Size = new System.Drawing.Size(41, 13);
			this.lbNumber.TabIndex = 44;
			this.lbNumber.Text = "Номер";
			// 
			// FormContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 329);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.numID);
			this.Controls.Add(this.lbContact);
			this.Controls.Add(this.tBAdress);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lID);
			this.Controls.Add(this.lbAdress);
			this.Controls.Add(this.tBNumber);
			this.Controls.Add(this.lbNumber);
			this.Name = "FormContact";
			this.Text = "FormContact";
			((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.NumericUpDown numID;
		private System.Windows.Forms.Label lbContact;
		private System.Windows.Forms.TextBox tBAdress;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lID;
		private System.Windows.Forms.Label lbAdress;
		private System.Windows.Forms.TextBox tBNumber;
		private System.Windows.Forms.Label lbNumber;
	}
}