using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CustomXmlViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string filename = "Resource\\XmlComplex.xml";

            string xml = System.IO.File.ReadAllText(filename);
            ucXmlRichTextBox1.Xml = xml;
        }
    }
}
