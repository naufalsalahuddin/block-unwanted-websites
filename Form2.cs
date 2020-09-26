using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Unwanted_Website_Blocking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"C:/Windows/System32/drivers/etc/hosts";


			if (File.Exists(fileName))
			{
				try
				{
                    
					File.Delete(fileName);
					using (FileStream fs = File.Create(fileName))
					MessageBox.Show("Error Successfully Removed");
					

				}
				catch (Exception exception)
				{
					MessageBox.Show("Error Not Removed, Please Try Again", exception.Message);

				}
			}
			else
			{
				using (FileStream fs = File.Create(fileName))
				MessageBox.Show("Error Successfully removed");
				
			}
			
		}

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }



    } 
