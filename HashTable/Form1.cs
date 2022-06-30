using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HashTable
{
    public partial class Form1 : Form
    {
        List<Abonent> abonents = new List<Abonent>();
        MyHashTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fs = new StreamReader(@"C:\Users\alexe\source\repos\HashTable\HashTable\People.txt");
            string line;
            string TakeFromLine(ref string line)
            {
                string value;
                value = line.Substring(0, line.IndexOf(';'));
                line = line.Remove(0, line.IndexOf(';') + 1);
                return value;
            }
            string name;
            string phoneNumber;
            string date;
            fs.ReadLine();
            while (!fs.EndOfStream)
            {
                line=fs.ReadLine();
                TakeFromLine(ref line);
                name = TakeFromLine(ref line);
                phoneNumber= TakeFromLine(ref line);
                date = line;
                abonents.Add(new Abonent(phoneNumber, name, date));
            }
            fs.Close();
            table = new MyHashTable(abonents);

            for (int i = 0; i < table.table.Count; i++)
            {
                richTextBox1.Text += i + "=>" + table.table[i].Count+"\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonent ab = table.Search(textBox1.Text);
            label3.Text = ab?.name;
            label5.Text = ab?.dateOfBirthday;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
