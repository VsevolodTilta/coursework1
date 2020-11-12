namespace coursework1
{
	partial class FormType
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
			this.lbType = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.numID = new System.Windows.Forms.NumericUpDown();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lID = new System.Windows.Forms.Label();
			this.tBName = new System.Windows.Forms.TextBox();
			this.lName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
			this.SuspendLayout();
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Location = new System.Drawing.Point(97, 34);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(91, 13);
			this.lbType.TabIndex = 0;
			this.lbType.Text = "Типы Продуктов";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(194, 102);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(57, 23);
			this.btnFind.TabIndex = 42;
			this.btnFind.Text = "Найти";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// numID
			// 
			this.numID.Location = new System.Drawing.Point(151, 105);
			this.numID.Name = "numID";
			this.numID.Size = new System.Drawing.Size(37, 20);
			this.numID.TabIndex = 40;
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(173, 267);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(78, 33);
			this.btUpdate.TabIndex = 37;
			this.btUpdate.Text = "Изменить";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(42, 267);
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
			this.lID.Location = new System.Drawing.Point(39, 107);
			this.lID.Name = "lID";
			this.lID.Size = new System.Drawing.Size(44, 13);
			this.lID.TabIndex = 35;
			this.lID.Text = "ID типа";
			// 
			// tBName
			// 
			this.tBName.Location = new System.Drawing.Point(151, 166);
			this.tBName.Name = "tBName";
			this.tBName.Size = new System.Drawing.Size(100, 20);
			this.tBName.TabIndex = 31;
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Location = new System.Drawing.Point(39, 169);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(104, 13);
			this.lName.TabIndex = 30;
			this.lName.Text = "Имя типа продукта";
			// 
			// FormType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 329);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.numID);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lID);
			this.Controls.Add(this.tBName);
			this.Controls.Add(this.lName);
			this.Controls.Add(this.lbType);
			this.Name = "FormType";
			this.Text = "FormType";
			((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.NumericUpDown numID;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lID;
		private System.Windows.Forms.TextBox tBName;
		private System.Windows.Forms.Label lName;
	}
}