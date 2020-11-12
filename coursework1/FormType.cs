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
	public partial class FormType : Form
	{

		private type_product changable;

		public FormType(type_product type_product)
		{
			InitializeComponent();
			this.fillType(type_product);
		}
		public FormType()
		{

			InitializeComponent();
		}
		private void fillType(type_product type_product)
		{
			this.numID.Value = type_product.id;
			this.tBName.Text = type_product.type;
			this.changable = type_product;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
					type_product type_product = new type_product();
					type_product.type = tBName.Text;
					DBconnect.coursework.type_product.Add(type_product);
					DBconnect.coursework.SaveChanges();
					MessageBox.Show("Данные успешно добавлены");
					Close();
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			try
			{	
					type_product sd = DBconnect.coursework.type_product.Find(numID.Value);

					if (sd == null) 
					{
						MessageBox.Show("Такого объекта нет!");
					}

					tBName.Text = sd.type;
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

			type_product sd = DBconnect.coursework.type_product.Find(changable.id);
			sd.type = tBName.Text;
			DBconnect.coursework.SaveChanges();

			changable = null;
		}
	}
	
}
