using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using BookStoreClessLibrary;
using BookStoreClient.ServiceReference1;

namespace BookStoreClient
{
    public partial class Client : Form
    {
        BookStoreServiceClient proxy = new BookStoreServiceClient();
        bool b_genre , b_author, b_title;
        public Client()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string s_genre = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string s_author = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            
            if (b_genre&& b_author)
            {
                textBox1.Clear();

                var b = proxy.SelectBooksByParameters(s_genre, s_author).ToList();
                
                foreach (var item in b)
                {
                    textBox1.Text += item.Title + Environment.NewLine;
                }
            }

            if (b_genre&& !b_author)
            {
               try
                  {
                    textBox1.Clear();
               
                    var b = proxy.SelectBooksByParameters(s_genre, "");
                    foreach (var item in b)
                    {
                        textBox1.Text += item.Title + Environment.NewLine;

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            if (!b_genre && b_author)
            {
                try
                {
                    textBox1.Clear();


                    var b = proxy.SelectBooksByParameters("", s_author);
                    foreach (var item in b)
                    {
                        textBox1.Text += item.Title+ Environment.NewLine;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            DisplayGenres();
            DisplayAuthors();
            DisplayBooks();
        }

        private void DisplayGenres()
        {
            var gnt = proxy.GetGenres().ToList();
            foreach (var g in gnt)
            {
                comboBox1.Items.Add(g.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void DisplayBooks()
        {
            var books = proxy.GetBooks().ToList();
            // listView1.Items.AddRange(gnt);
            foreach (var g in books)
            {
                textBox1.Text += g.Title + "\n";
            }
            
        }

        private void DisplayAuthors()
        {
            var auth = proxy.GetAuthors().ToList();
            // listView1.Items.AddRange(gnt);
            foreach (var g in auth)
            {
                comboBox2.Items.Add(g.Name);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void GenresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = !comboBox1.Enabled;
            b_genre = !b_genre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }

        private void AuthorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = !comboBox2.Enabled;
            b_author = !b_author;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
            b_title = !b_title;
        }
    }
}
