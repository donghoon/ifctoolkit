/*
 * 
 *  < IFC - ISO 10303 (STEP) Part 21 instance file reader >
 *	Copyright (C) <2012>  <Donghoon Yang>
 *
 * 	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 * 
 */



using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Globalization;

namespace InstanceModel
{
    public class P21Writer
    {
        /// <summary>
        /// Constance list
        /// </summary>
        public static string DICTIONARYstr = @"DICTIONARY;";
        public static string ENDSECstr = @"ENDSEC;";
        public static string ISOstr = @"ISO-10303-21;";
        public static string HEADERstr = @"HEADER;";
        //const string RETURNstr 
        public static string DATAstr = @"DATA;";
        public static string ENDISOstr = @"END-ISO-10303-21;";

        /// <summary>
        /// Write out regular p21 file
        /// </summary>
        /// <param name="DataSet"></param>
        /// <param name="FileName"></param>
        public static void WriteP21File(InstanceDB DataSet, string FileName, bool IsDictionaryType)
        {
            using (StreamWriter aFile = new StreamWriter(FileName))
            {
                if (IsDictionaryType)
                {
                    aFile.WriteLine(DICTIONARYstr);
                    for (int i = 0; i < DataSet.KeywordDic.Count; i++)
                    {
                        aFile.WriteLine("@{0}={1}", i, DataSet.KeywordDic[i]);
                    }
                    aFile.WriteLine(ENDSECstr);
                }

                aFile.WriteLine(ISOstr);
                aFile.WriteLine(HEADERstr);

                for (int i = 0; i < DataSet.HeaderList.Count; i++)
                {
                    WriteSimpleRecord(DataSet.HeaderList[i], aFile, DataSet, false);
                    aFile.Write(";\n");
                }

                aFile.WriteLine(ENDSECstr);


                //for (int i = 0; i < DataSet.aDataSectionList.Count; i++)
                //{
                aFile.WriteLine(DATAstr);
                //DataSection aDataSection = DataSet.aDataSectionList[i];
                //for (int j = 0; j < aDataSection.DataList.Count; j++)
                //{
                //    WriteInstance(aDataSection.DataList, aFile, DataSet);
                //}
                foreach (KeyValuePair<uint, Instance> kvp in DataSet.DataList)
                {
                    WriteInstance(kvp.Value, aFile, DataSet, IsDictionaryType);
                }
                aFile.WriteLine(ENDSECstr);
                //}
                aFile.WriteLine(ENDISOstr);
                //aFile.Close();
            }

        }

        public static void WriteSerializedInstances(InstanceDB DataSet)
        {
            Stream str = File.Create(@"c:\cpdsample\aSerialized.bin");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
            bf.Serialize(str, DataSet);
            str.Close();
        }

        public static void WriteCompressedSerializedInstances(InstanceDB DataSet)
        {
            Stream str = File.Create(@"c:\cpdsample\CompressedSerialized.bgz");
            GZipStream compressor = new GZipStream(str, CompressionMode.Compress);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
            bf.Serialize(compressor, DataSet);
            compressor.Close();
            str.Close();
        }

        public static void CompressWithPackage()
        {
            Uri partUriDocument = PackUriHelper.CreatePartUri(
                new Uri(@"c:\cpd\a.bgz", UriKind.Relative));

            using (Package package = Package.Open(@"c:\cpd\a.bkg", FileMode.Create))
            {
                PackagePart packagePartDocument = package.CreatePart(partUriDocument, System.Net.Mime.MediaTypeNames.Text.Plain, CompressionOption.Maximum);
                using (FileStream fileStream = new FileStream(@"c:\cpd\a.bgz", FileMode.Open, FileAccess.Read))
                {
                    CopyStream(fileStream, packagePartDocument.GetStream());
                }// end:using(fileStream) - Close and dispose fileStream.

                // Add a Package Relationship to the Document Part
                package.CreateRelationship(packagePartDocument.Uri,
                                           TargetMode.Internal, "Data File");

            }
        }

        public static InstanceDB ReadCompressedSerialization()
        {
            Stream str = File.OpenRead(@"c:\cpd\a.bgz");
            GZipStream decompressor = new GZipStream(str, CompressionMode.Decompress);
            BinaryFormatter bf = new BinaryFormatter();
            //P21Data aData = (P21Data)bf.Deserialize(str);
            InstanceDB aData = (InstanceDB)bf.Deserialize(decompressor);
            decompressor.Close();
            str.Close();
            return aData;
        }

