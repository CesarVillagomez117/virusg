/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 22/10/2024
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace virus
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string fecha="", nombres="", apellidoP="", apellidoM="";
		void Button1Click(object sender, EventArgs e)
		{
			nombres=TXTnombre.Text;
			apellidoP=TXTapellidoP.Text;
			apellidoM=TXTapellidoM.Text; 
			string fecha1=fecha.Substring(0,2);
			string fecha2=fecha.Substring(4,5);
			string fecha4=fecha.Substring(0,1);
			string name=nombres.Substring(0);
			string paterno=apellidoP.Substring(0,1);
			string materno=apellidoM.Substring(0,1);
			LBLrfc.Text=fecha1+fecha2+fecha4+name+paterno+materno;
			
		}
	}
}
