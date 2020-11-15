using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework1
{
	public partial class FormContact : Form
	{
		private contact changable;
		public FormContact(contact contact)
		{
			InitializeComponent();
			this.fillContact(contact);
		}
		public FormContact()
		{
			InitializeComponent();
		}
		private void fillContact(contact contact)
		{
			this.numID.Value = contact.id;
			this.tBNumber.Text = contact.telephone.ToString();
			this.tBAdress.Text = contact.adress.ToString();
			this.changable = contact;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				contact contact = new contact();
				contact.telephone = Convert.ToInt32(tBNumber.Text);
				contact.adress = tBAdress.Text.ToString();
				DBconnect.coursework.contact.Add(contact);
				DBconnect.coursework.SaveChanges();
				MessageBox.Show("Данные успешно добавлены");
				Close();
			}
			catch
			{
				MessageBox.Show("Неверные данные\nИли такие данные существуют");
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			try
			{				
				contact sd = DBconnect.coursework.contact.Find(numID.Value);

				if (sd == null)
				{
					MessageBox.Show("Такого объекта нет!");
				}

				tBNumber.Text = sd.telephone.ToString();
				tBAdress.Text = sd.adress.ToString();
				changable = sd;
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
		private void btUpdate_Click(object sender, EventArgs e)
		{
			if (changable == null)
			{
				MessageBox.Show("Вы еще не нашли объект");
				return;
			}
			try
			{
				contact sd = DBconnect.coursework.contact.Find(changable.id);
				sd.telephone = int.Parse(tBNumber.Text);
				DBconnect.coursework.SaveChanges();

				changable = null;
				MessageBox.Show("Данные успешно изменены");
			}
			catch
			{
				MessageBox.Show("Неверные данные\nИли такие данные существуют");
			}
		}
	}
}
