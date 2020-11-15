using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework1
{
	public partial class FormDatabase : Form
	{

		private string currentTable;
		public FormDatabase()
		{
			InitializeComponent();
		}
		public FormDatabase(string f)
		{
			InitializeComponent();
		}
		private void buttonStorage_Click(object sender, EventArgs e)
		{
			currentTable = "Склад";
			Database.DataSource = (from s in DBconnect.coursework.storage select new { s.id, s.name, s.name_type, s.provider_name, s.amount }).ToList();
		}

		private void buttonType_Click(object sender, EventArgs e)
		{
			currentTable = "Типы продуктов";
			Database.DataSource = (from t in DBconnect.coursework.type_product select new { t.id, t.type }).ToList();
		}

		private void buttonProvid_Click(object sender, EventArgs e)
		{
			currentTable = "Поставщики";
			Database.DataSource = (from p in DBconnect.coursework.provider select new { p.id, p.name, p.contract_date, p.contact }).ToList();
		}

		private void buttonContact_Click(object sender, EventArgs e)
		{
			currentTable = "Контакты";
			Database.DataSource = (from c in DBconnect.coursework.contact select new { c.id, c.telephone, c.adress }).ToList();
		}

		private void Database_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			if (e.RowIndex < 0) { return; }
			switch (currentTable)
			{
				case "Контакты":
					{
						Database.DataSource = (from c in DBconnect.coursework.contact select new { c.id, c.telephone, c.adress }).ToList();
						contact k = DBconnect.coursework.contact.Find(Convert.ToInt32(Database.Rows[e.RowIndex].Cells[0].Value));
						FormContact m = new FormContact(k);
						m.ShowDialog();
						break;
					}
				case "Склад":
					{
						Database.DataSource = (from s in DBconnect.coursework.storage select new { s.id, s.name, s.name_type, s.provider_name, s.amount }).ToList();
						storage o = DBconnect.coursework.storage.Find(Convert.ToInt32(Database.Rows[e.RowIndex].Cells[0].Value));
						FStorage f = new FStorage(o);
						f.ShowDialog();
						break;
					}
				case "Типы продуктов":
					{
						Database.DataSource = (from t in DBconnect.coursework.type_product select new { t.id, t.type }).ToList();
						type_product g = DBconnect.coursework.type_product.Find(Convert.ToInt32(Database.Rows[e.RowIndex].Cells[0].Value));
						FormType h = new FormType(g);
						h.ShowDialog();
						break;
					}
				case "Поставщики":
					{
						Database.DataSource = (from p in DBconnect.coursework.provider select new { p.id, p.name, p.contract_date, p.contact }).ToList();
						provider j = DBconnect.coursework.provider.Find(Convert.ToInt32(Database.Rows[e.RowIndex].Cells[0].Value));
						FormProvider b = new FormProvider(j);
						b.ShowDialog();
						break;
					}
			}
		}

		private void btnUI_Click_1(object sender, EventArgs e)
		{
			switch (currentTable)
			{
				case "Контакты":
					{
						FormContact f = new FormContact();
						f.Show();
						break;
					}
				case "Склад":
					{
						FStorage f = new FStorage();
						f.ShowDialog();
						break;
					}
				case "Типы продуктов":
					{
						FormType f = new FormType();
						f.ShowDialog();
						break;
					}
				case "Поставщики":
					{
						FormProvider f = new FormProvider();
						f.ShowDialog();
						break;
					}
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			switch (currentTable)
			{
				case "Склад":
					{
						storage storage = DBconnect.coursework.storage.AsEnumerable().Where(g => g.id == Convert.ToInt32(tBDel.Text)).FirstOrDefault();
						if (storage == null)
						{
							MessageBox.Show("Такие данные отсутсвуют");
						}
						else
						{
							DBconnect.coursework.storage.Remove(storage);
							DBconnect.coursework.SaveChanges();
							MessageBox.Show("Данные удалены и сохранены");
						}
						break;
					}

				case "Типы продуктов":
					{
						type_product type_product = DBconnect.coursework.type_product.AsEnumerable().Where(g => g.id == int.Parse(tBDel.Text)).FirstOrDefault();
						if (type_product == null)
						{
							MessageBox.Show("Такие данные отсутсвуют");
						}
						else
						{
							DBconnect.coursework.type_product.Remove(type_product);
							DBconnect.coursework.SaveChanges();
							MessageBox.Show("Данные удалены и сохранены");
						}
						break;
					}

				case "Поставщики":
					{
						provider provider = DBconnect.coursework.provider.AsEnumerable().Where(g => g.id == int.Parse(tBDel.Text)).FirstOrDefault();
						if (provider == null)
						{
							MessageBox.Show("Такие данные отсутсвуют");
						}
						else
						{
							DBconnect.coursework.provider.Remove(provider);
							DBconnect.coursework.SaveChanges();
							MessageBox.Show("Данные удалены и сохранены");
						}
						break;
					}
				case "Контакты":
					{
						contact contact = DBconnect.coursework.contact.AsEnumerable().Where(g => g.id == int.Parse(tBDel.Text)).FirstOrDefault();
						if (contact == null)
						{
							MessageBox.Show("Такие данные отсутсвуют");
						}
						else
						{
							DBconnect.coursework.contact.Remove(contact);
							DBconnect.coursework.SaveChanges();
							MessageBox.Show("Данные были удалены и сохранены");
						}
						break;
					}
			}
		}

		private void Database_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
			{
				switch (currentTable)
				{
					case "Контакты":
						{
							tBDel.Text = Database.Rows[e.RowIndex].Cells[0].Value.ToString();
							break;
						}
					case "Склад":
						{
							tBDel.Text = Database.Rows[e.RowIndex].Cells[0].Value.ToString();
							break;
						}
					case "Типы продуктов":
						{
							tBDel.Text = Database.Rows[e.RowIndex].Cells[0].Value.ToString();
							break;
						}
					case "Поставщики":
						{
							tBDel.Text = Database.Rows[e.RowIndex].Cells[0].Value.ToString();
							break;
						}
				}
			}
		
	}

}
