using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent(); 
		 
		}

		private void greetButton_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			greetLabel.Text = $"{dateTime.ToString("yyyy/MM/dd HH:mm:ss")}\r\n您好";
			MessageBox.Show(dateTime.ToString("yyyy/MM/dd HH:mm:ss"), "問候與時間");

		}
	}
}
