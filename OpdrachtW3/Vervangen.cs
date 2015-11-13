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
    public partial class Vervangen : Form
    {
        //RichTextBox waarin we gaan zoeken
        RichTextBox rtbZoek;

        int ZoekPositie = 0;
        bool Gevonden = true;

        public Vervangen(RichTextBox richbox)
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
            if (ZoekPositie != rtbZoek.Text.Length && ZoekPositie <= rtbZoek.Text.Length)
            {
                ZoekPositie = rtbZoek.Find(zoekText, ZoekPositie, rtbZoek.Text.Length, rtbF);
            }
            else
                ZoekPositie = -1;

            //Als onze index niet -1 is hebben we iets gevonden, de index heeft dan het nummer van de start positie van het woord
            if (ZoekPositie != -1)
            {
                //Selecteer dit woord vanaf de ZoekPositie(start) tot en met de lengte van onze zoektext
                rtbZoek.Select(ZoekPositie, zoekText.Length);
                //ZoekPositie += zoekText.Length;
                string SubSone = rtbZoek.Text.Substring(0, ZoekPositie);
                string SubStwo = rtbZoek.Text.Substring(ZoekPositie + zoekText.Length);
                rtbZoek.Text = SubSone + vervangText + SubStwo;
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

        public void VervangAlles(string zoekText, string vervangText, RichTextBoxFinds rtbF)
        {
            //Zoek alles, zolang de index niet -1 is hebben we iets gevonden
            while (ZoekPositie != -1)
            {
                //Zolang onze zoek positie niet de lente van de zoektext is kunnen we zoeken, anders zitten we aan t einde en geven we een -1
                if (ZoekPositie != rtbZoek.Text.Length && ZoekPositie <= rtbZoek.Text.Length)
                {
                    ZoekPositie = rtbZoek.Find(zoekText, ZoekPositie, rtbZoek.Text.Length, rtbF);
                }
                else
                {
                    ZoekPositie = -1;
                }
                //Als onze index niet -1 is hebben we iets gevonden, de index heeft dan het nummer van de start positie van het woord
                if (ZoekPositie != -1)
                {
                    //Selecteer dit woord vanaf de ZoekPositie(start) tot en met de lengte van onze zoektext
                    rtbZoek.Select(ZoekPositie, zoekText.Length);
                    //We hebben de tekst die vervangen moet worden geselecteerd, replace
                    rtbZoek.SelectedText.Replace(rtbZoek.SelectedText, vervangText);
                    //Zorg ervoor dat we alles wat voor onze zoek positie stond bewaard blijft
                    string SubSone = rtbZoek.Text.Substring(0, ZoekPositie);
                    //Haal alle text na onze zoekpositie op
                    string SubStwo = rtbZoek.Text.Substring(ZoekPositie + zoekText.Length);
                    //Voeg de tekst voor, + de vervangende tekst + de tekst erna samen
                    rtbZoek.Text = SubSone + vervangText + SubStwo;
                    //Zorg ervoor dat onze ZoekPositie vermeerderd word
                    ZoekPositie += zoekText.Length;
                }
                else
                {
                    Gevonden = false;
                }
            }
            //We zijn uit de loop, nu kunnen we onze zoekpositie weer op 0 zetten
            ZoekPositie = 0;
        }

        private void btnVervang_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds rtbF = RichTextBoxFinds.None;
            if (ckbHeelWoord.Checked)
                rtbF |= RichTextBoxFinds.WholeWord;
            if (ckbIdent.Checked)
                rtbF |= RichTextBoxFinds.MatchCase;

            Vervang(txtSearch.Text, txtReplace.Text, rtbF);
        }

        private void btnVervangAlles_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds rtbF = RichTextBoxFinds.None;
            if (ckbHeelWoord.Checked)
                rtbF |= RichTextBoxFinds.WholeWord;
            if (ckbIdent.Checked)
                rtbF |= RichTextBoxFinds.MatchCase;

            VervangAlles(txtSearch.Text, txtReplace.Text, rtbF);
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
