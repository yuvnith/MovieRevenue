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
            //MoviesList.Items.Clear();
            //string path = Application.StartupPath + @"\\MovieRevenue.txt";
            //string[] data = File.ReadAllLines(path);

            //foreach (var d in data)
            //{
            //    string temp = d;
            //    string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });

            //    string temp2 = data2[0] + ">>>>" + data2[1];
            //    MoviesList.Items.Add(temp2);
            //}

            //List<string> temp3 = new List<string>();
            //foreach(var o in MoviesList.Items)
            //{
            //    temp3.Add(o.ToString());
            //}

            //temp3.Sort();
            //MoviesList.Items.Clear();
            //foreach (var o in temp3)
            //{
            //    MoviesList.Items.Add(o);
            //}

            string[] data = ReadIntoArray();

            string[,] sorteddata = SelectionSortByName(data);
            int len = data.Length;

            for (int i = 0; i < len; i++)
            DisplayRevenue(sorteddata[i, 0] + ">>>>" + sorteddata[i, 1]);
            

        }

        public string[] ReadIntoArray()
        {
            string path = Application.StartupPath + @"\\MovieRevenue.txt";
            StreamReader reader = new StreamReader(path);
            
            string[] data = new string[100];

            int i = 0;
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                //string[] data2 = line.Split(new char[] { '@', '=', '}', '{' });
                //string temp = data2[0] + ">>>>" + data2[1];
                data[i] = line;
                i++;
            }

            Array.Resize(ref data, i);

            return data;
        }

        public string[,] SelectionSortByName(string[] data)
        {
            MoviesList.Items.Clear();
            List<Movie> data2 = new List<Movie>();
            foreach (var s in data)
            {
                string[] temp = s.Split(new char[] { '@', '=', '}', '{' });
                data2.Add( new Movie() {Name = temp[0], Revenue = double.Parse(temp[1])});
            }

            //data2.Sort();

            List<Movie> sortedlist = data2.OrderBy(o => o.Name).ToList();

            int i = 0;
            string[,] sorteddata = new string[ data.Length,2];
            foreach (var movie in sortedlist)
            {
                sorteddata[i, 0] = movie.Name;
                sorteddata[i, 1] = movie.Revenue.ToString();
                i++;
            }
            return sorteddata;
        }

        public string[,] SelectionSortByRevenue(string[] data)
        {
            MoviesList.Items.Clear();
            List<Movie> data2 = new List<Movie>();
            foreach (var s in data)
            {
                string[] temp = s.Split(new char[] { '@', '=', '}', '{' });
                data2.Add(new Movie() { Name = temp[0], Revenue = double.Parse(temp[1]) });
            }

            List<Movie> sortedlist = data2.OrderByDescending(o => o.Revenue).ToList();

            int i = 0;
            string[,] sorteddata = new string[data.Length,2];
            foreach (var movie in sortedlist)
            {
                sorteddata[i, 0] = movie.Name;
                sorteddata[i, 1] = movie.Revenue.ToString();
                i++;
            }
            return sorteddata;
        }

        public void BinSearchByName(string[,] sorteddata,string Name)
        {
            MoviesList.Items.Clear();
            int flag = 0;
            for (int i = 0; i < sorteddata.GetLength(0); i++)
            {
                if (sorteddata[i, 0].ToUpper().Contains(Name))
                {
                    DisplayRevenue(sorteddata[i, 0] + ">>>>" + sorteddata[i, 1]);
                    flag = 1;
                }
            }

            if (flag == 0)
                MoviesList.Items.Add("Movie not found");
        }

        public void BinSearchByRevenue(string[,] sorteddata,string Revenue)
        {
            MoviesList.Items.Clear();
            int flag = 0;


            double temp;
            if (!double.TryParse(Revenue, out temp))
            {
                DisplayRevenue("Invalid data ");

            }
            else
            {

                DisplayRevenue("No Movie has the EXACT Revenue");
                DisplayRevenue("===============================");
                for (int i = 0; i < sorteddata.GetLength(0); i++)
                {
                    if (sorteddata[i, 1] == Revenue)
                    {
                        MoviesList.Items.Clear();
                        DisplayRevenue(sorteddata[i, 0] + ">>>>" + sorteddata[i, 1]);
                        flag = 1;
                        break;
                    }

                    else if (double.Parse(sorteddata[i, 1]) < Double.Parse(Revenue))
                    {
                        DisplayRevenue(sorteddata[i, 0] + "<<<<" + sorteddata[i, 1]);
                        flag = 1;
                    }
                }
                if (flag == 0)
                    MoviesList.Items.Add("Movie not found");

            }


        }
        public void DisplayRevenue(string data)
        {
            MoviesList.Items.Add(data);
        }


        private void btn_SRevenue_Click(object sender, EventArgs e)
        {
            //var myList = new List<Movie>();
            //MoviesList.Items.Clear();
            //string path = Application.StartupPath + @"\\MovieRevenue.txt";
            //string[] data = File.ReadAllLines(path);

            //foreach (var d in data)
            //{
            //    string temp = d;
            //    string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });

            //    Movie m = new Movie(){Name = data2[0],Revenue = double.Parse(data2[1].ToString())};
            //    myList.Add(m);
            //}
            //List<Movie> SortedList = myList.OrderBy(o => o.Revenue).ToList();

            //foreach (var movie in SortedList)
            //{
            //    string temp = string.Empty;
            //    temp += movie.Name;
            //    temp += "<<<<";
            //    temp += movie.Revenue;

            //    MoviesList.Items.Add(temp);
            //}


            string[] data = ReadIntoArray();

            string[,] sorteddata = SelectionSortByRevenue(data);

            for (int i = 0; i < data.Length; i++)
                DisplayRevenue(sorteddata[i, 0] + ">>>>" + sorteddata[i, 1]);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string searchWord = inp_SearchName.Text.ToUpper();
            if (cb_name.Checked )
            {
                //searchWord = inp_SearchName.Text;


                //MoviesList.Items.Clear();
                //string path = Application.StartupPath + @"\\MovieRevenue.txt";
                //string[] data = File.ReadAllLines(path);

                //MoviesList.Items.Clear();
                //foreach (var d in data)
                //{
                //    string temp = d;
                //    string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });

                //    string temp2 = data2[0] + ">>>>" + data2[1];

                //    if (temp2.Contains(searchWord))
                //    {                        
                //        MoviesList.Items.Add(temp2);
                //        flag = 1;
                //    }

                //}


                string[] data = ReadIntoArray();

                string[,] sorteddata = SelectionSortByName(data);

                BinSearchByName(sorteddata,searchWord);


            }

            if (cb_revenue.Checked)
            {

                //float tt = 0;
                //searchWord = inp_SearchName.Text;

                //if (float.TryParse(searchWord.ToString(), out tt))
                //{

                //    MoviesList.Items.Clear();
                //    string path = Application.StartupPath + @"\\MovieRevenue.txt";
                //    string[] data = File.ReadAllLines(path);

                //    MoviesList.Items.Clear();
                //    foreach (var d in data)
                //    {
                //        string temp = d;
                //        string[] data2 = temp.Split(new char[] { '@', '=', '}', '{' });
                //        string temp2 = data2[0] + "<<<<" + data2[1];
                //        string t = data2[1];
                //        float searchVal = float.Parse(searchWord);
                //        float movieval = float.Parse(t);
                //        if (searchVal == movieval)
                //        {
                //            MoviesList.Items.Clear();
                //            MoviesList.Items.Add(temp2);
                //            flag = 1;
                //            break;
                //        }
                //        //else if (temp2.Contains(searchWord))
                //        //{
                //        //    MoviesList.Items.Add(temp2);
                //        //    flag = 1;
                //        //}

                //        else if (searchVal > movieval)
                //        {
                //            MoviesList.Items.Add(temp2);
                //            flag = 1;
                //        }


                //    }

                string[] data = ReadIntoArray();

                string[,] sorteddata = SelectionSortByName(data);

                BinSearchByRevenue(sorteddata, searchWord);
            }
                //else
                //{
                //    MessageBox.Show("Not numeric-please re-enter");
                //    return;
                //}
            



            
        }
    }

    class Movie
    {
        public string Name { get; set; }
        public double Revenue { get; set; }
    }
}
