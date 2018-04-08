using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRevenue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SName_Click(object sender, EventArgs e)
        {
            MoviesList.Items.Clear();
            string path = Application.StartupPath + @"\\MovieRevenue.txt";
            string[] data = File.ReadAllLines(path);

            foreach (var d in data)
            {
                string temp = d;
                string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });

                string temp2 = data2[0] + ">>>>" + data2[1];
                MoviesList.Items.Add(temp2);
            }

            List<string> temp3 = new List<string>();
            foreach(var o in MoviesList.Items)
            {
                temp3.Add(o.ToString());
            }

            temp3.Sort();
            MoviesList.Items.Clear();
            foreach (var o in temp3)
            {
                MoviesList.Items.Add(o);
            }

        }     

        private void btn_SRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string searchWord = string.Empty;
            if (cb_name.Checked )
            {
                searchWord = inp_SearchName.Text;


                MoviesList.Items.Clear();
                string path = Application.StartupPath + @"\\MovieRevenue.txt";
                string[] data = File.ReadAllLines(path);

                MoviesList.Items.Clear();
                foreach (var d in data)
                {
                    string temp = d;
                    string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });

                    string temp2 = data2[0] + ">>>>" + data2[1];

                    if (temp2.Contains(searchWord))
                    {                        
                        MoviesList.Items.Add(temp2);
                        flag = 1;
                    }

                }
            }

            if (cb_revenue.Checked)
            {

                int tt = 0;
                searchWord = inp_SearchName.Text;

                if (int.TryParse(searchWord.ToString(), out tt))
                {

                    MoviesList.Items.Clear();
                    string path = Application.StartupPath + @"\\MovieRevenue.txt";
                    string[] data = File.ReadAllLines(path);

                    MoviesList.Items.Clear();
                    foreach (var d in data)
                    {
                        string temp = d;
                        string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });
                        string temp2 = data2[0] + "<<<<" + data2[1];
                        string t = data2[1];
                        float searchVal = float.Parse(searchWord);
                        float movieval = float.Parse(t);

                        if (temp2.Contains(searchWord))
                        {
                            MoviesList.Items.Add(temp2);
                            flag = 1;
                        }
                        else if (searchVal == movieval)
                        {
                            MoviesList.Items.Add(temp2);
                            flag = 1;
                        }
                        else if (searchVal > movieval)
                        {
                            MoviesList.Items.Add(temp2);
                            flag = 1;
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Not numeric-please re-enter");
                    return;
                }
            }



            if (flag == 0)
            {
                MoviesList.Items.Clear();
                string res = "No movie with those charecters";
                MoviesList.Items.Add(res);
            }
        }
    }
}
