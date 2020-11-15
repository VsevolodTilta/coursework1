namespace coursework1
{
	partial class FormDatabase
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
			this.Database = new System.Windows.Forms.DataGridView();
			this.buttonStorage = new System.Windows.Forms.Button();
			this.buttonType = new System.Windows.Forms.Button();
			this.buttonProvid = new System.Windows.Forms.Button();
			this.buttonContact = new System.Windows.Forms.Button();
			this.btnUI = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.lbID = new System.Windows.Forms.Label();
			this.tBDel = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
			this.SuspendLayout();
			// 
			// Database
			// 
			this.Database.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Database.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Database.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Database.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.Database.GridColor = System.Drawing.SystemColors.Control;
			this.Database.Location = new System.Drawing.Point(12, 53);
			this.Database.Name = "Database";
			this.Database.Size = new System.Drawing.Size(776, 385);
			this.Database.TabIndex = 0;
			this.Database.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Database_CellMouseClick);
			this.Database.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Database_CellMouseDoubleClick);
			// 
			// buttonStorage
			// 
			this.buttonStorage.Location = new System.Drawing.Point(12, 12);
			this.buttonStorage.Name = "buttonStorage";
			this.buttonStorage.Size = new System.Drawing.Size(86, 35);
			this.buttonStorage.TabIndex = 1;
			this.buttonStorage.Text = "Склад";
			this.buttonStorage.UseVisualStyleBackColor = true;
			this.buttonStorage.Click += new System.EventHandler(this.buttonStorage_Click);
			// 
			// buttonType
			// 
			this.buttonType.Location = new System.Drawing.Point(104, 12);
			this.buttonType.Name = "buttonType";
			this.buttonType.Size = new System.Drawing.Size(109, 35);
			this.buttonType.TabIndex = 2;
			this.buttonType.Text = "Типы продуктов";
			this.buttonType.UseVisualStyleBackColor = true;
			this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
			// 
			// buttonProvid
			// 
			this.buttonProvid.Location = new System.Drawing.Point(219, 12);
			this.buttonProvid.Name = "buttonProvid";
			this.buttonProvid.Size = new System.Drawing.Size(89, 35);
			this.buttonProvid.TabIndex = 3;
			this.buttonProvid.Text = "Поставщики";
			this.buttonProvid.UseVisualStyleBackColor = true;
			this.buttonProvid.Click += new System.EventHandler(this.buttonProvid_Click);
			// 
			// buttonContact
			// 
			this.buttonContact.Location = new System.Drawing.Point(314, 12);
			this.buttonContact.Name = "buttonContact";
			this.buttonContact.Size = new System.Drawing.Size(134, 35);
			this.buttonContact.TabIndex = 4;
			this.buttonContact.Text = "Контакты поставщика";
			this.buttonContact.UseVisualStyleBackColor = true;
			this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
			// 
			// btnUI
			// 
			this.btnUI.Location = new System.Drawing.Point(638, 12);
			this.btnUI.Name = "btnUI";
			this.btnUI.Size = new System.Drawing.Size(150, 35);
			this.btnUI.TabIndex = 5;
			this.btnUI.Text = "Добавление и изменение";
			this.btnUI.UseVisualStyleBackColor = true;
			this.btnUI.Click += new System.EventHandler(this.btnUI_Click_1);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(514, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(118, 35);
			this.btnDel.TabIndex = 6;
			this.btnDel.Text = "Удалить";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(470, 11);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(18, 13);
			this.lbID.TabIndex = 8;
			this.lbID.Text = "ID";
			// 
			// tBDel
			// 
			this.tBDel.Location = new System.Drawing.Point(454, 27);
			this.tBDel.Name = "tBDel";
			this.tBDel.Size = new System.Drawing.Size(54, 20);
			this.tBDel.TabIndex = 9;
			// 
			// FormDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 421);
			this.Controls.Add(this.tBDel);
			this.Controls.Add(this.lbID);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnUI);
			this.Controls.Add(this.buttonContact);
			this.Controls.Add(this.buttonProvid);
			this.Controls.Add(this.buttonType);
			this.Controls.Add(this.buttonStorage);
			this.Controls.Add(this.Database);
			this.Name = "FormDatabase";
			this.Text = "Бар";
			((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Database;
		private System.Windows.Forms.Button buttonStorage;
		private System.Windows.Forms.Button buttonType;
		private System.Windows.Forms.Button buttonProvid;
		private System.Windows.Forms.Button buttonContact;
		private System.Windows.Forms.Button btnUI;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.TextBox tBDel;
	}
}

