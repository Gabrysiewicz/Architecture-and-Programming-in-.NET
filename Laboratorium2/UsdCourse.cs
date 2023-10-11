using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Laboratorium2
{
    internal class UsdCourse
    {
        public static decimal Current = 0;
        public async static Task<decimal> GetUsdCourseAsync()
        {
            var wc = new HttpClient();
            var response = await wc.GetAsync("http://www.nbp.pl/kursy/xml/LastA.xml");
            if (!response.IsSuccessStatusCode)
                throw new InvalidOperationException();

            System.Xml.XmlDocument xd = new System.Xml.XmlDocument();
            xd.LoadXml(await response.Content.ReadAsStringAsync());

            XDocument xdoc = XDocument.Parse(xd.OuterXml);
            var positions = xdoc.Element("tabela_kursow").Elements("pozycja")
                .Select(position => new
                {
                    Code = (string)position.Element("kod_waluty"),
                    Course = position.Element("kurs_sredni")
                });
            string enumerable = (string)positions.Where(x => x.Code.Equals("USD")).First().Course;
            decimal usdCourse;
            Decimal.TryParse(enumerable, out usdCourse);
            //decimal usdCourse = Convert.ToDecimal(enumerable);
            return usdCourse;
            /*
                foreach (System.Xml.XmlNode p in xd.GetElementsByTagName("pozycja"))
                {
                    if (p.NodeType == System.Xml.XmlNodeType.Element)
                    {
                        System.Xml.XmlElement pp = (System.Xml.XmlElement)p;
                        System.Xml.XmlElement w = (System.Xml.XmlElement)pp.GetElementsByTagName("kod_waluty")[0];
                        if (w.InnerText == "USD")
                        {
                            return Convert.ToDecimal(pp.GetElementsByTagName("kurs_sredni")[0].InnerText);
                        }
                    }
                }
                */
                throw new InvalidOperationException();
        }

    }
}
