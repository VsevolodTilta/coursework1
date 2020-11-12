namespace coursework1
{
	partial class FStorage
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
			this.tBType = new System.Windows.Forms.TextBox();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lID = new System.Windows.Forms.Label();
			this.lAmount = new System.Windows.Forms.Label();
			this.lType = new System.Windows.Forms.Label();
			this.tBName = new System.Windows.Forms.TextBox();
			this.lName = new System.Windows.Forms.Label();
			this.lbStorage = new System.Windows.Forms.Label();
			this.numID = new System.Windows.Forms.NumericUpDown();
			this.numAmount = new System.Windows.Forms.NumericUpDown();
			this.btnFind = new System.Windows.Forms.Button();
			this.tBProvide = new System.Windows.Forms.TextBox();
			this.lProvider = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// tBType
			// 
			this.tBType.Location = new System.Drawing.Point(148, 149);
			this.tBType.Name = "tBType";
			this.tBType.Size = new System.Drawing.Size(100, 20);
			this.tBType.TabIndex = 24;
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(170, 274);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(78, 33);
			this.btUpdate.TabIndex = 23;
			this.btUpdate.Text = "Изменить";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(39, 274);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(78, 33);
			this.btnAdd.TabIndex = 22;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
			// 
			// lID
			// 
			this.lID.AutoSize = true;
			this.lID.Location = new System.Drawing.Point(37, 77);
			this.lID.Name = "lID";
			this.lID.Size = new System.Drawing.Size(67, 13);
			this.lID.TabIndex = 19;
			this.lID.Text = "ID продукта";
			// 
			// lAmount
			// 
			this.lAmount.AutoSize = true;
			this.lAmount.Location = new System.Drawing.Point(36, 234);
			this.lAmount.Name = "lAmount";
			this.lAmount.Size = new System.Drawing.Size(95, 13);
			this.lAmount.TabIndex = 18;
			this.lAmount.Text = "Кол-во на складе";
			// 
			// lType
			// 
			this.lType.AutoSize = true;
			this.lType.Location = new System.Drawing.Point(36, 152);
			this.lType.Name = "lType";
			this.lType.Size = new System.Drawing.Size(81, 13);
			this.lType.TabIndex = 16;
			this.lType.Text = "Тип продуктов";
			// 
			// tBName
			// 
			this.tBName.Location = new System.Drawing.Point(148, 109);
			this.tBName.Name = "tBName";
			this.tBName.Size = new System.Drawing.Size(100, 20);
			this.tBName.TabIndex = 15;
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Location = new System.Drawing.Point(36, 112);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(106, 13);
			this.lName.TabIndex = 14;
			this.lName.Text = "Название продукта";
			// 
			// lbStorage
			// 
			this.lbStorage.AutoSize = true;
			this.lbStorage.Location = new System.Drawing.Point(129, 29);
			this.lbStorage.Name = "lbStorage";
			this.lbStorage.Size = new System.Drawing.Size(38, 13);
			this.lbStorage.TabIndex = 26;
			this.lbStorage.Text = "Склад";
			// 
			// numID
			// 
			this.numID.Location = new System.Drawing.Point(148, 75);
			this.numID.Name = "numID";
			this.numID.Size = new System.Drawing.Size(37, 20);
			this.numID.TabIndex = 27;
			// 
			// numAmount
			// 
			this.numAmount.Location = new System.Drawing.Point(148, 232);
			this.numAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numAmount.Name = "numAmount";
			this.numAmount.Size = new System.Drawing.Size(100, 20);
			this.numAmount.TabIndex = 28;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(190, 74);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(57, 23);
			this.btnFind.TabIndex = 29;
			this.btnFind.Text = "Найти";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// tBProvide
			// 
			this.tBProvide.Location = new System.Drawing.Point(148, 188);
			this.tBProvide.Name = "tBProvide";
			this.tBProvide.Size = new System.Drawing.Size(100, 20);
			this.tBProvide.TabIndex = 25;
			// 
			// lProvider
			// 
			this.lProvider.AutoSize = true;
			this.lProvider.Location = new System.Drawing.Point(36, 191);
			this.lProvider.Name = "lProvider";
			this.lProvider.Size = new System.Drawing.Size(68, 13);
			this.lProvider.TabIndex = 17;
			this.lProvider.Text = "Поставщик ";
			// 
			// FStorage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 329);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.numAmount);
			this.Controls.Add(this.numID);
			this.Controls.Add(this.lbStorage);
			this.Controls.Add(this.tBProvide);
			this.Controls.Add(this.tBType);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lID);
			this.Controls.Add(this.lAmount);
			this.Controls.Add(this.lProvider);
			this.Controls.Add(this.lType);
			this.Controls.Add(this.tBName);
			this.Controls.Add(this.lName);
			this.Name = "FStorage";
			this.Text = "Склад";
			((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tBType;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lID;
		private System.Windows.Forms.Label lAmount;
		private System.Windows.Forms.Label lType;
		private System.Windows.Forms.TextBox tBName;
		private System.Windows.Forms.Label lName;
		private System.Windows.Forms.Label lbStorage;
		private System.Windows.Forms.NumericUpDown numID;
		private System.Windows.Forms.NumericUpDown numAmount;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox tBProvide;
		private System.Windows.Forms.Label lProvider;
	}
}