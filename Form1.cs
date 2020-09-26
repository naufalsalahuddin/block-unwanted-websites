using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Unwanted_Website_Blocking

{


    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string host = "0.0.0.0 ";


        private void button1_Click(object sender, EventArgs e)
        {
            string hostcompleteaddress1 = @"C:/Windows/System32/drivers/etc/hosts";
            string readhost1 = File.ReadAllText(hostcompleteaddress1);
            string dra = "0.0.0.0 ";
            string dar = Environment.NewLine + dra;


            string websites = "xnxx.com" + dar + "pornhat.com" + dar + "tumblr.com" + dar + "pornhub.com" + dar + "stripchat.com" + dar + "xhamster.com" + dar + "xtube.com" + dar + "mvtube.com" + dar + "onlyfans.com" + dar + "xvideos.com" + dar + "xxx.com" + dar + "youporn.com" + dar + "tube8.com" + dar + "pornhd.com" + dar + "youjizz.com" + dar + "metaporn.com" + dar + "porn.biz" + dar + "18asiantube.com" + dar + "lesbian8.com" + dar + "fuck.com" + dar + "fux.com" + dar + "pornburst.com" + dar + "porn.com" + dar + "xnxx" + dar + "xxx" + dar + "porn" + dar + "zbporn" + dar + "tumblr.uk" + dar + "watchmygirlfriend.tv";

            if (readhost1.Contains(websites))
            {
                MessageBox.Show("Already Blocked");
            }

            else
            {
                MessageBox.Show("Successfully Blocked");

                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                {
                    w.WriteLine(host + websites);
                }

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string hostaddress = "drivers/etc/hosts";
            string hostcompleteaddress = @"C:/Windows/System32/drivers/etc/hosts";
            string readhost = File.ReadAllText(hostcompleteaddress);
            string f = textBox1.Text;

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Website Url");
            }


            if (readhost.Contains(textBox1.Text))
            {
                if (textBox1.Text.Length >= 1)
                {
                    MessageBox.Show("Already Blocked");
                }

            }

            else if (textBox1.Text.Contains("."))
            {
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), hostaddress)))
                {
                    w.WriteLine(host + f);
                }
                MessageBox.Show("Successfully Blocked");

            }

            else
            {
                MessageBox.Show("Please Enter Correct URL");
            }



        }







        private void button4_Click_2(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox1();
            newForm.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            string path= @"C:/Windows/System32/drivers/etc/hosts";
            string lineToBeRemoved = host + textBox2.Text;               
            string[] readText = File.ReadAllLines(path);
            string hostread = File.ReadAllText(path);


            if (textBox2.Text.Contains("."))
            {
                if (hostread.Contains(lineToBeRemoved))
                {
                    File.WriteAllText(path, String.Empty);
                    MessageBox.Show("Successfully UnBlocked");

                    using (StreamWriter writer = new StreamWriter(path))

                    {
                        foreach (string s in readText)
                        {
                            if (!s.Equals(lineToBeRemoved))
                            {
                                writer.WriteLine(s);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This URL Is Not Blocked, If You Want To Block This, Type This URL In Above Box And Then Click On Block");
                }
            }
            else
            
            {
                MessageBox.Show("Please Enter Correct URL"); 
            }

                
            

        }
    }
}