        public static void Compress(FileInfo fi)
        {
            // Get the stream of the source file.
            using (FileStream inFile = fi.OpenRead())
            {
                // Prevent compressing hidden and 
                // already compressed files.
                if ((File.GetAttributes(fi.FullName)
                    & FileAttributes.Hidden)
                    != FileAttributes.Hidden & fi.Extension != ".gz")
                {
                    // Create the compressed file.
                    using (FileStream outFile =
                                File.Create(fi.FullName + ".gz"))
                    {
                        using (GZipStream Compress =
                            new GZipStream(outFile,
                            CompressionMode.Compress))
                        {
                            // Copy the source file into 
                            // the compression stream.
                            inFile.CopyTo(Compress);

                            Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                                fi.Name, fi.Length.ToString(), outFile.Length.ToString());
                        }
                    }
                }
            }
        }

        public static void ZipFile()
        {
            Uri partUriDocument = PackUriHelper.CreatePartUri(
                new Uri(@"c:\cpd\a.cpd", UriKind.Relative));

            using (Package package = Package.Open(@"c:\cpd\a.cpz", FileMode.Create))
            {
                PackagePart packagePartDocument = package.CreatePart(partUriDocument, System.Net.Mime.MediaTypeNames.Text.Plain, CompressionOption.Maximum);
                using (FileStream fileStream = new FileStream(@"c:\cpd\a.cpd", FileMode.Open, FileAccess.Read))
                {
                    CopyStream(fileStream, packagePartDocument.GetStream());
                }// end:using(fileStream) - Close and dispose fileStream.

                //// Add a Package Relationship to the Document Part
                //package.CreateRelationship(packagePartDocument.Uri,
                //                           TargetMode.Internal, "Data File");

            }
        }

        //  --------------------------- CopyStream ---------------------------
        /// <summary>
        ///   Copies data from a source stream to a target stream.</summary>
        /// <param name="source">
        ///   The source stream to copy from.</param>
        /// <param name="target">
        ///   The destination stream to copy to.</param>
        private static void CopyStream(Stream source, Stream target)
        {
            const int bufSize = 0x1000;
            byte[] buf = new byte[bufSize];
            int bytesRead = 0;
            while ((bytesRead = source.Read(buf, 0, bufSize)) > 0)
                target.Write(buf, 0, bytesRead);
        }// end:CopyStream()

        public static void WriteToByte(InstanceDB DataSet)
        {
            Stream bstr = File.Create(@"c:\cpd\a.cpd");
            BinaryWriter binWriter = new BinaryWriter(bstr, Encoding.ASCII);

            //for (int i = 0; i < DataSet.aDataSectionList.Count; i++)
            //{
            //DataSection aDataSection = DataSet.aDataSectionList[i];
            //for (int j = 0; j < aDataSection.DataList.Count; j++)
            //{
            //    WriteInstance(aDataSection.DataList.GetByIndex(j), binWriter, DataSet);
            //}
            foreach (KeyValuePair<uint, Instance> kvp in DataSet.DataList)
            {
                WriteInstance(kvp.Value, binWriter, DataSet);
            }
            //}
            //FileStream outfile = File.Create(@"c:\a.cpz");

            //GZipStream compress = new GZipStream(bstr, CompressionMode.Compress);
            //bstr.CopyTo(compress);
            //compress.Close();
            //outfile.Close();

            bstr.Close();
            //            ZipFile();
            //Compress(new FileInfo(@"c:\a.cpd"));

        }

        public static void WriteInstance(Instance aInstance, BinaryWriter aBinaryWriter, InstanceDB DataSet)
        {
            aBinaryWriter.Write('#');
            aBinaryWriter.Write(aInstance.EntityInstanceName.ToString());
            aBinaryWriter.Write('=');

            if (aInstance is InstanceSimple)
            {
                WriteSimpleRecord(((InstanceSimple)aInstance).Record, aBinaryWriter, DataSet);

            }
            else if (aInstance is InstanceComplex)
            {
            }
            else
            {
            }
            aBinaryWriter.Write(BitConverter.GetBytes(';'));
        }

