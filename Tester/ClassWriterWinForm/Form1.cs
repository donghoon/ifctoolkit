using System;
using System.IO;
using System.Windows.Forms;
using SchemaModel;


namespace ClassWriterWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string loc = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            //loc = loc.Substring(0, loc.IndexOf("Tester"));
            textBox2.Text = loc + @"Ifc\IFC2X3\IFC2X3_TC1.cs";
            //textBox1.Text = loc + @"IFC4.exp";
            //textBox3.Text = loc + @"IFC4.exp.log";
            //textBox2.Text = loc + @"IFC4\IFC4.cs";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var aParser = new SParser();
            var sData = SParser.ReadSchema(RegisteredSchema.IFC2X3);
            //var sData = SParser.ReadSchema(RegisteredSchema.IFC4);
            //aParser.ReadSchemaFile(textBox1.Text, textBox3.Text);

            using (var fs = new StreamWriter(textBox2.Text))
            {

                sData.ToCSharpClass(fs);
                //aParser.SchemaSet.ToCSharpClass(fs);
                //var code =  aParser.SchemaSet.ToCSharpClass();
                //code.ToString();
            }
            Close();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
