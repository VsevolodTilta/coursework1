namespace coursework1
{
	partial class FormProvider
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
			this.numContact = new System.Windows.Forms.NumericUpDown();
			this.numID = new System.Windows.Forms.NumericUpDown();
			this.lbStorage = new System.Windows.Forms.Label();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lID = new System.Windows.Forms.Label();
			this.lbContact = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.tBName = new System.Windows.Forms.TextBox();
			this.lName = new System.Windows.Forms.Label();
			this.dateCntr = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.numContact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(192, 70);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(57, 23);
			this.btnFind.TabIndex = 43;
			this.btnFind.Text = "Найти";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// numContact
			// 
			this.numContact.Location = new System.Drawing.Point(150, 228);
			this.numContact.Name = "numContact";
			this.numContact.Size = new System.Drawing.Size(100, 20);
			this.numContact.TabIndex = 42;
			// 
			// numID
			// 
			this.numID.Location = new System.Drawing.Point(150, 71);
			this.numID.Name = "numID";
			this.numID.Size = new System.Drawing.Size(37, 20);
			this.numID.TabIndex = 41;
			// 
			// lbStorage
			// 
			this.lbStorage.AutoSize = true;
			this.lbStorage.Location = new System.Drawing.Point(106, 25);
			this.lbStorage.Name = "lbStorage";
			this.lbStorage.Size = new System.Drawing.Size(71, 13);
			this.lbStorage.TabIndex = 40;
			this.lbStorage.Text = "Поставщики";
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(172, 270);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(78, 33);
			this.btUpdate.TabIndex = 37;
			this.btUpdate.Text = "Изменить";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(41, 270);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(78, 33);
			this.btnAdd.TabIndex = 36;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lID
			// 
			this.lID.AutoSize = true;
			this.lID.Location = new System.Drawing.Point(39, 73);
			this.lID.Name = "lID";
			this.lID.Size = new System.Drawing.Size(67, 13);
			this.lID.TabIndex = 35;
			this.lID.Text = "ID продукта";
			// 
			// lbContact
			// 
			this.lbContact.AutoSize = true;
			this.lbContact.Location = new System.Drawing.Point(39, 222);
			this.lbContact.Name = "lbContact";
			this.lbContact.Size = new System.Drawing.Size(71, 26);
			this.lbContact.TabIndex = 34;
			this.lbContact.Text = "Контакт\r\nПоставщика";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Location = new System.Drawing.Point(38, 165);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(100, 26);
			this.lbDate.TabIndex = 32;
			this.lbDate.Text = "Дата заключения \r\nдоговора";
			// 
			// tBName
			// 
			this.tBName.Location = new System.Drawing.Point(150, 119);
			this.tBName.Name = "tBName";
			this.tBName.Size = new System.Drawing.Size(100, 20);
			this.tBName.TabIndex = 31;
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Location = new System.Drawing.Point(38, 122);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(94, 13);
			this.lName.TabIndex = 30;
			this.lName.Text = "Имя поставщика";
			// 
			// dateCntr
			// 
			this.dateCntr.Location = new System.Drawing.Point(150, 165);
			this.dateCntr.Name = "dateCntr";
			this.dateCntr.Size = new System.Drawing.Size(99, 20);
			this.dateCntr.TabIndex = 44;
			// 
			// FormProvider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 329);
			this.Controls.Add(this.dateCntr);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.numContact);
			this.Controls.Add(this.numID);
			this.Controls.Add(this.lbStorage);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lID);
			this.Controls.Add(this.lbContact);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.tBName);
			this.Controls.Add(this.lName);
			this.Name = "FormProvider";
			this.Text = "Поставщики";
			((System.ComponentModel.ISupportInitialize)(this.numContact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.NumericUpDown numContact;
		private System.Windows.Forms.NumericUpDown numID;
		private System.Windows.Forms.Label lbStorage;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lID;
		private System.Windows.Forms.Label lbContact;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.TextBox tBName;
		private System.Windows.Forms.Label lName;
		private System.Windows.Forms.DateTimePicker dateCntr;
	}
}