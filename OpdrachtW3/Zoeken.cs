using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtW3
{
    public partial class Zoeken : Form
    {
        //RichTextBox waarin we gaan zoeken
        RichTextBox rtbZoek;

        int ZoekPositie = 0;
        bool Gevonden = true;

        public Zoeken(RichTextBox richbox)
        {
            rtbZoek = richbox;
            InitializeComponent();
        }

        private void btnVolgend_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds rtbF = RichTextBoxFinds.None;
            if (ckbHeelWoord.Checked)
                rtbF |= RichTextBoxFinds.WholeWord;
            if (ckbIdent.Checked)
                rtbF |= RichTextBoxFinds.MatchCase;

            Zoek(txtSearch.Text, rtbF);
        }

        public void Vervang(string zoekText, string vervangText, RichTextBoxFinds rtbF)
        {
            //Zolang onze zoek positie niet de lente van de zoektext is kunnen we zoeken, anders zitten we aan t einde en geven we een -1
            if (ZoekPositie != rtbZoek.Text.Length)
                ZoekPositie = rtbZoek.Find(zoekText, ZoekPositie, rtbZoek.Text.Length, rtbF);
            else
                ZoekPositie = -1;

            //Als onze index niet -1 is hebben we iets gevonden, de index heeft dan het nummer van de start positie van het woord
            if (ZoekPositie != -1)
            {
                //Selecteer dit woord vanaf de ZoekPositie(start) tot en met de lengte van onze zoektext
                rtbZoek.Select(ZoekPositie, zoekText.Length);
                //ZoekPositie += zoekText.Length;
                rtbZoek.Text = rtbZoek.Text.Substring(0, ZoekPositie) + vervangText + rtbZoek.Text.Substring(ZoekPositie + vervangText.Length);
                //Zorg ervoor dat onze ZoekPositie vermeerderd word
                ZoekPositie += zoekText.Length;
            }
            else
            {
                MessageBox.Show(string.Format("Kan {0} niet vinden", zoekText));
                ZoekPositie = 0;
                Gevonden = false;
            }
        }

        public void Zoek(string zoekText, RichTextBoxFinds rtbF)
        {
            //Zolang onze zoek positie niet de lente van de zoektext is kunnen we zoeken, anders zitten we aan t einde en geven we een -1
            if (ZoekPositie != rtbZoek.Text.Length)
                ZoekPositie = rtbZoek.Find(zoekText, ZoekPositie, rtbZoek.Text.Length, rtbF);
            else
                ZoekPositie = -1;

            //Als onze index niet -1 is hebben we iets gevonden, de index heeft dan het nummer van de start positie van het woord
            if (ZoekPositie != -1)
            {
                //Selecteer dit woord vanaf de ZoekPositie(start) tot en met de lengte van onze zoektext
                rtbZoek.Select(ZoekPositie, zoekText.Length);
                //Zorg ervoor dat onze ZoekPositie vermeerderd word
                ZoekPositie += zoekText.Length;
            }
            else
            {
                MessageBox.Show(string.Format("Kan {0} niet vinden", zoekText));
                ZoekPositie = 0;
                Gevonden = false;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
