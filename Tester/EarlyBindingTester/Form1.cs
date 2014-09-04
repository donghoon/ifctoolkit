using System;
using System.IO;
using System.Windows.Forms;
using EbInstanceModel;

namespace EarlyBindingTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string sampleLoc
                = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;

            InitializeComponent();
            instanceFilename.Text = sampleLoc + @"\Tester\singleWall23.ifc";
        }

        /// <summary>
        /// not working anymore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string ins = instanceFilename.Text;
            

            FileInfo fileInfo = new FileInfo(ins);
            if (!fileInfo.Exists) return;

            EarlyBindingInstanceModel.Read(ins);

            string outFile = fileInfo.DirectoryName + "\\" + "out.ifc";
            fileInfo = new FileInfo(outFile);
            if (fileInfo.Exists) fileInfo.Delete();

            EarlyBindingInstanceModel.Write(outFile);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"c:\\";
            openFileDialog1.Filter = @"ISO 10303 File (*.stp)|*.stp|IFC File (*.ifc)|*.ifc|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                instanceFilename.Text = openFileDialog1.FileName;
            }
        }


    }
}