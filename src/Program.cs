using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace MetaSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args);
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments provided");
                return;
            }

            try
            {
                if (File.Exists(args[0]))
                {
                    XDocument doc = XDocument.Load(args[0]);
                    IEnumerable<XElement> items = doc.Root.Descendants("Item");

                    var files = 0;
                    var type = "";
                    Directory.CreateDirectory("output");

                    if (doc.Element("CVehicleModelInfo__InitDataList") != null) // vehicle.meta
                    {
                        type = " vehicles ";
                        foreach (XElement elm in items)
                        {
                            if (elm.Element("modelName") != null)
                            {
                                files++;
                                XDocument xmlDoc = new XDocument();
                                XElement xElm = new XElement("CVehicleModelInfo__InitDataList", new XElement("residentTxd", "vehshare"), new XElement("residentAnims"), new XElement("InitDatas"));
                                xmlDoc.Add(xElm);
                                xmlDoc.Root.Element("InitDatas").Add(new XElement(elm));
                                var vehname = elm.Element("modelName").Value.ToLower();
                                Directory.CreateDirectory("output\\" + vehname);
                                xmlDoc.Save("output\\" + vehname + "\\vehicles.meta");
                            }
                        }
                    }
                    else //handling.meta
                    {
                        type = " handlings ";
                        foreach (XElement elm in items)
                        {
                            if (elm.Element("handlingName") != null)
                            {
                                files++;
                                XDocument xmlDoc = new XDocument();
                                XElement xElm = new XElement("CHandlingDataMgr", new XElement("HandlingData"));
                                xmlDoc.Add(xElm);
                                xmlDoc.Root.Element("HandlingData").Add(new XElement(elm));
                                var vehname = elm.Element("handlingName").Value.ToLower();
                                Directory.CreateDirectory("output\\" + vehname);
                                xmlDoc.Save("output\\" + vehname + "\\handling.meta");

                            }
                        }
                    }

                    Console.WriteLine(files + type + "exported.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
