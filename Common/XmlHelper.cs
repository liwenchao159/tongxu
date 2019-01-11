using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace aspnetcoreapp.Common
{
    public class XmlHelper
    {
        public XmlHelper() { }

        private static string XmlStudentPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory+ ConfigHelp.GetSite("XmlStudentPath");
            }
        }
        private static string XmlZfPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + ConfigHelp.GetSite("XmlZfPath");
            }
        }
        public static List<Student> Read()
        {
            var ret = new List<Student>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(XmlStudentPath);
                XmlNodeList xn = doc.SelectNodes("Student");
            }
            catch(Exception ex)
            {
            }
            return ret;
        }
    }
}