        public static void WriteSimpleRecord(SimpleRecord aRecord, BinaryWriter aBinaryWriter, InstanceDB DataSet)
        {
            //aBinaryWriter.Write(DataSet.GetKeyword((int)aRecord.IntKeyword));
            aBinaryWriter.Write(aRecord.Keyword);
            //aBinaryWriter.Write(aRecord.GetKeyword(DataSet));
            //byte[] aTemp = BitConverter.GetBytes('(');
            aBinaryWriter.Write('(');
            for (int i = 0; i < aRecord.ParameterList.Count; i++)
            {
                if (i > 0)
                {

                    aBinaryWriter.Write(',');
                }
                WriteParameter(aRecord.ParameterList[i], aBinaryWriter, DataSet);
            }
            aBinaryWriter.Write(')');
        }

        public static void WriteParameter(Parameter aParameter, BinaryWriter aBinaryWriter, InstanceDB DataSet)
        {
            //if (aParameter.ParameterTypeValue == ParameterType.ENTITY_INSTANCE_NAME)
            if (aParameter is ParamEntity)
            {
                aBinaryWriter.Write('#');
                aBinaryWriter.Write(((ParamEntity)aParameter).EntityInstance.EntityInstanceName.ToString());
            }
            //else if (aParameter.ParameterTypeValue == ParameterType.INTEGER)
            else if (aParameter is ParamInteger)
            {
                aBinaryWriter.Write(BitConverter.GetBytes(((ParamInteger)aParameter).IntegerValue));
            }
            //else if (aParameter.ParameterTypeValue == ParameterType.ENUMERATION)
            else if (aParameter is ParamEnum)
            {
                aBinaryWriter.Write('.');
                aBinaryWriter.Write(((ParamEnum)aParameter).EnumerationValueString);
                aBinaryWriter.Write('.');
            }
            else if (aParameter is ParamNullValue)
            {
                aBinaryWriter.Write('$');
            }
            else if (aParameter is ParamOmitted)
            {
                aBinaryWriter.Write('*');
            }
            else if (aParameter is ParamString)
            {
                aBinaryWriter.Write('\'');
                aBinaryWriter.Write(((ParamString)aParameter).StringValue);
                aBinaryWriter.Write('\'');
            }
            else if (aParameter is ParamReal)
            {
                aBinaryWriter.Write(BitConverter.GetBytes(((ParamReal)aParameter).RealValue));
            }
            else if (aParameter is ParamList)
            {
                aBinaryWriter.Write('(');
                for (int i = 0; i < ((ParamList)aParameter).ParameterList.Count; i++)
                {
                    if (i > 0)
                    {
                        aBinaryWriter.Write(',');
                    }
                    WriteParameter(((ParamList)aParameter).ParameterList[i], aBinaryWriter, DataSet);
                }
                aBinaryWriter.Write(')');
            }
            else if (aParameter is ParamSelect)
            {
                //WriteSimpleRecord(((ParamSelect)aParameter).TypedParameterValue, aBinaryWriter, DataSet);
                aBinaryWriter.Write(
                    string.Format("{0}({1})", 
                    ((ParamSelect)aParameter).SelectName, 
                    ((ParamSelect)aParameter).SelectValue));
            }

        }

        public static void WriteInstance(Instance aInstance, StreamWriter strWriter, InstanceDB DataSet, bool IsDictionaryType)
        {
            strWriter.Write('#');
            strWriter.Write(aInstance.EntityInstanceName.ToString());
            strWriter.Write('=');

            if (aInstance is InstanceSimple)
            {
                WriteSimpleRecord(((InstanceSimple)aInstance).Record, strWriter, DataSet, IsDictionaryType);

            }
            else if (aInstance is InstanceComplex)
            {
            }
            else
            {
            }
            strWriter.WriteLine(";");
        }

        public static void WriteSimpleRecord(SimpleRecord aRecord, StreamWriter strWriter, InstanceDB DataSet, bool IsDictionaryType)
        {
            if (IsDictionaryType)
            { strWriter.Write("@{0}", aRecord.IntKeyword.ToString()); }
            else
            { 
                //strWriter.Write(DataSet.GetKeyword((int)aRecord.IntKeyword));
                strWriter.Write(aRecord.Keyword); 
            }
            //byte[] aTemp = BitConverter.GetBytes('(');

            strWriter.Write('(');
            for (int i = 0; i < aRecord.ParameterList.Count; i++)
            {
                if (i > 0)
                { strWriter.Write(','); }
                WriteParameter(aRecord.ParameterList[i], strWriter, DataSet, IsDictionaryType);
            }
            strWriter.Write(')');
        }



