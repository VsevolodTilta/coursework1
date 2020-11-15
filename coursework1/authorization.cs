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
	public partial class authorization : Form
	{
		public authorization()
		{
			InitializeComponent();
		}

		private void btEnter_Click(object sender, EventArgs e)
		{
			FormDatabase f = new FormDatabase("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source=DESKTOP-AQA6PRV\\SQLEXPRESS;initial catalog=coursework;integrated security=False;user id="+tbLog.Text+";password="+tbPass.Text+";MultipleActiveResultSets=True;App=EntityFramework\"");
			f.ShowDialog();
		}
	}
}
