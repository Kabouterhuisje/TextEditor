namespace OpdrachtW3
{
    partial class TekstVerwerker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TekstVerwerker));
            this.openenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZoek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVervang = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKopieer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKnippen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlakken = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmKopieeropmaak = new System.Windows.Forms.ToolStripMenuItem();
            this.opmaakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOnders = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCurs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOnder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsKopieer = new System.Windows.Forms.ToolStripMenuItem();
            this.plakkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.knippenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiëerFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tsmOpslaan = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDocument = new System.Windows.Forms.RichTextBox();
            this.tsOpties = new System.Windows.Forms.ToolStrip();
            this.tsbNewDocument = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenDocument = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveDocument = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyText = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyFont = new System.Windows.Forms.ToolStripButton();
            this.tsbPasteText = new System.Windows.Forms.ToolStripButton();
            this.tsbCutText = new System.Windows.Forms.ToolStripButton();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsZoeken = new System.Windows.Forms.ToolStripSplitButton();
            this.tsVervangen = new System.Windows.Forms.ToolStripSplitButton();
            this.tsCmbStyles = new System.Windows.Forms.ToolStripComboBox();
            this.tsCmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.tsCmbSizes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbColor = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmZwart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBlauw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpties = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNieuwDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.printenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.cmsOptions.SuspendLayout();
            this.tsOpties.SuspendLayout();
            this.msOpties.SuspendLayout();
            this.SuspendLayout();
            // 
            // openenToolStripMenuItem1
            // 
            this.openenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openenToolStripMenuItem1.Image")));
            this.openenToolStripMenuItem1.Name = "openenToolStripMenuItem1";
            this.openenToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.openenToolStripMenuItem1.Text = "Openen";
            this.openenToolStripMenuItem1.Click += new System.EventHandler(this.tsbOpenDocument_Click);
            // 
            // bewerkenToolStripMenuItem1
            // 
            this.bewerkenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmZoek,
            this.tsmVervang});
            this.bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            this.bewerkenToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.bewerkenToolStripMenuItem1.Text = "Bewerken";
            // 
            // tsmZoek
            // 
            this.tsmZoek.Name = "tsmZoek";
            this.tsmZoek.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmZoek.Size = new System.Drawing.Size(173, 22);
            this.tsmZoek.Text = "&Zoeken";
            this.tsmZoek.Click += new System.EventHandler(this.tsZoeken_ButtonClick);
            // 
            // tsmVervang
            // 
            this.tsmVervang.Name = "tsmVervang";
            this.tsmVervang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmVervang.Size = new System.Drawing.Size(173, 22);
            this.tsmVervang.Text = "&Vervangen";
            this.tsmVervang.Click += new System.EventHandler(this.tsVervangen_ButtonClick);
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKopieer,
            this.tsmKnippen,
            this.tsmPlakken,
            this.toolStripMenuItem2,
            this.tsmKopieeropmaak});
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bewerkenToolStripMenuItem.Text = "Klembord";
            this.bewerkenToolStripMenuItem.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // tsmKopieer
            // 
            this.tsmKopieer.Image = ((System.Drawing.Image)(resources.GetObject("tsmKopieer.Image")));
            this.tsmKopieer.Name = "tsmKopieer";
            this.tsmKopieer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmKopieer.Size = new System.Drawing.Size(203, 22);
            this.tsmKopieer.Text = "&Kopiëren";
            this.tsmKopieer.Click += new System.EventHandler(this.tsbCopyText_Click);
            // 
            // tsmKnippen
            // 
            this.tsmKnippen.Image = ((System.Drawing.Image)(resources.GetObject("tsmKnippen.Image")));
            this.tsmKnippen.Name = "tsmKnippen";
            this.tsmKnippen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmKnippen.Size = new System.Drawing.Size(203, 22);
            this.tsmKnippen.Text = "&Knippen";
            this.tsmKnippen.Click += new System.EventHandler(this.tsbCutText_Click);
            // 
            // tsmPlakken
            // 
            this.tsmPlakken.Image = ((System.Drawing.Image)(resources.GetObject("tsmPlakken.Image")));
            this.tsmPlakken.Name = "tsmPlakken";
            this.tsmPlakken.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmPlakken.Size = new System.Drawing.Size(203, 22);
            this.tsmPlakken.Text = "&Plakken";
            this.tsmPlakken.Click += new System.EventHandler(this.tsbPasteText_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmKopieeropmaak
            // 
            this.tsmKopieeropmaak.Image = ((System.Drawing.Image)(resources.GetObject("tsmKopieeropmaak.Image")));
            this.tsmKopieeropmaak.Name = "tsmKopieeropmaak";
            this.tsmKopieeropmaak.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmKopieeropmaak.Size = new System.Drawing.Size(203, 22);
            this.tsmKopieeropmaak.Text = "&Kopiëer opmaak";
            this.tsmKopieeropmaak.Click += new System.EventHandler(this.tsbCopyFont_Click);
            // 
            // opmaakToolStripMenuItem
            // 
            this.opmaakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVet,
            this.tsmCurs,
            this.tsmOnders});
            this.opmaakToolStripMenuItem.Name = "opmaakToolStripMenuItem";
            this.opmaakToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.opmaakToolStripMenuItem.Text = "Opmaak";
            // 
            // tsmVet
            // 
            this.tsmVet.Name = "tsmVet";
            this.tsmVet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmVet.Size = new System.Drawing.Size(181, 22);
            this.tsmVet.Text = "&Vet";
            this.tsmVet.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // tsmCurs
            // 
            this.tsmCurs.Name = "tsmCurs";
            this.tsmCurs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmCurs.Size = new System.Drawing.Size(181, 22);
            this.tsmCurs.Text = "&Cursief";
            this.tsmCurs.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // tsmOnders
            // 
            this.tsmOnders.Name = "tsmOnders";
            this.tsmOnders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmOnders.Size = new System.Drawing.Size(181, 22);
            this.tsmOnders.Text = "&Ondersteept";
            this.tsmOnders.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Plain Text (*.txt)|*.txt|RTF Bestand|*.rtf";
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVet,
            this.cmsCurs,
            this.cmsOnder,
            this.toolStripMenuItem1,
            this.cmsKopieer,
            this.plakkenToolStripMenuItem1,
            this.knippenToolStripMenuItem1,
            this.kopiëerFontToolStripMenuItem,
            this.toolStripMenuItem3,
            this.openenToolStripMenuItem,
            this.openenToolStripMenuItem1,
            this.opslaanToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(168, 236);
            // 
            // cmsVet
            // 
            this.cmsVet.Image = ((System.Drawing.Image)(resources.GetObject("cmsVet.Image")));
            this.cmsVet.Name = "cmsVet";
            this.cmsVet.Size = new System.Drawing.Size(167, 22);
            this.cmsVet.Text = "Vet";
            this.cmsVet.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // cmsCurs
            // 
            this.cmsCurs.Image = ((System.Drawing.Image)(resources.GetObject("cmsCurs.Image")));
            this.cmsCurs.Name = "cmsCurs";
            this.cmsCurs.Size = new System.Drawing.Size(167, 22);
            this.cmsCurs.Text = "Cursief";
            this.cmsCurs.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // cmsOnder
            // 
            this.cmsOnder.Image = ((System.Drawing.Image)(resources.GetObject("cmsOnder.Image")));
            this.cmsOnder.Name = "cmsOnder";
            this.cmsOnder.Size = new System.Drawing.Size(167, 22);
            this.cmsOnder.Text = "Onderstrepen";
            this.cmsOnder.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // cmsKopieer
            // 
            this.cmsKopieer.Image = ((System.Drawing.Image)(resources.GetObject("cmsKopieer.Image")));
            this.cmsKopieer.Name = "cmsKopieer";
            this.cmsKopieer.Size = new System.Drawing.Size(167, 22);
            this.cmsKopieer.Text = "Kopiëren";
            this.cmsKopieer.Click += new System.EventHandler(this.tsbCopyText_Click);
            // 
            // plakkenToolStripMenuItem1
            // 
            this.plakkenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("plakkenToolStripMenuItem1.Image")));
            this.plakkenToolStripMenuItem1.Name = "plakkenToolStripMenuItem1";
            this.plakkenToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.plakkenToolStripMenuItem1.Text = "Plakken";
            this.plakkenToolStripMenuItem1.Click += new System.EventHandler(this.tsbPasteText_Click);
            // 
            // knippenToolStripMenuItem1
            // 
            this.knippenToolStripMenuItem1.Enabled = false;
            this.knippenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("knippenToolStripMenuItem1.Image")));
            this.knippenToolStripMenuItem1.Name = "knippenToolStripMenuItem1";
            this.knippenToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.knippenToolStripMenuItem1.Text = "Knippen";
            this.knippenToolStripMenuItem1.Click += new System.EventHandler(this.tsbCutText_Click);
            // 
            // kopiëerFontToolStripMenuItem
            // 
            this.kopiëerFontToolStripMenuItem.Enabled = false;
            this.kopiëerFontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopiëerFontToolStripMenuItem.Image")));
            this.kopiëerFontToolStripMenuItem.Name = "kopiëerFontToolStripMenuItem";
            this.kopiëerFontToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kopiëerFontToolStripMenuItem.Text = "Kopiëer opmaak";
            this.kopiëerFontToolStripMenuItem.Click += new System.EventHandler(this.tsbCopyFont_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openenToolStripMenuItem.Image")));
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openenToolStripMenuItem.Text = "Nieuw Document";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.tsbNewDocument_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opslaanToolStripMenuItem.Image")));
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.tsbSaveDocument_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Plain Text (*.txt)|*.txt|RTF Bestand|*.rtf";
            // 
            // tsmOpslaan
            // 
            this.tsmOpslaan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmOpslaan.Name = "tsmOpslaan";
            this.tsmOpslaan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmOpslaan.Size = new System.Drawing.Size(210, 22);
            this.tsmOpslaan.Text = "&Opslaan";
            this.tsmOpslaan.Click += new System.EventHandler(this.tsbSaveDocument_Click);
            // 
            // rtbDocument
            // 
            this.rtbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocument.HideSelection = false;
            this.rtbDocument.Location = new System.Drawing.Point(0, 49);
            this.rtbDocument.Name = "rtbDocument";
            this.rtbDocument.Size = new System.Drawing.Size(1099, 559);
            this.rtbDocument.TabIndex = 5;
            this.rtbDocument.Text = "";
            this.rtbDocument.SelectionChanged += new System.EventHandler(this.rtbDocument_SelectionChanged);
            this.rtbDocument.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbDocument_MouseClick);
            this.rtbDocument.TextChanged += new System.EventHandler(this.rtbDocument_TextChanged);
            this.rtbDocument.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbDocument_MouseDown);
            // 
            // tsOpties
            // 
            this.tsOpties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewDocument,
            this.tsbOpenDocument,
            this.tsbSaveDocument,
            this.tsbCopyText,
            this.tsbCopyFont,
            this.tsbPasteText,
            this.tsbCutText,
            this.tsbBold,
            this.tsbUnderline,
            this.tsbItalic,
            this.tsZoeken,
            this.tsVervangen,
            this.tsCmbStyles,
            this.tsCmbFonts,
            this.tsCmbSizes,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsbColor});
            this.tsOpties.Location = new System.Drawing.Point(0, 24);
            this.tsOpties.Name = "tsOpties";
            this.tsOpties.Size = new System.Drawing.Size(1099, 25);
            this.tsOpties.TabIndex = 4;
            this.tsOpties.Text = "toolStrip1";
            // 
            // tsbNewDocument
            // 
            this.tsbNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewDocument.Image")));
            this.tsbNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewDocument.Name = "tsbNewDocument";
            this.tsbNewDocument.Size = new System.Drawing.Size(104, 22);
            this.tsbNewDocument.Text = "Nieuw Document";
            this.tsbNewDocument.Click += new System.EventHandler(this.tsbNewDocument_Click);
            // 
            // tsbOpenDocument
            // 
            this.tsbOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenDocument.Image")));
            this.tsbOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenDocument.Name = "tsbOpenDocument";
            this.tsbOpenDocument.Size = new System.Drawing.Size(53, 22);
            this.tsbOpenDocument.Text = "Openen";
            this.tsbOpenDocument.Click += new System.EventHandler(this.tsbOpenDocument_Click);
            // 
            // tsbSaveDocument
            // 
            this.tsbSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveDocument.Image")));
            this.tsbSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveDocument.Name = "tsbSaveDocument";
            this.tsbSaveDocument.Size = new System.Drawing.Size(54, 22);
            this.tsbSaveDocument.Text = "Opslaan";
            this.tsbSaveDocument.Click += new System.EventHandler(this.tsbSaveDocument_Click);
            // 
            // tsbCopyText
            // 
            this.tsbCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCopyText.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyText.Image")));
            this.tsbCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyText.Name = "tsbCopyText";
            this.tsbCopyText.Size = new System.Drawing.Size(58, 22);
            this.tsbCopyText.Text = "Kopiëren";
            this.tsbCopyText.Click += new System.EventHandler(this.tsbCopyText_Click);
            // 
            // tsbCopyFont
            // 
            this.tsbCopyFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCopyFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyFont.Image")));
            this.tsbCopyFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyFont.Name = "tsbCopyFont";
            this.tsbCopyFont.Size = new System.Drawing.Size(76, 22);
            this.tsbCopyFont.Text = "Kopiëer font";
            this.tsbCopyFont.Click += new System.EventHandler(this.tsbCopyFont_Click);
            // 
            // tsbPasteText
            // 
            this.tsbPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPasteText.Enabled = false;
            this.tsbPasteText.Image = ((System.Drawing.Image)(resources.GetObject("tsbPasteText.Image")));
            this.tsbPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPasteText.Name = "tsbPasteText";
            this.tsbPasteText.Size = new System.Drawing.Size(52, 22);
            this.tsbPasteText.Text = "Plakken";
            this.tsbPasteText.Click += new System.EventHandler(this.tsbPasteText_Click);
            // 
            // tsbCutText
            // 
            this.tsbCutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCutText.Enabled = false;
            this.tsbCutText.Image = ((System.Drawing.Image)(resources.GetObject("tsbCutText.Image")));
            this.tsbCutText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCutText.Name = "tsbCutText";
            this.tsbCutText.Size = new System.Drawing.Size(55, 22);
            this.tsbCutText.Text = "Knippen";
            this.tsbCutText.Click += new System.EventHandler(this.tsbCutText_Click);
            // 
            // tsbBold
            // 
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbBold.Image")));
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(23, 22);
            this.tsbBold.Text = "Vet";
            this.tsbBold.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbUnderline.Text = "Onderstreept";
            this.tsbUnderline.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // tsbItalic
            // 
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbItalic.Text = "Cursief";
            this.tsbItalic.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // tsZoeken
            // 
            this.tsZoeken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoeken.Name = "tsZoeken";
            this.tsZoeken.Size = new System.Drawing.Size(62, 22);
            this.tsZoeken.Text = "Zoeken";
            this.tsZoeken.Click += new System.EventHandler(this.tsZoeken_ButtonClick);
            // 
            // tsVervangen
            // 
            this.tsVervangen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVervangen.Name = "tsVervangen";
            this.tsVervangen.Size = new System.Drawing.Size(79, 22);
            this.tsVervangen.Text = "Vervangen";
            this.tsVervangen.Click += new System.EventHandler(this.tsVervangen_ButtonClick);
            // 
            // tsCmbStyles
            // 
            this.tsCmbStyles.Items.AddRange(new object[] {
            "Normal",
            "Vet - Cursief"});
            this.tsCmbStyles.Name = "tsCmbStyles";
            this.tsCmbStyles.Size = new System.Drawing.Size(121, 25);
            this.tsCmbStyles.SelectedIndexChanged += new System.EventHandler(this.tsCmbStyles_SelectedIndexChanged);
            // 
            // tsCmbFonts
            // 
            this.tsCmbFonts.Name = "tsCmbFonts";
            this.tsCmbFonts.Size = new System.Drawing.Size(121, 25);
            this.tsCmbFonts.SelectedIndexChanged += new System.EventHandler(this.tsCmbFonts_SelectedIndexChanged);
            // 
            // tsCmbSizes
            // 
            this.tsCmbSizes.AutoSize = false;
            this.tsCmbSizes.DropDownWidth = 40;
            this.tsCmbSizes.Name = "tsCmbSizes";
            this.tsCmbSizes.Size = new System.Drawing.Size(35, 23);
            this.tsCmbSizes.SelectedIndexChanged += new System.EventHandler(this.tsCmbSizes_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsmZwart,
            this.tsmRood,
            this.tsmBlauw,
            this.tsmGeel});
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(16, 22);
            this.tsbColor.Text = "Kleur";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(103, 6);
            // 
            // tsmZwart
            // 
            this.tsmZwart.Name = "tsmZwart";
            this.tsmZwart.Size = new System.Drawing.Size(106, 22);
            this.tsmZwart.Text = "Zwart";
            this.tsmZwart.Click += new System.EventHandler(this.tsmZwart_Click);
            // 
            // tsmRood
            // 
            this.tsmRood.Name = "tsmRood";
            this.tsmRood.Size = new System.Drawing.Size(106, 22);
            this.tsmRood.Text = "Rood";
            this.tsmRood.Click += new System.EventHandler(this.tsmRood_Click);
            // 
            // tsmBlauw
            // 
            this.tsmBlauw.Name = "tsmBlauw";
            this.tsmBlauw.Size = new System.Drawing.Size(106, 22);
            this.tsmBlauw.Text = "Blauw";
            this.tsmBlauw.Click += new System.EventHandler(this.tsmBlauw_Click);
            // 
            // tsmGeel
            // 
            this.tsmGeel.Name = "tsmGeel";
            this.tsmGeel.Size = new System.Drawing.Size(106, 22);
            this.tsmGeel.Text = "Geel";
            this.tsmGeel.Click += new System.EventHandler(this.tsmGeel_Click);
            // 
            // tsmOpenDoc
            // 
            this.tsmOpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmOpenDoc.Name = "tsmOpenDoc";
            this.tsmOpenDoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmOpenDoc.Size = new System.Drawing.Size(210, 22);
            this.tsmOpenDoc.Text = "&Open";
            this.tsmOpenDoc.Click += new System.EventHandler(this.tsbOpenDocument_Click);
            // 
            // msOpties
            // 
            this.msOpties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bewerkenToolStripMenuItem1,
            this.bewerkenToolStripMenuItem,
            this.opmaakToolStripMenuItem});
            this.msOpties.Location = new System.Drawing.Point(0, 0);
            this.msOpties.Name = "msOpties";
            this.msOpties.Size = new System.Drawing.Size(1099, 24);
            this.msOpties.TabIndex = 6;
            this.msOpties.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNieuwDocument,
            this.tsmOpenDoc,
            this.tsmOpslaan,
            this.printenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "&Bestand";
            // 
            // tsmNieuwDocument
            // 
            this.tsmNieuwDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmNieuwDocument.Name = "tsmNieuwDocument";
            this.tsmNieuwDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmNieuwDocument.Size = new System.Drawing.Size(210, 22);
            this.tsmNieuwDocument.Text = "&Nieuw Document";
            this.tsmNieuwDocument.Click += new System.EventHandler(this.tsbNewDocument_Click);
            // 
            // printenToolStripMenuItem
            // 
            this.printenToolStripMenuItem.Name = "printenToolStripMenuItem";
            this.printenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printenToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.printenToolStripMenuItem.Text = "&Printen";
            this.printenToolStripMenuItem.Click += new System.EventHandler(this.printenToolStripMenuItem_Click);
            // 
            // pd
            // 
            this.pd.UseEXDialog = true;
            // 
            // TekstVerwerker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 608);
            this.Controls.Add(this.rtbDocument);
            this.Controls.Add(this.tsOpties);
            this.Controls.Add(this.msOpties);
            this.Name = "TekstVerwerker";
            this.Text = "6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainMDI_Load);
            this.cmsOptions.ResumeLayout(false);
            this.tsOpties.ResumeLayout(false);
            this.tsOpties.PerformLayout();
            this.msOpties.ResumeLayout(false);
            this.msOpties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmZoek;
        private System.Windows.Forms.ToolStripMenuItem tsmVervang;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmKopieer;
        private System.Windows.Forms.ToolStripMenuItem tsmKnippen;
        private System.Windows.Forms.ToolStripMenuItem tsmPlakken;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmKopieeropmaak;
        private System.Windows.Forms.ToolStripMenuItem opmaakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmVet;
        private System.Windows.Forms.ToolStripMenuItem tsmCurs;
        private System.Windows.Forms.ToolStripMenuItem tsmOnders;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem cmsVet;
        private System.Windows.Forms.ToolStripMenuItem cmsCurs;
        private System.Windows.Forms.ToolStripMenuItem cmsOnder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsKopieer;
        private System.Windows.Forms.ToolStripMenuItem plakkenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem knippenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopiëerFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmOpslaan;
        private System.Windows.Forms.RichTextBox rtbDocument;
        private System.Windows.Forms.ToolStrip tsOpties;
        private System.Windows.Forms.ToolStripButton tsbNewDocument;
        private System.Windows.Forms.ToolStripButton tsbOpenDocument;
        private System.Windows.Forms.ToolStripButton tsbSaveDocument;
        private System.Windows.Forms.ToolStripComboBox tsCmbStyles;
        private System.Windows.Forms.ToolStripComboBox tsCmbFonts;
        private System.Windows.Forms.ToolStripComboBox tsCmbSizes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCutText;
        private System.Windows.Forms.ToolStripButton tsbPasteText;
        private System.Windows.Forms.ToolStripButton tsbCopyText;
        private System.Windows.Forms.ToolStripButton tsbCopyFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.ToolStripSplitButton tsbColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmZwart;
        private System.Windows.Forms.ToolStripMenuItem tsmRood;
        private System.Windows.Forms.ToolStripMenuItem tsmBlauw;
        private System.Windows.Forms.ToolStripMenuItem tsmGeel;
        private System.Windows.Forms.ToolStripSplitButton tsZoeken;
        private System.Windows.Forms.ToolStripSplitButton tsVervangen;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenDoc;
        private System.Windows.Forms.MenuStrip msOpties;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNieuwDocument;
        private System.Windows.Forms.PrintDialog pd;
        private System.Windows.Forms.ToolStripMenuItem printenToolStripMenuItem;
    }
}