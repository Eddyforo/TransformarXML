namespace HerramientaXML
{
    partial class frmEditorXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorXML));
            this.tabXML_XSD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValidarXSLT = new System.Windows.Forms.Button();
            this.richTextValidaXslt = new System.Windows.Forms.RichTextBox();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextTransformacion = new System.Windows.Forms.RichTextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.archivoTransformado = new CustomXmlViewer.ucXmlRichTextBox();
            this.btnGuardarXSLT = new System.Windows.Forms.Button();
            this.btnBuscarXSLT = new System.Windows.Forms.Button();
            this.ucXmlRichTextBox1 = new CustomXmlViewer.ucXmlRichTextBox();
            this.txtXSLT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xmlBrowser = new XmlRender.XmlBrowser();
            this.btnBuscarFuenteXML = new System.Windows.Forms.Button();
            this.txtXMLFuente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtResultValidacion = new System.Windows.Forms.RichTextBox();
            this.btnValidarXSD = new System.Windows.Forms.Button();
            this.btnBuscarXSD = new System.Windows.Forms.Button();
            this.txtXSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabXML_XSD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabXML_XSD
            // 
            this.tabXML_XSD.Controls.Add(this.tabPage1);
            this.tabXML_XSD.Controls.Add(this.tabPage2);
            this.tabXML_XSD.Location = new System.Drawing.Point(-3, -2);
            this.tabXML_XSD.Name = "tabXML_XSD";
            this.tabXML_XSD.SelectedIndex = 0;
            this.tabXML_XSD.Size = new System.Drawing.Size(1341, 830);
            this.tabXML_XSD.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fuente XML y editor XSLT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnValidarXSLT);
            this.groupBox2.Controls.Add(this.richTextValidaXslt);
            this.groupBox2.Controls.Add(this.btnTransformar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnGuardarXSLT);
            this.groupBox2.Controls.Add(this.btnBuscarXSLT);
            this.groupBox2.Controls.Add(this.ucXmlRichTextBox1);
            this.groupBox2.Controls.Add(this.txtXSLT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(539, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 790);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor XSLT";
            // 
            // btnValidarXSLT
            // 
            this.btnValidarXSLT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidarXSLT.Image = global::HerramientaXML.Properties.Resources.Symbols23_1;
            this.btnValidarXSLT.Location = new System.Drawing.Point(9, 377);
            this.btnValidarXSLT.Name = "btnValidarXSLT";
            this.btnValidarXSLT.Size = new System.Drawing.Size(24, 23);
            this.btnValidarXSLT.TabIndex = 9;
            this.btnValidarXSLT.UseVisualStyleBackColor = true;
            this.btnValidarXSLT.Click += new System.EventHandler(this.btnValidarXSLT_Click);
            // 
            // richTextValidaXslt
            // 
            this.richTextValidaXslt.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextValidaXslt.Location = new System.Drawing.Point(39, 373);
            this.richTextValidaXslt.Name = "richTextValidaXslt";
            this.richTextValidaXslt.Size = new System.Drawing.Size(743, 31);
            this.richTextValidaXslt.TabIndex = 8;
            this.richTextValidaXslt.Text = "";
            // 
            // btnTransformar
            // 
            this.btnTransformar.Image = global::HerramientaXML.Properties.Resources.UpdateTableOfContents_16x16;
            this.btnTransformar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransformar.Location = new System.Drawing.Point(602, 21);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(85, 23);
            this.btnTransformar.TabIndex = 7;
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextTransformacion);
            this.groupBox3.Controls.Add(this.webBrowser);
            this.groupBox3.Controls.Add(this.rbHTML);
            this.groupBox3.Controls.Add(this.rbText);
            this.groupBox3.Controls.Add(this.rbXML);
            this.groupBox3.Controls.Add(this.archivoTransformado);
            this.groupBox3.Location = new System.Drawing.Point(9, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 374);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado Transformación";
            // 
            // richTextTransformacion
            // 
            this.richTextTransformacion.Location = new System.Drawing.Point(6, 38);
            this.richTextTransformacion.Name = "richTextTransformacion";
            this.richTextTransformacion.Size = new System.Drawing.Size(763, 330);
            this.richTextTransformacion.TabIndex = 9;
            this.richTextTransformacion.Text = "";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(6, 38);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(763, 330);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.Visible = false;
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point(117, 15);
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size(55, 17);
            this.rbHTML.TabIndex = 7;
            this.rbHTML.TabStop = true;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            this.rbHTML.CheckedChanged += new System.EventHandler(this.rbHTML_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(6, 15);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(52, 17);
            this.rbText.TabIndex = 6;
            this.rbText.TabStop = true;
            this.rbText.Text = "Texto";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(64, 15);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(47, 17);
            this.rbXML.TabIndex = 5;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            this.rbXML.CheckedChanged += new System.EventHandler(this.rbXML_CheckedChanged);
            // 
            // archivoTransformado
            // 
            this.archivoTransformado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archivoTransformado.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoTransformado.Location = new System.Drawing.Point(6, 38);
            this.archivoTransformado.Name = "archivoTransformado";
            this.archivoTransformado.Size = new System.Drawing.Size(763, 330);
            this.archivoTransformado.TabIndex = 4;
            this.archivoTransformado.Text = "";
            this.archivoTransformado.Xml = "";
            // 
            // btnGuardarXSLT
            // 
            this.btnGuardarXSLT.Image = global::HerramientaXML.Properties.Resources.Save_16x16;
            this.btnGuardarXSLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarXSLT.Location = new System.Drawing.Point(512, 21);
            this.btnGuardarXSLT.Name = "btnGuardarXSLT";
            this.btnGuardarXSLT.Size = new System.Drawing.Size(85, 23);
            this.btnGuardarXSLT.TabIndex = 5;
            this.btnGuardarXSLT.Text = "Guardar";
            this.btnGuardarXSLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarXSLT.UseVisualStyleBackColor = true;
            this.btnGuardarXSLT.Click += new System.EventHandler(this.btnGuardarXSLT_Click);
            // 
            // btnBuscarXSLT
            // 
            this.btnBuscarXSLT.Image = global::HerramientaXML.Properties.Resources.Find_16x16;
            this.btnBuscarXSLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarXSLT.Location = new System.Drawing.Point(422, 21);
            this.btnBuscarXSLT.Name = "btnBuscarXSLT";
            this.btnBuscarXSLT.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarXSLT.TabIndex = 4;
            this.btnBuscarXSLT.Text = "Examinar...";
            this.btnBuscarXSLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarXSLT.UseVisualStyleBackColor = true;
            this.btnBuscarXSLT.Click += new System.EventHandler(this.btnBuscarXSLT_Click);
            // 
            // ucXmlRichTextBox1
            // 
            this.ucXmlRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucXmlRichTextBox1.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucXmlRichTextBox1.Location = new System.Drawing.Point(9, 49);
            this.ucXmlRichTextBox1.Name = "ucXmlRichTextBox1";
            this.ucXmlRichTextBox1.Size = new System.Drawing.Size(773, 318);
            this.ucXmlRichTextBox1.TabIndex = 3;
            this.ucXmlRichTextBox1.Text = "";
            this.ucXmlRichTextBox1.Xml = "";
            // 
            // txtXSLT
            // 
            this.txtXSLT.Location = new System.Drawing.Point(105, 23);
            this.txtXSLT.Name = "txtXSLT";
            this.txtXSLT.Size = new System.Drawing.Size(311, 20);
            this.txtXSLT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ruta archivo XSLT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xmlBrowser);
            this.groupBox1.Controls.Add(this.btnBuscarFuenteXML);
            this.groupBox1.Controls.Add(this.txtXMLFuente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 790);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuente XML";
            // 
            // xmlBrowser
            // 
            this.xmlBrowser.Location = new System.Drawing.Point(9, 49);
            this.xmlBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.xmlBrowser.Name = "xmlBrowser";
            this.xmlBrowser.Size = new System.Drawing.Size(509, 735);
            this.xmlBrowser.TabIndex = 3;
            this.xmlBrowser.XmlDocument = null;
            this.xmlBrowser.XmlDocumentTransformType = XmlRender.XmlBrowser.XslTransformType.XSL;
            this.xmlBrowser.XmlText = "";
            // 
            // btnBuscarFuenteXML
            // 
            this.btnBuscarFuenteXML.Image = global::HerramientaXML.Properties.Resources.Find_16x16;
            this.btnBuscarFuenteXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFuenteXML.Location = new System.Drawing.Point(416, 21);
            this.btnBuscarFuenteXML.Name = "btnBuscarFuenteXML";
            this.btnBuscarFuenteXML.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarFuenteXML.TabIndex = 2;
            this.btnBuscarFuenteXML.Text = "Examinar...";
            this.btnBuscarFuenteXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFuenteXML.UseVisualStyleBackColor = true;
            this.btnBuscarFuenteXML.Click += new System.EventHandler(this.btnBuscarFuenteXML_Click);
            // 
            // txtXMLFuente
            // 
            this.txtXMLFuente.Location = new System.Drawing.Point(101, 23);
            this.txtXMLFuente.Name = "txtXMLFuente";
            this.txtXMLFuente.Size = new System.Drawing.Size(311, 20);
            this.txtXMLFuente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta archivo XML:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validador XSD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtResultValidacion);
            this.groupBox4.Controls.Add(this.btnValidarXSD);
            this.groupBox4.Controls.Add(this.btnBuscarXSD);
            this.groupBox4.Controls.Add(this.txtXSD);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(315, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 413);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Validación XSD";
            // 
            // txtResultValidacion
            // 
            this.txtResultValidacion.Font = new System.Drawing.Font("Lucida Sans", 8.5F);
            this.txtResultValidacion.Location = new System.Drawing.Point(30, 61);
            this.txtResultValidacion.Name = "txtResultValidacion";
            this.txtResultValidacion.Size = new System.Drawing.Size(626, 323);
            this.txtResultValidacion.TabIndex = 5;
            this.txtResultValidacion.Text = "";
            // 
            // btnValidarXSD
            // 
            this.btnValidarXSD.Image = global::HerramientaXML.Properties.Resources.Apply_16x16;
            this.btnValidarXSD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarXSD.Location = new System.Drawing.Point(554, 31);
            this.btnValidarXSD.Name = "btnValidarXSD";
            this.btnValidarXSD.Size = new System.Drawing.Size(102, 23);
            this.btnValidarXSD.TabIndex = 4;
            this.btnValidarXSD.Text = "Validar";
            this.btnValidarXSD.UseVisualStyleBackColor = true;
            this.btnValidarXSD.Click += new System.EventHandler(this.btnValidarXSD_Click);
            // 
            // btnBuscarXSD
            // 
            this.btnBuscarXSD.Image = global::HerramientaXML.Properties.Resources.Find_16x16;
            this.btnBuscarXSD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarXSD.Location = new System.Drawing.Point(446, 32);
            this.btnBuscarXSD.Name = "btnBuscarXSD";
            this.btnBuscarXSD.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarXSD.TabIndex = 3;
            this.btnBuscarXSD.Text = "Examinar...";
            this.btnBuscarXSD.UseVisualStyleBackColor = true;
            this.btnBuscarXSD.Click += new System.EventHandler(this.btnBuscarXSD_Click);
            // 
            // txtXSD
            // 
            this.txtXSD.Location = new System.Drawing.Point(129, 34);
            this.txtXSD.Name = "txtXSD";
            this.txtXSD.Size = new System.Drawing.Size(311, 20);
            this.txtXSD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ruta archivo XSD:";
            // 
            // frmEditorXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1337, 828);
            this.Controls.Add(this.tabXML_XSD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditorXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramienta XML";
            this.tabXML_XSD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabXML_XSD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarFuenteXML;
        private System.Windows.Forms.TextBox txtXMLFuente;
        private System.Windows.Forms.Label label1;
        private XmlRender.XmlBrowser xmlBrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtXSLT;
        private System.Windows.Forms.Label label2;
        private CustomXmlViewer.ucXmlRichTextBox ucXmlRichTextBox1;
        private System.Windows.Forms.Button btnBuscarXSLT;
        private System.Windows.Forms.Button btnGuardarXSLT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTransformar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarXSD;
        private System.Windows.Forms.TextBox txtXSD;
        private System.Windows.Forms.Button btnValidarXSD;
        private System.Windows.Forms.RichTextBox txtResultValidacion;
        private CustomXmlViewer.ucXmlRichTextBox archivoTransformado;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.RichTextBox richTextTransformacion;
        private System.Windows.Forms.RichTextBox richTextValidaXslt;
        private System.Windows.Forms.Button btnValidarXSLT;
    }
}

