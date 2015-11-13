using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtW3
{
    public partial class TekstVerwerker : Form
    {
        public TekstVerwerker()
        {
            InitializeComponent();
        }

        //The font we currently have while we clicked the CopyFont button
        private Font copyfont;
        public Font CopyFont
        {
            get
            {
                return copyfont;
            }
            set
            {
                copyfont = value;
            }
        }

        //Edited will be true if we edited our document after we opened it or made a new one
        private bool edited;
        public bool Edited { get { return edited; } set { edited = value; } }

        //CurrentFontStyle holds the styles of the font we have currently selected
        private FontStyle currentfontstyle;
        public FontStyle CurrentFontStyle
        {
            get 
            { 
                return currentfontstyle; 
            }
            set
            {
                currentfontstyle = value;

                //Check which buttons we have to set as checked and which not
                tsbBold.Checked = tsmVet.Checked = cmsVet.Checked = (CurrentFontStyle & FontStyle.Bold) != 0 ? true : false;
                tsbItalic.Checked = tsmCurs.Checked = cmsCurs.Checked = (CurrentFontStyle & FontStyle.Italic) != 0 ? true : false;
                tsbUnderline.Checked = tsmOnders.Checked = cmsOnder.Checked = (CurrentFontStyle & FontStyle.Underline) != 0 ? true : false;
            }
        }


        private FileInfo currentfile;
        public FileInfo CurrentFile 
        { 
            get 
            { 
                return currentfile; 
            } 
            set 
            { 
                currentfile = value; 
                { 
            } } }


        private void mainMDI_Load(object sender, EventArgs e)
        {
            //Load in the font sizes and font's
            tsCmbFonts.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                tsCmbFonts.Items.Add(font.Name);
            }
            tsCmbFonts.SelectedIndex = 0;

            for (int i = 1; i <= 70; i++)
            {
                tsCmbSizes.Items.Add(i);
            }
            tsCmbSizes.SelectedIndex = 12 - 1;

            tsCmbStyles.SelectedIndex = 0;
        }

        private FontFamily GetFontFamilyByName(string name)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                if (font.Name == name)
                {
                    return font;
                }
            }

            return FontFamily.GenericMonospace;
        }


        private void OpenDocument()
        {
            DialogResult openFileResult = OpenFileDialog.ShowDialog();

            if (openFileResult == DialogResult.OK)
            {
                //Open the file / load it in the rich text box
                rtbDocument.LoadFile(OpenFileDialog.FileName, RichTextBoxStreamType.RichText);

                CurrentFile = new FileInfo(OpenFileDialog.FileName);
                Text = "Tekstverwerker - " + CurrentFile.Name;
            }
        }

        private void SaveDocument()
        {
            if (CurrentFile != null)
                if (CurrentFile.Exists)
                {
                    {
                        rtbDocument.SaveFile(CurrentFile.FullName, RichTextBoxStreamType.RichText);
                        return;
                    }
                }
            DialogResult saveFileResult = SaveFileDialog.ShowDialog();

            if (saveFileResult == DialogResult.OK)
            {
                //Open the file / load it in the rich text box
                rtbDocument.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.RichText);
                CurrentFile = new FileInfo(SaveFileDialog.FileName);
                this.Text = "Tekstverwerker - " + CurrentFile.Name;
            }
        }

        private void NewDocument()
        {
            TekstVerwerker ts = new TekstVerwerker();
            ts.Show();
            ts.Text = "Tekstverwerker - Nieuw Document";
        }


        private void tsCmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedFont(GetFontFamilyByName(tsCmbFonts.Text), 0);
        }

        private void tsCmbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedFont(null, float.Parse(tsCmbSizes.Text));
        }


        private void ChangeSelectedFont(FontFamily fFamilly, float fSize)
        {
            int StartSelection = rtbDocument.SelectionStart;
            int SelectionLength = rtbDocument.SelectionLength;

            //If we don't have a selection, we set everything to the default
            if (rtbDocument.SelectionLength == 0)
            {
                if (fFamilly != null)
                    rtbDocument.Font = new Font(fFamilly, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style);
                if (fSize != 0)
                    rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, fSize, rtbDocument.SelectionFont.Style);

            }
            else if (rtbDocument.SelectionLength == rtbDocument.Text.Length)
            {
                 if (fFamilly != null)
                    rtbDocument.Font = new Font(fFamilly, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style);
                if (fSize != 0)
                    rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, fSize, rtbDocument.SelectionFont.Style);
            }
            else if (rtbDocument.SelectionLength != rtbDocument.Text.Length)
            {

                        if (fFamilly != null)
                            rtbDocument.SelectionFont = new Font(fFamilly, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style);
                        if (fSize != 0)
                            rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, fSize, rtbDocument.SelectionFont.Style);
         
            }
           
            
            rtbDocument.SelectionStart = StartSelection;
            rtbDocument.SelectionLength = SelectionLength;
            rtbDocument.Focus();

        }


        private void tsbNewDocument_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void tsbOpenDocument_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void tsbSaveDocument_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void rtbDocument_TextChanged(object sender, EventArgs e)
        {
            if (Edited == false)
                Edited = true;
        }

        private void rtbDocument_SelectionChanged(object sender, EventArgs e)
        {
            if (CopyFont != null)
            {
                if (rtbDocument.SelectionFont != null)
                {
                    rtbDocument.SelectionFont = CopyFont;
                    CopyFont = null;
                }
            }

            //Check which font style we have
            CurrentFontStyle = FontStyle.Regular;
            if (rtbDocument.SelectionFont != null)
            {
                if (rtbDocument.SelectionFont.Bold)
                    CurrentFontStyle |= FontStyle.Bold;
                if (rtbDocument.SelectionFont.Italic)
                    CurrentFontStyle |= FontStyle.Italic;
                if (rtbDocument.SelectionFont.Underline)
                    CurrentFontStyle |= FontStyle.Underline;
            }
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            if (rtbDocument.SelectionFont == null)
                return;

            if (!tsbBold.Checked)
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style | FontStyle.Bold);
                tsbBold.Checked = tsmVet.Checked = cmsVet.Checked = true;
            }
            else
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Bold);
                tsbBold.Checked = tsmVet.Checked = cmsVet.Checked = false;
            }
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            if (rtbDocument.SelectionFont == null)
                return;

            if (!tsbItalic.Checked)
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style | FontStyle.Italic);
                tsbItalic.Checked = tsmCurs.Checked = cmsCurs.Checked = true;
            }
            else
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Italic);
                tsbItalic.Checked = tsmCurs.Checked = cmsCurs.Checked = false;

            }
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            if (rtbDocument.SelectionFont == null)
                return;

            if (!tsbUnderline.Checked)
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style | FontStyle.Underline);
                tsbUnderline.Checked = tsmOnders.Checked = cmsOnder.Checked = true;
            }
            else
            {
                rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Underline);
                tsbUnderline.Checked = tsmOnders.Checked = cmsOnder.Checked = false;

            }
        }

        private void tsbCopyFont_Click(object sender, EventArgs e)
        {
            CopyFont = rtbDocument.SelectionFont;
        }

        private void tsbCopyText_Click(object sender, EventArgs e)
        {
            rtbDocument.Copy();
            tsbPasteText.Enabled = true;
        }

        private void tsbPasteText_Click(object sender, EventArgs e)
        {
            rtbDocument.Paste();
        }

        private void tsZoeken_ButtonClick(object sender, EventArgs e)
        {
            Zoeken zk = new Zoeken(rtbDocument);
            zk.Show();
        }

        private void tsVervangen_ButtonClick(object sender, EventArgs e)
        {
            Vervangen vv = new Vervangen(rtbDocument);
            vv.Show();
        }

        private void rtbDocument_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point relativeToForm = this.PointToScreen(e.Location);
                relativeToForm.Y += 50; //Reduce the Y position for better display
                cmsOptions.Show(relativeToForm);
            }
        }

        private void tsbCutText_Click(object sender, EventArgs e)
        {
            rtbDocument.Cut();
        }

        private void rtbDocument_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbDocument.SelectedText.Length > 0)
            {
                tsbCutText.Enabled = tsbCopyFont.Enabled = true;
            }
            else
            {
                tsbCutText.Enabled = tsbCopyFont.Enabled = false;
            }
        }

        private void tsmRood_Click(object sender, EventArgs e)
        {
            rtbDocument.SelectionColor = Color.Red;
        }

        private void tsmZwart_Click(object sender, EventArgs e)
        {
            rtbDocument.SelectionColor = Color.Black;
        }

        private void tsmBlauw_Click(object sender, EventArgs e)
        {
            rtbDocument.SelectionColor = Color.Blue;
        }

        private void tsmGeel_Click(object sender, EventArgs e)
        {
            rtbDocument.SelectionColor = Color.Yellow;
        }

        private void printenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pd.ShowDialog();
        }

        private void tsCmbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tsCmbStyles.Text)
            {
                case "Normal":
                     rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Bold);
                tsbBold.Checked = tsmVet.Checked = cmsVet.Checked = false;
                    rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Italic);
                tsbItalic.Checked = tsmCurs.Checked = cmsCurs.Checked = false;
                                    rtbDocument.SelectionFont = new Font(rtbDocument.SelectionFont.FontFamily, rtbDocument.SelectionFont.Size, rtbDocument.SelectionFont.Style & ~FontStyle.Underline);
                tsbUnderline.Checked = tsmOnders.Checked = cmsOnder.Checked = false;

                    break;
                case "Vet - Cursief":
                    tsbItalic_Click(sender, e);
                    tsbBold_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
