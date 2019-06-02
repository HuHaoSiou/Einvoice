using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using EInvLib;
namespace Libs.Services.EInvoice
{
    /// <summary>
    /// 用於產生MigXML檔
    /// </summary>
    class XMLMaker
    {
        /// <summary>
        /// 產生XML
        /// </summary>
        /// <typeparam name="T">XML class Type</typeparam>
        /// <param name="XMLFilename">檔案名稱</param>
        /// <param name="TargetPath">目標</param>
        /// <param name="XmlContainer">Mig class</param>
        /// <param name="Force">強制</param>
        public void MakeXML<T>(string XMLFilename, string TargetPath, T XmlContainer,int Force = 0)
        {
            string Path_Temp = Configs.PATH_XML_GENERATE_TEMP;

            string TempFile = Path_Temp + XMLFilename;
            string TargetFile = TargetPath + XMLFilename;
            XmlSerializer xs = new XmlSerializer(typeof(T));
            FileStream oStream = File.Create(TempFile);
            xs.Serialize(oStream, XmlContainer);
            oStream.Flush();
            oStream.Close();
            this.MoveFile(TempFile, TargetFile, Force);
        }
        /// <summary>
        /// 搬移檔案
        /// </summary>
        /// <param name="ori"></param>
        /// <param name="dist"></param>
        /// <param name="Force"></param>
        protected void MoveFile(string ori, string dist, int Force = 0)
        {
            try
            {
                if (Force > 0)
                {
                    File.Delete(dist);
                }
            }
            catch{}
            finally
            {
                File.Move(ori, dist);
            }
        }
    }
}