        public static void WriteParameter(Parameter aParameter, StreamWriter strWriter, InstanceDB DataSet, bool IsDictionaryType)
        {
            if (aParameter is ParamEntity)
            {
                strWriter.Write('#');
                strWriter.Write(((ParamEntity)aParameter).EntityInstance.EntityInstanceName.ToString());
            }
            else if (aParameter is ParamInteger)
            {
                strWriter.Write(((ParamInteger)aParameter).IntegerValue.ToString());
            }
            else if (aParameter is ParamEnum)
            {
                //strWriter.Write('.');
                //strWriter.Write(aParameter.StringValue);
                //((EnumerationParameter)aParameter).GetStringValue(DataSet)
                if (IsDictionaryType)
                { strWriter.Write("@{0}", ((ParamEnum)aParameter).EnumerationValueInt); }
                else
                { strWriter.Write("@{0}", ((ParamEnum)aParameter).EnumerationValueString); }
                //strWriter.Write('.');
            }
            else if (aParameter is ParamNullValue)
            {
                strWriter.Write('$');
            }
            else if (aParameter is ParamOmitted)
            {
                strWriter.Write('*');
            }
            else if (aParameter is ParamString)
            {
                strWriter.Write('\'');
                strWriter.Write(((ParamString)aParameter).StringValue);
                strWriter.Write('\'');
            }
            else if (aParameter is ParamReal)
            {
                int front = (int)((ParamReal)aParameter).RealValue;
                double remain = ((ParamReal)aParameter).RealValue - front;
                if (remain == 0.0)
                {
                    strWriter.Write("{0}.", ((ParamReal)aParameter).RealValue.ToString());
                }
                else
                    strWriter.Write("{0}", ((ParamReal)aParameter).RealValue.ToString("G", CultureInfo.InvariantCulture));
            }
            else if (aParameter is ParamList)
            {
                strWriter.Write('(');
                for (int i = 0; i < ((ParamList)aParameter).ParameterList.Count; i++)
                {
                    if (i > 0)
                    {
                        strWriter.Write(',');
                    }
                    WriteParameter(((ParamList)aParameter).ParameterList[i], strWriter, DataSet, IsDictionaryType);
                }
                strWriter.Write(')');
            }
            else if (aParameter is ParamSelect)
            {
                //WriteSimpleRecord(((ParamSelect)aParameter).TypedParameterValue, strWriter, DataSet, IsDictionaryType);
                strWriter.Write(
                        string.Format("{0}({1})",
                        ((ParamSelect)aParameter).SelectName,
                        ((ParamSelect)aParameter).SelectValue));
            }
            else if (aParameter is ParamBoolean)
            {
                strWriter.Write("{0}.", ((ParamBoolean)aParameter).BoolValue.ToString());
            }
            else
                throw new NotImplementedException();

        }

        public static byte getByte(char aChar)
        {
            byte[] orgChar = BitConverter.GetBytes(aChar);
            return orgChar[0];
        }

        public static byte[] getByte(long aInteger)
        {
            byte[] orgChar = BitConverter.GetBytes(aInteger);
            return orgChar;
        }

    }


	public class Test
	{
		public static void TestWriter()
		{
			var instanceDB = new InstanceDB();
			var simpleRecord = new SimpleRecord("IFCORGANIZATION", instanceDB);
			simpleRecord.ParameterList.Add(new ParamNullValue());
			simpleRecord.ParameterList.Add(new ParamString("Georgia Tech"));
			simpleRecord.ParameterList.Add(new ParamNullValue());
			simpleRecord.ParameterList.Add(new ParamNullValue());
			simpleRecord.ParameterList.Add(new ParamNullValue());
			var instanceSimple = new InstanceSimple(10);
			instanceSimple.Record = simpleRecord;
			instanceDB.DataList.Add(instanceSimple.EntityInstanceName, instanceSimple);
		}
	}
}
