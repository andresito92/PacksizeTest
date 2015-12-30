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
        //I use Lists to replace the Arrays because you can work with lists in a dynamic way. is better and it works similar than the Array.
        List<string> courses = new List<string> { };
        List<string> orden = new List<string> { };
        public Main()
        {
            InitializeComponent();
        }

        //This event check if the course and the prerequisite is the same. It check if the Textbox are empty, and ask if you don't need a prerequisite for the course.
        //Then invoque the AddCourse Function in order to add a new course.
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
                        AddCourse();
                    }
                    else
                    { return; }
                }
                else
                { AddCourse(); }
            }
        } 
//This Function add a new course with the respective prerequisite in the list. It check if the course already exist and avoid to create circular dependencies.
//Also it will add the new courses without prerequisite at the begining of the list.
        private void AddCourse()
        {
            if (courses.Count == 0) { courses.Add(TXTcouse.Text + ", " + TXTprerequisite.Text); }
            else
            {
                int i = 0;
                int j = 0;
                int z = 0;
                for (i = 0; i < courses.Count; i++)
                {
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
                    if (TXTcouse.Text == curso)
                    {
                        MessageBox.Show("This course already exist.", "Important Message");
                        return;
                    }
                }
                        for (j = 0; j < courses.Count; j++)
                        {
                            int size1;
                            string str1;
                            string pre = "";
                            string compara = "";
                            size1 = courses[j].Length - 1;
                            str1 = courses[j];
                            Char charRange1 = ',';
                            int startIndex1 = str1.IndexOf(charRange1);
                            int endIndex1 = str1.LastIndexOf(charRange1);
                            string sub1 = str1.Substring(startIndex1 + 2);
                            pre = sub1;
                            sub1 = str1.Substring(0, endIndex1);
                            compara = sub1;
                            if ((TXTcouse.Text == pre) & (TXTprerequisite.Text == compara))
                            {
                                MessageBox.Show("You cant add this course because it will create an circular dependencie. ", "Important Message");
                                return;
                            }
                }
                if ((TXTprerequisite.Text == "None")&(courses.Count != 1))
                {
                    for (z = 0; z < courses.Count; z++)
                    {
                        int size1;
                        string cambio;
                        string str1;
                        string pre = "";
                        size1 = courses[z].Length - 1;
                        str1 = courses[z];
                        Char charRange1 = ',';
                        int startIndex1 = str1.IndexOf(charRange1);
                        int endIndex1 = str1.LastIndexOf(charRange1);
                        string sub1 = str1.Substring(startIndex1 + 2);
                        pre = sub1;
                        if (pre != "None")
                        {
                            cambio = courses[z];
                            courses[z] = TXTcouse.Text + ", " + TXTprerequisite.Text;
                            courses.Add(cambio);
                            return;
                        }
                    }
                }
                else
                { courses.Add(TXTcouse.Text + ", " + TXTprerequisite.Text); }
            }
        }
        //This Function order the courses in order acording to the prerequisite.
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
        //This Function invoque the Ordena Funcion and then with a message box show the list of courses in order.
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
                cursos = cursos + sub + ", ";
            }
            MessageBox.Show(cursos, "Important Message");
        }
    }
}
