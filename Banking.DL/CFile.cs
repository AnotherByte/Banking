using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Banking.DL
{
    public class CFile
    {
        #region properties

        private string msFileName;

        #endregion

        #region methods

        public CFile()
        {
            throw new Exception("Implementation not supported.");
        }

        public CFile(string vsFileName)
        {
            msFileName = vsFileName;
        }


        public bool IfExists()
        {
            return File.Exists(msFileName);
        }

        public string Read()
        {
            try
            {
                StreamReader oSR = File.OpenText(msFileName);
                string sInput = oSR.ReadToEnd();

                oSR.Close();
                oSR.Dispose();
                oSR = null;

                return sInput;
            }
            catch (Exception ex)
            {
                //return string.Empty;
                throw ex;
            }
        }

        public bool Write(string sOuput)
        {
            try
            {
                StreamWriter oSW = File.AppendText(msFileName);
                oSW.WriteLine(sOuput);

                oSW.Close();
                oSW.Dispose();
                oSW = null;

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool Delete()
        {
            try
            {
                if (File.Exists(msFileName))
                {
                    File.Delete(msFileName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }


        public bool Serialize(Type oObjectType, object Objects)
        {
            try
            {
                TextWriter oTextWriter = new StreamWriter(msFileName);
                XmlSerializer oSerializer = new XmlSerializer(oObjectType);
                oSerializer.Serialize(oTextWriter, Objects);

                oTextWriter.Close();
                oTextWriter.Dispose();
                oTextWriter = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object DeSerialize(Type oObjectType)
        {
            try
            {
                XmlSerializer oSerializer = new XmlSerializer(oObjectType);
                TextReader oTextReader = new StreamReader(msFileName);
                object obj = oSerializer.Deserialize(oTextReader);

                oTextReader.Close();
                oTextReader.Dispose();
                oTextReader = null;

                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
