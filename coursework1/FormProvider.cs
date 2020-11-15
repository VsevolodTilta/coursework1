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
	public partial class FormProvider : Form
	{
		private provider changable;
		public FormProvider(provider provider)
		{
			InitializeComponent();
			this.fillProvider(provider);
		}
		public FormProvider()
		{
			InitializeComponent();
		}
		private void fillProvider(provider provider)
		{
			this.numID.Value = provider.id;
			this.tBName.Text = provider.name;
			this.dateCntr.Value = DateTime.Parse(provider.contract_date.ToString());
			this.numContact.Text = provider.contact.ToString();
			this.changable = provider;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				provider provider = new provider();
				provider.name = tBName.Text;
				provider.contract_date = dateCntr.Value;
				provider.contact = (int)numContact.Value;
				DBconnect.coursework.provider.Add(provider);
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
				provider sd = DBconnect.coursework.provider.Find(numID.Value);

				if (sd == null)
				{
					MessageBox.Show("Такого объекта нет!");
				}

				tBName.Text = sd.name;
				dateCntr.Value = DateTime.Parse(sd.contract_date.ToString());
				numContact.Value = (int)sd.contact;

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
				provider sd = DBconnect.coursework.provider.Find(changable.id);
				sd.name = tBName.Text;
				sd.contract_date = dateCntr.Value;
				sd.contact = (int)numContact.Value;
				DBconnect.coursework.SaveChanges();
				
				changable = null;
			}
			catch
			{
				MessageBox.Show("Неверные данные\nИли такие данные существуют");
			}	
		}
	}
}
