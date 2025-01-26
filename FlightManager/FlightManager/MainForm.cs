/*
 * Created by SharpDevelop.
 * User: Family
 * Date: 26/01/2025
 * Time: 01:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace FlightManager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private DatabaseHelper accessDatabase;
				
         public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			accessDatabase = new DatabaseHelper();
			accessDatabase.InitializeDatabase();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	}
}
