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

namespace PacksizeTest
{
    public partial class Main : Form
    {
        List<string> courses = new List<string> { };
        List<string> orden = new List<string> { };
        public Main()
        {
            InitializeComponent();
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            if (TXTcouse.Text == TXTprerequisite.Text)
            {
                MessageBox.Show("The prerequisite can't be the same than course that you are trying to add.", "Important Message");
                return;
            }
            if (TXTcouse.Text == "")
            {
                MessageBox.Show("Please add the course name.", "Important Message");
                return;
            }
            else
            {
                if (TXTprerequisite.Text == "")
                {
                    DialogResult Result = MessageBox.Show("Do you want to add the course without a prerequisite?", "Important Question", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        TXTprerequisite.Text = "None";
                        courses.Add(TXTcouse.Text + ", " + TXTprerequisite.Text);
                    }
                    else
                    { return; }
                }
                else
                { courses.Add(TXTcouse.Text + ", " + TXTprerequisite.Text); }
            }
        }

        private void Ordena()
        {
            int j = 0;
            int i = 0;
            string valor;
            string cambio;
            for (i = 0; i < courses.Count; i++)
            {
                j = 0;
                int size;
                string str;
                string curso = "";
                size = courses[i].Length;
                str = courses[i];
                Char charRange = ',';
                int startIndex = str.IndexOf(charRange);
                int endIndex = str.LastIndexOf(charRange);
                string sub = str.Substring(0, endIndex);
                curso = sub;
                valor = courses[i];
                for (j=0; j < courses.Count; j++)
                {
                    int size1;
                    string str1;
                    string pre = "";
                    size1 = courses[j].Length - 1;
                    str1 = courses[j];
                    Char charRange1 = ',';
                    int startIndex1 = str1.IndexOf(charRange1);
                    int endIndex1 = str1.LastIndexOf(charRange1);
                    string sub1 = str1.Substring(startIndex1+2);
                    pre = sub1;
                    if (curso == pre)
                    {
                            cambio = courses[i + 1];
                            courses[i+1] = courses[j];
                            courses[j] = cambio;
                    }
                }
            }
                
        }

        private void BTNshow_Click(object sender, EventArgs e)
        {
            Ordena();
            int size;
            string str;
            string cursos = "";
            orden = courses;
            for (int i = 0; i < orden.Count; i++)
            {
                size = orden[i].Length;
                str = orden[i];
                Char charRange = ',';
                int startIndex = str.IndexOf(charRange);
                int endIndex = str.LastIndexOf(charRange);
                string sub = str.Substring(0, endIndex);
                cursos = cursos + ", " + sub;
            }
            MessageBox.Show(cursos, "Important Message");
        }
    }
}
