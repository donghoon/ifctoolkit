using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;

namespace BlackBox
{
	/// <summary>
	/// Tree node. copied from stackoverflow
	/// </summary>

	public partial class MvdDefinition : Definition, ICSharpClass{


        public MvdDefinition() { }

        List<BbDefinition> _semList = new List<BbDefinition>();

		public List<BbDefinition> SemList { get{return _semList;}}

        //public MvdDefinition(string name, string description)
        //    : base(name, description)
        //{
        //    //_semList = new List<BbDefinition>();
        //}

        public MvdDefinition(string name, string description)
            :base(name, description)
        {
            //// 
            //this.Name = name;
            //this.Description = description;
            //_semList = new List<BbDefinition>();
        }

		public static MvdDefinition Create (string name, string description)
		{
			var def = new MvdDefinition(name, description);
			return def;
		}


		public static MvdDefinition Create (string name)
		{
			return Create(name, null);
		}

			
		public void CreateProject ()
		{
			XmlDocument xmldoc;
			XmlElement projectElement;
			
			xmldoc = new XmlDocument();

			XmlNode xmlnode=xmldoc.CreateNode(XmlNodeType.XmlDeclaration,"utf-8","");
			xmldoc.AppendChild(xmlnode);

			projectElement=xmldoc.CreateElement("Project");
			projectElement.SetAttribute(@"ToolsVersion", @"4.0");
			projectElement.SetAttribute(@"DefaultTargets", @"Build");
			projectElement.SetAttribute(@"xmlns", @"http://schemas.microsoft.com/developer/msbuild/2003");

			xmldoc.AppendChild(projectElement);

			XmlElement xelement;
			XmlElement dsym;
			XmlElement hintPath;
				
			#region property group	
			xelement = xmldoc.CreateElement("PropertyGroup");
			projectElement.AppendChild(xelement);

			dsym =  xmldoc.CreateElement(@"Configuration");
			dsym.SetAttribute(@"Condition", @" '$(Configuration)' == '' ");
			dsym.InnerText = @"Debug";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Platform");
			dsym.SetAttribute(@"Condition", @" '$(Platform)' == '' ");
			dsym.InnerText = @"AnyCPU";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"ProductVersion");
			dsym.InnerText = @"8.0.30703";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"SchemaVersion");
			dsym.InnerText = @"2.0";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"ProjectGuid");
			dsym.InnerText = Guid.ToString("B");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"OutputType");
			dsym.InnerText = @"Library";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"AppDesignerFolder");
			dsym.InnerText = @"Properties";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"RootNamespace");
			dsym.InnerText = Name;
			xelement.AppendChild(dsym);
				
			dsym =  xmldoc.CreateElement(@"AssemblyName");
			dsym.InnerText = Name;
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"FileAlignment");
			dsym.InnerText = @"512";
			xelement.AppendChild(dsym);

			xelement = xmldoc.CreateElement("PropertyGroup");
			projectElement.AppendChild(xelement);
			xelement.SetAttribute(@"Condition", @" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ");

			dsym =  xmldoc.CreateElement(@"DebugSymbols");
			dsym.InnerText = @"True";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"DebugType");
			dsym.InnerText = @"full";
			xelement.AppendChild(dsym);
				
			dsym =  xmldoc.CreateElement(@"Optimize");
			dsym.InnerText = @"False";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"OutputPath");
			dsym.InnerText = @"bin\Debug\";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"DefineConstants");
			dsym.InnerText = @"DEBUG;TRACE";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"ErrorReport");
			dsym.InnerText = @"prompt";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"WarningLevel");
			dsym.InnerText = @"4";
			xelement.AppendChild(dsym);

			xelement = xmldoc.CreateElement("PropertyGroup");
			projectElement.AppendChild(xelement);
			xelement.SetAttribute(@"Condition", @" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ");
				
			dsym =  xmldoc.CreateElement(@"DebugType");
			dsym.InnerText = @"pdbonly";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Optimize");
			dsym.InnerText = @"True";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"OutputPath");
			dsym.InnerText = @"bin\Release\";
			xelement.AppendChild(dsym);
				
			dsym =  xmldoc.CreateElement(@"DefineConstants");
			dsym.InnerText = @"TRACE";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"ErrorReport");
			dsym.InnerText = @"prompt";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"WarningLevel");
			dsym.InnerText = @"4";
			xelement.AppendChild(dsym);
			
			#endregion

			#region reference

			xelement = xmldoc.CreateElement("ItemGroup");
			projectElement.AppendChild(xelement);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"InstanceModel");
			hintPath = xmldoc.CreateElement(@"HintPath");
            hintPath.InnerText = @"..\..\..\..\InstanceModel\bin\Release\InstanceModel.dll";
			dsym.AppendChild(hintPath);
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"EbInstanceModel");
			hintPath = xmldoc.CreateElement(@"HintPath");
            hintPath.InnerText = @"..\..\..\..\EbInstanceModel\bin\Release\EbInstanceModel.dll";
			dsym.AppendChild(hintPath);
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"SchemaModel");
			hintPath = xmldoc.CreateElement(@"HintPath");
			hintPath.InnerText = @"SchemaModel.dll";
			dsym.AppendChild(hintPath);
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"SemApi");
			hintPath = xmldoc.CreateElement(@"HintPath");
            hintPath.InnerText = @"..\..\..\..\SemApi\bin\Release\SemApi.dll";
			dsym.AppendChild(hintPath);
			xelement.AppendChild(dsym);

            dsym = xmldoc.CreateElement(@"Reference");
            dsym.SetAttribute(@"Include", @"SemGeneric");
            hintPath = xmldoc.CreateElement(@"HintPath");
            hintPath.InnerText = @"..\..\..\..\Sem\Generic\bin\Debug\Sem.Generic.dll";
            dsym.AppendChild(hintPath);
            xelement.AppendChild(dsym);

            dsym = xmldoc.CreateElement(@"Reference");
            dsym.SetAttribute(@"Include", @"IFC2X3");
            hintPath = xmldoc.CreateElement(@"HintPath");
            hintPath.InnerText = @"..\..\..\..\IFC2X3\bin\Debug\IFC2X3.dll";
            dsym.AppendChild(hintPath);
            xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System.Core");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System.Xml.Linq");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System.Data.DataSetExtensions");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"Microsoft.CSharp");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System.Data");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"Reference");
			dsym.SetAttribute(@"Include", @"System.Xml");
			xelement.AppendChild(dsym);

			#endregion

			#region semFiles

			xelement = xmldoc.CreateElement("ItemGroup");
			projectElement.AppendChild(xelement);

			foreach(var sem in _semList)
			{
				dsym =  xmldoc.CreateElement(@"Compile");
				dsym.SetAttribute(@"Include", sem.FileName);
				xelement.AppendChild(dsym);
			}

			#endregion

			dsym =  xmldoc.CreateElement(@"Compile");
			dsym.SetAttribute(@"Include", @"Properties\AssemblyInfo.cs");
			xelement.AppendChild(dsym);

			xelement = xmldoc.CreateElement("Import");
			projectElement.AppendChild(xelement);
			xelement.SetAttribute(@"Project", @"$(MSBuildToolsPath)\Microsoft.CSharp.targets");

			try
			{
                //xmldoc.Save( @"c:\Test.csproj"); //I've chosen the c:\ for the resulting file pavel.xml
				using (var writer = new XmlTextWriter( Name + ".csproj", Encoding.UTF8)) {
					writer.Formatting = Formatting.Indented;
					xmldoc.WriteTo (writer);
					writer.Flush ();
				}
				WriteAssemblyInfo();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}			
		}

		public string CompileDll (string compiler)
		{
           // Start the child process.
			System.Diagnostics.Process p = new  System.Diagnostics.Process();
			// Redirect the output stream of the child process.
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = compiler;
            p.StartInfo.CreateNoWindow = true;
			p.StartInfo.Arguments = Name + ".csproj";
            p.Start();
            
			// Do not wait for the child process to exit before
			// reading to the end of its redirected stream.
			// p.WaitForExit();
			// Read the output stream first and then wait.
			string output = p.StandardOutput.ReadToEnd();
			p.WaitForExit();
            //p.Kill();
			return output;
		}

		public void AddSem (BbDefinition bbDefinition)
		{
			_semList.Add(bbDefinition);
		}

        //#region ICSharpClass implementation		
        //public void ToCSharpClass (StreamWriter stream)
        //{
        //    throw new NotImplementedException ();
        //}
        //#endregion

		void WriteAssemblyInfo ()
		{
			string dir = @"Properties";
			if(!	Directory.Exists(dir))
				Directory.CreateDirectory(dir);
			string filepath = dir + System.IO.Path.DirectorySeparatorChar + @"AssemblyInfo.cs";
			using(StreamWriter writer = new StreamWriter(filepath, false))
			{
				writer.WriteLine(@"using System.Reflection;");
				writer.WriteLine(@"using System.Runtime.CompilerServices;");
				writer.WriteLine(@"using System.Runtime.InteropServices;");

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
				writer.WriteLine("[assembly: AssemblyTitle(\"{0}\")]", Name);
				writer.WriteLine("[assembly: AssemblyDescription(\"\")]");
				writer.WriteLine("[assembly: AssemblyConfiguration(\"\")]");
				writer.WriteLine("[assembly: AssemblyCompany(\"GeorgiaTech\")]");
				writer.WriteLine("[assembly: AssemblyProduct(\"{0}\")]", Name);
				writer.WriteLine("[assembly: AssemblyCopyright(\"Copyright ©  {0}\")]", DateTime.Now.Year);
				writer.WriteLine("[assembly: AssemblyTrademark(\"GeorgiaTech\")]");
				writer.WriteLine("[assembly: AssemblyCulture(\"\")]");

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
				writer.WriteLine("[assembly: ComVisible(false)]");

// The following GUID is for the ID of the typelib if this project is exposed to COM
// [assembly: Guid("1fb202e5-e14d-46f8-89fa-19c1f191bfac")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
				writer.WriteLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
				writer.WriteLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
			}
		}

	}
	
}
