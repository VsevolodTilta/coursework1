using Microsoft.EntityFrameworkCore.Diagnostics;
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
	public partial class FStorage : Form
	{
		private storage chanhable;
		public FStorage(storage storage)
		{
			InitializeComponent();
			this.fillStorage(storage);
		}
		public FStorage()
		{
			InitializeComponent();
		}
		private void fillStorage(storage storage)
		{	
			this.numID.Value = storage.id; 
			this.tBName.Text = storage.name;
			this.tBType.Text = storage.name_type.ToString();
			this.tBProvide.Text = storage.provider_name.ToString();
			this.numAmount.Value = (int)storage.amount;
			this.chanhable = storage;
		}
		private void btnAdd_Click_1(object sender, EventArgs e)
		{
			try
			{
				storage storage = new storage();
				storage.name = tBName.Text;
				storage.name_type = int.Parse(tBType.Text);
				storage.provider_name = int.Parse(tBProvide.Text);
				storage.amount = (int)numAmount.Value;
				DBconnect.coursework.storage.Add(storage);
				DBconnect.coursework.SaveChanges();
				MessageBox.Show("Данные успешно добавлены");
				Close();
				
			}
			catch
			{
				MessageBox.Show("Неверные данные или \n такие данные уже существуют");
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			try
			{
				storage sd = DBconnect.coursework.storage.Find(numID.Value);

				if (sd == null)
				{
					MessageBox.Show("Такого объекта нет!");
				}

				
				tBName.Text = sd.name;
				tBType.Text = sd.name_type.ToString();
				tBProvide.Text = sd.provider_name.ToString();
				numAmount.Value = (int)sd.amount;
				chanhable = sd;
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void btUpdate_Click(object sender, EventArgs e)
		{
			if (chanhable == null)
			{
				MessageBox.Show("Вы еще не нашли объект");
				return;
			}
			try
			{ 
				storage sd = DBconnect.coursework.storage.Find(chanhable.id);
				sd.name = tBName.Text;
				sd.name_type = int.Parse(tBType.Text);
				sd.provider_name = int.Parse(tBProvide.Text);
				sd.amount = (int)numAmount.Value;
				DBconnect.coursework.SaveChanges();

				chanhable = null;
				MessageBox.Show("Данные изменены");
			}
			catch
			{
				MessageBox.Show("Неверные данные или \n такие данные уже существуют");
			}
		}
	}
}
