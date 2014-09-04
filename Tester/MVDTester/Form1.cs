using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BlackBox.Predefined;


namespace MVDTester
{
    public partial class Form1 : Form
    {
        private string Filename;

        public Form1()
        {
            string sampleLoc
                = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            InitializeComponent();
            Filename = sampleLoc + @"\singleWall23.ifc";

        }

        private void Generate_Click(object sender, EventArgs e)
        {

            var filename = Path.Combine(Directory.GetCurrentDirectory(), Filename );

            if (!SemEm11Tester.WriteTest(filename)) return;

            using (var reader = new StreamReader(filename))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Assembly.GetExecutingAssembly();
            var b = AppDomain.CurrentDomain.BaseDirectory;

            // AppDomain.CurrentDomain.BaseDirectory
            // Directory.GetCurrentDirectory() // not guaranteed to work on Mobile application
            // Environment.CurrentDirectory // this calls Directory.GetCurrentDirectory()
            // this.GetType().Assembly.Location // Assembly.location
            // Application.StartupPath // for windows forms apps
            // Application.ExecutablePath // same as Application.StartupPath



            //string schemaname = Environment.CurrentDirectory + "\\IFC2X3_TC1.exp";
            //string filename = Environment.CurrentDirectory + "\\project2.ifc";
            var filename = Path.Combine(Directory.GetCurrentDirectory(), Filename);
            //SemEm11Tester.ReadTest(filename);
        }

        private void p2Reader_Click(object sender, EventArgs e)
        {
            //string schemaname = Directory.GetCurrentDirectory() + "\\IFC2X3_TC1.exp";
            //string filename = Path.Combine(Directory.GetCurrentDirectory(), "project2.ifc");
            var filename = Path.Combine(Directory.GetCurrentDirectory(), Filename);
            //SemEm11Tester.Phase2Reader(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string filename = System.IO.Directory.GetCurrentDirectory() + "\\RetrievedSEM.txt";
            //SemInstanceDB.Read(filename);
            // Q= should I access InstanceDB to write sems?
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            System.Console.WriteLine(info);

            // Write on form
            //using (var reader = new StreamReader(Sems))
            //{
            //    richTextBox1.Text = reader.ReadToEnd();
            //}


            // reflection example:
            //System.Console.WriteLine("Author information for {0}", t);
            //System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // reflection 

            //foreach (System.Attribute attr in attrs)
            //{
            //    if (attr is Author)
            //    {
            //        Author a = (Author)attr;
            //        System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
            //    }
            //}
            /* Output:
                Author information for FirstClass
                H. Ackerman, version 1.00
                Author information for SecondClass
                Author information for ThirdClass
                M. Knott, version 2.00
                H. Ackerman, version 1.00
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var filename = Path.Combine(Directory.GetCurrentDirectory(), Filename);

            if (!SemEm11Tester.Phase2Writer(filename)) return;

            using (var reader = new StreamReader(filename))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var filename = Path.Combine(Directory.GetCurrentDirectory(), Filename);

            if (!SemEm11Tester.Tester4Writer(filename)) return;

            using (var reader = new StreamReader(filename))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }
        }
    }
}
