using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Xsl;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.IO;

namespace HerramientaXML
{
    public partial class frmEditorXML : Form
    {
        #region Variables Globales

        string strDirectory = Application.StartupPath;
        OpenFileDialog ofdConfiguracion = new OpenFileDialog();
        StringBuilder sErrorSchema = new StringBuilder();
        StringBuilder sAdvertenciaSchema = new StringBuilder();

        #endregion

        #region Eventos

        public frmEditorXML()
        {
            InitializeComponent();
        }

        private void btnBuscarFuenteXML_Click(object sender, EventArgs e)
        {
            //Llama al diálogo que buscará el archivo
            ofdConfiguracion.DefaultExt = "xml";
            ofdConfiguracion.Filter = "Archivos XML|*.xml";

            ofdConfiguracion.FilterIndex = 1;

            ofdConfiguracion.Multiselect = false;

            ofdConfiguracion.RestoreDirectory = true;

            DialogResult Result = ofdConfiguracion.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    ofdConfiguracion.InitialDirectory = ofdConfiguracion.FileName.Remove(ofdConfiguracion.FileName.LastIndexOf("\\"));
                    txtXMLFuente.Text = ofdConfiguracion.FileName;

                    XmlDocument xmlfuente = new XmlDocument();

                    xmlfuente.Load(ofdConfiguracion.FileName);

                    xmlBrowser.XmlText = xmlfuente.InnerXml;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnBuscarXSLT_Click(object sender, EventArgs e)
        {
            //Llama al diálogo que buscará el archivo
            ofdConfiguracion.DefaultExt = "xslt";
            ofdConfiguracion.Filter = "Archivos XSLT|*.xslt";

            ofdConfiguracion.FilterIndex = 1;

            ofdConfiguracion.Multiselect = false;

            ofdConfiguracion.RestoreDirectory = true;

            DialogResult Result = ofdConfiguracion.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    ofdConfiguracion.InitialDirectory = ofdConfiguracion.FileName.Remove(ofdConfiguracion.FileName.LastIndexOf("\\"));
                    txtXSLT.Text = ofdConfiguracion.FileName;

                    ucXmlRichTextBox1.Xml = System.IO.File.ReadAllText(txtXSLT.Text);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnGuardarXSLT_Click(object sender, EventArgs e)
        {
            // Crear instancia de SaveFileDialog
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Inicializacion
            saveFile1.DefaultExt = "*.xslt";
            saveFile1.Filter = "Archivos XSLT|*.xslt";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                ucXmlRichTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnTransformar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXMLFuente.Text))
            {
                MessageBox.Show("No se ha indicado un archivo fuente para la transformación XSLT", "Transformación XSLT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txtXSLT.Text))
                {
                    MessageBox.Show("No se ha indicado un archivo XSLT para realizar la transformación", "Transformación XSLT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        XslCompiledTransform xslt = new XslCompiledTransform();
                        xslt.Load(txtXSLT.Text);

                        // Create the writer.                   
                        //XmlDocument xmlfuente = new XmlDocument();

                        XPathDocument xmlDoc = new XPathDocument(txtXMLFuente.Text);
                        XPathNavigator nav = xmlDoc.CreateNavigator();

                        //XmlWriterSettings settings = new XmlWriterSettings();
                        //settings.Indent = true;
                        //settings.IndentChars = "\t";
                        //settings.ConformanceLevel = ConformanceLevel.Auto;
                        //XmlWriter writer = XmlWriter.Create("TransformacionXSLT.xml", settings);

                        StringWriter sWritter = new StringWriter();
                        XmlTextWriter myWriter = new XmlTextWriter(sWritter);

                        // Execute the transformation.
                        xslt.Transform(nav,null, myWriter);
                        //writer.Close();
                        // sWritter.
                        // xmlfuente.Load("TransformacionXSLT.xml");
                        archivoTransformado.Text = sWritter.ToString();

                        rbText.Checked = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al realizar la transformación. " + ex.Message, "Transformación XSLT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                   
                }
            }
        }

        private void btnBuscarXSD_Click(object sender, EventArgs e)
        {
            //Llama al diálogo que buscará el archivo
            ofdConfiguracion.DefaultExt = "xsd";
            ofdConfiguracion.Filter = "Archivo XSD|*.xsd";

            ofdConfiguracion.FilterIndex = 1;

            ofdConfiguracion.Multiselect = false;

            ofdConfiguracion.RestoreDirectory = true;

            DialogResult Result = ofdConfiguracion.ShowDialog();

            if (Result == DialogResult.OK)
            {
                ofdConfiguracion.InitialDirectory = ofdConfiguracion.FileName.Remove(ofdConfiguracion.FileName.LastIndexOf("\\"));
                txtXSD.Text = ofdConfiguracion.FileName;
            }
        }

        private void btnValidarXSD_Click(object sender, EventArgs e)
        {
            ValidationEventHandler eventHandler = new ValidationEventHandler(Settings_ValidationEventHandler);
            if (string.IsNullOrEmpty(archivoTransformado.Xml))
            {
                MessageBox.Show("No se ha realizado la transformacion XSLT", "Validación XSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txtXSD.Text))
                {
                    MessageBox.Show("No se ha indicado el archivo XSD", "Validación XSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        XmlReaderSettings xsdSignerSettings = new XmlReaderSettings();
                        xsdSignerSettings.ValidationType = ValidationType.DTD;
                        xsdSignerSettings.DtdProcessing = DtdProcessing.Ignore;
                        xsdSignerSettings.XmlResolver = null;
                        XmlReader reader = XmlReader.Create("xmldsig-core-schema.xsd", xsdSignerSettings);

                        sErrorSchema = new StringBuilder();
                        sAdvertenciaSchema = new StringBuilder();
                        XmlReaderSettings xsdSettings = new XmlReaderSettings();
                        xsdSettings.Schemas.Add(null, txtXSD.Text);
                        xsdSettings.Schemas.Add(null, reader);
                        xsdSettings.ValidationType = ValidationType.Schema;
                        xsdSettings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                        xsdSettings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                        xsdSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                        xsdSettings.ValidationEventHandler += Settings_ValidationEventHandler;
                        XmlDocument document = new XmlDocument();

                        using (XmlReader schemareader = XmlReader.Create(archivoTransformado.Xml, xsdSettings))
                        //using (XmlReader schemareader = XmlReader.Create("D:/Proyectos/Documentos/FE/Colombia/XSLT/Ejemplo XML Factura.xml", xsdSettings))
                        {
                            document.Load(schemareader);
                            document.Validate(eventHandler);
                        }
                        eventHandler = null;

                        if (sErrorSchema.Length > 0)
                        {
                            txtResultValidacion.Text = "Ocurrió un error al validar el documento: \n" + sErrorSchema.ToString();
                        }
                        if (sAdvertenciaSchema.Length > 0)
                        {
                            txtResultValidacion.Text = "Ocurrieron algunas advertencias al validar: " + sAdvertenciaSchema.ToString();
                        }
                        if (sErrorSchema.Length <= 0 && sAdvertenciaSchema.Length <= 0)
                        {
                            txtResultValidacion.Text = "No se presentaron errores en la validación!!!";
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResultValidacion.Text = "Ocurrió un error al validar el documento: \n" + ex.Message;
                    }
                    finally
                    {
                        eventHandler = null;
                    }
                }
            }
        }

        private void Settings_ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                sAdvertenciaSchema.AppendLine();
                sAdvertenciaSchema.Append("Advertencia: ");
                sAdvertenciaSchema.Append(args.Message);
            }
            else if (args.Severity == XmlSeverityType.Error)
            {
                sErrorSchema.AppendLine();
                sErrorSchema.Append("ERROR: ");
                sErrorSchema.Append(args.Message);
            }

        }
        #endregion

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cambiarFormato();
        }

        public void cambiarFormato()
        {
            string sData = string.Empty;

            if (rbText.Checked)
            {
                sData = archivoTransformado.Text;

                archivoTransformado.Text = sData;
                archivoTransformado.SelectionColor = Color.Black;
            }
            else
            {
                sData = archivoTransformado.Text;
                try
                {
                    archivoTransformado.Xml = sData;
                }
                catch (Exception)
                {
                    archivoTransformado.Text = sData;
                    archivoTransformado.SelectionColor = Color.Black;
                }
                
            }
        }
    }
}
