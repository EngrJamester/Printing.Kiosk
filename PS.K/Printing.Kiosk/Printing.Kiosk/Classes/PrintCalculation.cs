using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Printing.Kiosk.Classes
{
    public class PrintCalculation
    {
        private decimal multiplier { get; set; }

        public decimal CalculateImageInFile(string FileFormatInDoc)
        {

            LoadDocument();

            Decimal pixelHeight = 96;
            Decimal pixelWidthl = 96;
            Decimal pixelArea = pixelHeight * pixelWidthl;
            Decimal amount = multiplier;
            Decimal finalAmount = 0;

            Spire.Doc.Document document = new Spire.Doc.Document(FileFormatInDoc);
            int index = 0;

            //Create a new Que
            Queue<ICompositeObject> containers = new Queue<ICompositeObject>();

            //Put the document Objects in the queue
            containers.Enqueue(document);

            while (containers.Count > 0)
            {
                ICompositeObject container = (ICompositeObject)containers.Dequeue();

                IDocumentObjectCollection docObjects = container.ChildObjects;

                foreach (DocumentObject docObject in docObjects)
                {
                    //judge the object type 

                    if (docObject.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Picture)
                    {
                        DocPicture picture = docObject as DocPicture;

                        decimal picHeight = pixelToInches(picture.Height + (picture.Height * 0.33));
                        decimal picWidth = pixelToInches(picture.Width + (picture.Width * 0.33));
                        decimal picArea = picHeight * picWidth;

                        finalAmount = finalAmount + (picArea * amount);
                        //'Name the image.
                        //'Dim imageName As String = String.Format("Image-{0}.png", index)
                        //'Save the image.
                        //'picture.Image.Save(imageName, System.Drawing.Imaging.ImageFormat.Png)
                        index += 1;
                    }
                    else
                    {
                        if (docObject is ICompositeObject)
                            containers.Enqueue(docObject as ICompositeObject);
                    }
                }
            }
            //MessageBox.Show(Convert.ToString(Math.Round(finalAmount, 0)), "Output");
            var value = Convert.ToString(Math.Round(finalAmount, 0));
            return Convert.ToDecimal(value);
        }


        public decimal pixelToInches(double px)
        {
            decimal ret;
            double pxPerIn = 95.999999998601;
            ret = (decimal)px / (decimal)pxPerIn;
            return Math.Round(ret, 2);
        }

        private void LoadDocument()
        {
            string path = Properties.Settings.Default.AdminPath + "Admin.xml"; // your code goes here

            bool exists = System.IO.Directory.Exists(Properties.Settings.Default.AdminPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.AdminPath);
                if (!File.Exists(path))
                {
                    var xml = new XElement("Admin", new XElement("multiplier", 0.0));
                    xml.Save(path);
                }
                else
                {
                    var xtr = new XmlTextReader(path);
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "multiplier")
                        {
                            multiplier = xtr.ReadElementContentAsDecimal();
                            xtr.Close();
                        }
                    }

                }
            }
            else
            {
                var xtr = new XmlTextReader(path);
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "multiplier")
                    {
                        multiplier = xtr.ReadElementContentAsDecimal();
                        xtr.Close();
                    }

                }
            }


        }
    }
}
