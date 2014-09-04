using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;

namespace BlackBox
{

	public class MvdCompiler
	{
		List<string> _semClasses;
		string _semName;

		XmlDocument xmldoc;
		XmlElement projectElement;

		MvdCompiler (string semName)
		{

			_semName = semName; 
			_semClasses = new List<string> ();

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
			dsym.InnerText = Guid.NewGuid().ToString("B");
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"OutputType");
			dsym.InnerText = @"Library";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"AppDesignerFolder");
			dsym.InnerText = @"Properties";
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"RootNamespace");
			dsym.InnerText = _semName;
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"AssemblyName");
			dsym.InnerText = _semName;
			xelement.AppendChild(dsym);

			dsym =  xmldoc.CreateElement(@"FileAlignment");
			dsym.InnerText = @"512";
			xelement.AppendChild(dsym);

//			<PropertyGroup>
//				<Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
//					<Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
//					<ProductVersion>8.0.30703</ProductVersion>
//					<SchemaVersion>2.0</SchemaVersion>
//<ProjectGuid>{C0590489-A0E9-482A-9F2F-9E50E0ACA698}</ProjectGuid>
//				<OutputType>Library</OutputType>
//					<AppDesignerFolder>Properties</AppDesignerFolder>
//					<RootNamespace>IFC2X3</RootNamespace>
//					<AssemblyName>IFC2X3</AssemblyName>
//					<FileAlignment>512</FileAlignment>
//					</PropertyGroup>

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

		}

		public void Compile ()
		{
			StringBuilder sb = new StringBuilder ();

			_semClasses.Add("aaa.cs");
			_semClasses.Add("bbb.cs");
			_semClasses.Add("ccc.cs");
			_semClasses.Add("ddd.cs");
			_semClasses.Add("eee.cs");

			foreach (var fileInfo in _semClasses) {

			}

			try
			{
//				xmldoc.Save("aa.csproj"); //I've chosen the c:\ for the resulting file pavel.xml
				using (var writer = new XmlTextWriter("aa.csproj", Encoding.UTF8)) {
					writer.Formatting = Formatting.Indented;
					xmldoc.WriteTo (writer);
					writer.Flush ();
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}

		public static void Create(string semName)
		{
			var sc = new MvdCompiler(semName);
			sc.Compile();
		}

	}

}
