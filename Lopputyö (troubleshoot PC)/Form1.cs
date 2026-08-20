using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PCTroubleshooter
{
    public partial class Form1 : Form
    {
        private int currentQuestion;
        private readonly string historyFilePath = Path.Combine(Application.StartupPath, "historia.txt");

        private void Savetohistory(string problem)
        {
            string rivi = DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " - " + problem;
            File.AppendAllText(historyFilePath, rivi + Environment.NewLine);
        }

        public Form1()
        {
            InitializeComponent();

            Button[] buttons = {btnDoesNotStart, btnOverheats, btnIsSlow, btnNoInternet, btnNoDisplay, btnAnswerYes, btnAnswerNo, btnBack, btnResultBack, btnidontknow, btnHistory }; // Napit, joissa tyyli vaihdettu koodilla

            foreach (Button button in buttons) // Tässä käytetty foreach rakennetta
            {
                FormatButton(button);
            }
        }

        private void btnDoesNotStart_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelQuestion.Visible = true;
            currentQuestion = 1;
            lblQuestion.Text = "Tapahtuuko virtanappia painettaessa mitään?";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelQuestion.Visible = false;
            panelMainMenu.Visible = true;
        }

        private void btnTulosTakaisin_Click(object sender, EventArgs e)
        {
            panelAnswer.Visible = false;
            panelMainMenu.Visible = true;
        }

        private void btnVastaus1_Click(object sender, EventArgs e) // Kyllä haarakkeet, niiden kysymykset ja vastaukset
        {
            switch (currentQuestion) // Tässä käytetty switch rakennetta
            {
                case 1:
                    currentQuestion = 5;
                    lblQuestion.Text = "Tuleeko näyttöön kuva?";
                    break;

                case 2:
                    currentQuestion = 3;
                    lblQuestion.Text = "Onko virtalähteen takana oleva virtakytkin käännetty päälle-asentoon (I)?";
                    break;

                case 3:
                    currentQuestion = 4;
                    lblQuestion.Text = "Tarkista pistorasia. Toimiiko pistorasia (esim. toisella laitteella testattuna)?";
                    break;

                case 4:
                    ShowResult(
                        "Virtalähde saattaa olla viallinen",
                        "Tarkista virtalähteen kaikki liitännät (emolevyyn, prosessoriin, kiintolevyihin jne.) ja varmista että ne ovat kunnolla kiinni. Jos tietokone ei silti käynnisty, virtalähde on todennäköisesti viallinen ja kannattaa vaihtaa."
                    );
                    break;

                case 5:
                    ShowResult(
                        "Ei havaittua ongelmaa tässä vaiheessa",
                        "Tietokone käynnistyy ja näyttää kuvaa normaalisti. Vika saattaa olla jossain muualla - kokeile tarvittaessa muita vianmäärityksiä."
                    );
                    break;

                case 6:
                    currentQuestion = 7;
                    lblQuestion.Text = "Pyörivätkö kaikki tuulettimet normaalisti (kuuletko/näetkö niiden pyörivän)?";
                    break;

                case 7:
                    currentQuestion = 8;
                    lblQuestion.Text = "Onko tietokone sijoitettu ahtaaseen tilaan tai lähelle lämmönlähdettä/suoraa auringonvaloa?";
                    break;

                case 8:
                    ShowResult(
                        "Huono sijoituspaikka",
                        "Siirrä tietokone paremmin tuuletettuun paikkaan, pois suorasta auringonvalosta ja lämmönlähteistä."
                    );
                    break;

                case 9:
                    ShowResult(
                        "Kuivunut lämpötahna",
                        "Lämpötahna kuivuu ajan myötä ja heikentää jäähdytystä. Vaihdata tai vaihda itse suorittimen/näytönohjaimen lämpötahna."
                    );
                    break;

                case 10:
                    ShowResult(
                        "Liikaa taustalla käynnistyviä ohjelmia",
                        "Avaa Tehtävienhallinta (Ctrl+Shift+Esc) ja poista tarpeettomat ohjelmat käynnistyksestä Käynnistys-välilehdeltä. Sulje myös taustalla turhaan pyörivät ohjelmat."
                    );
                    break;

                case 11:
                    currentQuestion = 12;
                    lblQuestion.Text = "Onko koneella ajantasainen virustorjunta ja oletko ajanut haittaohjelmatarkistuksen viime aikoina?";
                    break;

                case 12:
                    currentQuestion = 13;
                    lblQuestion.Text = "Onko koneessa perinteinen kiintolevy (HDD) SSD:n sijaan, tai onko laitteisto/käyttöjärjestelmä yli 5-6 vuotta vanha?";
                    break;

                case 13:
                    ShowResult(
                        "Vanhentunut laitteisto",
                        "Perinteinen HDD-kiintolevy tai vanha laitteisto hidastaa tietokonetta merkittävästi. Harkitse siirtymistä SSD-levylle, joka nopeuttaa konetta huomattavasti."
                    );
                    break;
                case 14:
                    currentQuestion = 15;
                    lblQuestion.Text = "Toimiiko internet muilla laitteilla samassa verkossa?";
                    break;

                case 15:
                    ShowResult(
                        "Ongelma vaikuttaa liittyvän vain tähän tietokoneeseen",
                        "Koska internet toimii muilla laitteilla, reititin ja internet-yhteys itsessään ovat kunnossa. Tarkista tämän tietokoneen verkkosovittimen asetukset ja ajurit, tai kokeile käynnistää tietokone uudelleen."
                    );
                    break;

                case 16:
                    currentQuestion = 17;
                    lblQuestion.Text = "Toimiiko internet nyt?";
                    break;

                case 17:
                    ShowResult(
                        "Internet-yhteys toimii",
                        "Internet-yhteys toimii tällä hetkellä. Ongelma vaikuttaa olevan korjaantunut."
                    );
                    break;

                case 18:
                    ShowResult(
                        "Verkkoyhteydessä voi olla asetuksiin liittyvä ongelma",
                        "Kokeile Windowsin verkkovianmääritystä ja tarkista verkkosovittimen asetukset."
                    );
                    break;

                case 19:
                    currentQuestion = 20;
                    lblQuestion.Text = "Onko näyttökaapeli (HDMI/DisplayPort) kunnolla kiinni?";
                    break;

                case 20:
                    currentQuestion = 21;
                    lblQuestion.Text = "Näkyykö näytössä \"No Signal\" / \"Ei signaalia\" -ilmoitus?";
                    break;

                case 21:
                    currentQuestion = 22;
                    lblQuestion.Text = "Onko näyttökaapeli kytketty näytönohjaimeen eikä emolevyn liitäntään?";
                    break;

                case 22:
                    currentQuestion = 23;
                    lblQuestion.Text = "Oletko kokeillut toista HDMI/DisplayPort-kaapelia tai toista näyttöä?";
                    break;

                case 23:
                    ShowResult(
                        "Mahdollinen laitteistovika",
                        "Jos kaapelit ja näyttö toimivat, vika voi olla näytönohjaimessa tai muussa tietokoneen laitteistossa."
                    );
                    break;
            }
        }

        private void btnVastaus2_Click(object sender, EventArgs e) // Ei haarakkeet, niiden kysymykset ja vastaukset
        {
            switch (currentQuestion)
            {
                case 1:
                    currentQuestion = 2;
                    lblQuestion.Text = "Tarkista virtajohto. Onko se kunnolla kiinni sekä tietokoneessa että pistorasiassa?";
                    break;

                case 2:
                    ShowResult(
                        "Virtajohto ei ollut kunnolla kiinni",
                        "Kytke virtajohto tiukasti kiinni sekä tietokoneeseen että pistorasiaan ja yritä käynnistää uudelleen."
                    );
                    break;

                case 3:
                    ShowResult(
                        "Virtalähteen kytkin oli pois päältä",
                        "Käännä virtalähteen takana oleva kytkin päälle-asentoon (I) ja yritä käynnistää uudelleen."
                    );
                    break;

                case 4:
                    ShowResult(
                        "Pistorasia on rikki",
                        "Kokeile toista pistorasiaa. Jos ongelma jatkuu muissakin pistorasioissa, ota yhteyttä sähköasentajaan."
                    );
                    break;

                case 5:
                    ShowResult(
                        "Näyttökaapeli ei ole kunnolla kiinni",
                        "Tarkista näyttökaapeli ja varmista, että se on kunnolla kiinni sekä tietokoneessa että näytössä."
                    );
                    break;

                case 6:
                    ShowResult(
                        "Pölyiset tuuletusaukot",
                        "Puhdista tietokoneen tuuletusaukot ja sisäosat pölystä paineilmalla tai pehmeällä siveltimellä. Tämä parantaa ilmankiertoa merkittävästi."
                    );
                    break;

                case 7:
                    ShowResult(
                        "Tuuletin ei toimi kunnolla",
                        "Tarkista, onko jokin tuuletin jumissa tai rikki. Vaihda viallinen tuuletin tarvittaessa."
                    );
                    break;

                case 8:
                    currentQuestion = 9;
                    lblQuestion.Text = "Onko tietokone yli 3 vuotta vanha ilman huoltoa (lämpötahna todennäköisesti kuivunut)?";
                    break;

                case 9:
                    ShowResult(
                        "Mahdollinen taustaprosessi tai jäähdytysjärjestelmän vika",
                        "Tarkista Tehtävienhallinnasta, ajaako jokin ohjelma prosessoria tai näytönohjainta täydellä teholla taustalla. Jos ei, jäähdytysjärjestelmä voi olla viallinen ja kannattaa tarkistuttaa huollossa."
                    );
                    break;

                case 10:
                    currentQuestion = 11;
                    lblQuestion.Text = "Onko kiintolevyllä (C-asemalla) riittävästi vapaata tallennustilaa (esim. yli 10-15%)?";
                    break;

                case 11:
                    ShowResult(
                        "Kiintolevy lähes täynnä",
                        "Poista tarpeettomia tiedostoja, tyhjennä roskakori ja poista turhia ohjelmia. Kiintolevyn täyttyminen hidastaa tietokonetta merkittävästi."
                    );
                    break;

                case 12:
                    ShowResult(
                        "Mahdollinen haittaohjelma",
                        "Aja täydellinen virus- ja haittaohjelmatarkistus ajantasaisella virustorjuntaohjelmalla. Asenna virustorjunta, jos sitä ei vielä ole."
                    );
                    break;

                case 13:
                    ShowResult(
                        "Mahdollinen käyttöjärjestelmän vika",
                        "Tarkista, että käyttöjärjestelmä ja ajurit ovat päivitetty uusimpaan versioon. Jos ongelma jatkuu, harkitse käyttöjärjestelmän uudelleenasennusta."
                    );
                    break;
                case 14:
                    ShowResult(
                        "Tietokone ei ole yhdistetty verkkoon",
                        "Yhdistä tietokone Wi-Fi-verkkoon tai kytke verkkokaapeli kunnolla kiinni."
                    );
                    break;

                case 15:
                    currentQuestion = 16;
                    lblQuestion.Text = "Oletko käynnistänyt reitittimen uudelleen?";
                    break;

                case 16:
                    ShowResult(
                        "Reititin kannattaa käynnistää uudelleen",
                        "Sammuta reititin, odota noin 30 sekuntia ja käynnistä se uudelleen. Odota tämän jälkeen noin 2 minuuttia."
                    );
                    break;

                case 17:
                    currentQuestion = 18;
                    lblQuestion.Text = "Näkyykö Windowsin verkkokuvakkeessa varoitusmerkki?";
                    break;

                case 18:
                    ShowResult(
                        "Windowsin verkkoyhteydessä voi olla ongelma",
                        "Kokeile Windowsin verkkovianmääritystä ja tarkista verkkosovittimen asetukset."
                    );
                    break;

                case 19:
                    ShowResult(
                        "Näyttö ei ole päällä",
                        "Paina näytön virtapainiketta ja varmista, että virtajohto on kunnolla kiinni."
                    );
                    break;

                case 20:
                    ShowResult(
                        "Näyttökaapeli ei ole kunnolla kiinni",
                        "Irrota HDMI/DisplayPort-kaapeli ja kytke se kunnolla takaisin sekä näyttöön että tietokoneeseen."
                    );
                    break;

                case 21:
                    currentQuestion = 23;
                    lblQuestion.Text = "Oletko kokeillut toista HDMI/DisplayPort-kaapelia tai toista näyttöä?";
                    break;

                case 22:
                    ShowResult(
                        "Näyttökaapeli on väärässä liitännässä",
                        "Jos tietokoneessa on erillinen näytönohjain, kytke näyttökaapeli näytönohjaimen liitäntään."
                    );
                    break;

                case 23:
                    ShowResult(
                        "Kaapeli tai näyttö voi olla viallinen",
                        "Kokeile toista HDMI/DisplayPort-kaapelia tai toista näyttöä vian selvittämiseksi."
                    );
                    break;
            }
        }

        private void ShowResult(string problem, string solution) //Jokaisen ratkaisun loppuvaihe
        {
            panelQuestion.Visible = false;
            panelAnswer.Visible = true;
            lblProblem.Text = "Mahdollinen ongelma: " + problem;
            lblSolution.Text = "Ratkaisuehdotus: " + solution;

            Savetohistory(problem);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        private void btnOverheats_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelQuestion.Visible = true;
            currentQuestion = 6;
            lblQuestion.Text = "Onko tietokoneen tuuletusaukot puhtaat pölystä?";
        }
        private void btnIsSlow_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelQuestion.Visible = true;
            currentQuestion = 10;
            lblQuestion.Text = "Onko tietokoneella käynnissä paljon ohjelmia yhtä aikaa tai taustalla automaattisesti käynnistyviä ohjelmia?";
        }

        private void btnNoInternet_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelQuestion.Visible = true;
            currentQuestion = 14;
            lblQuestion.Text = "Onko Wi-Fi tai verkkokaapeli yhdistetty tietokoneeseen?";
        }

        private void btnNoDisplay_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelQuestion.Visible = true;
            currentQuestion = 19;
            lblQuestion.Text = "Onko näyttö päällä?";
        }
        public static void FormatButton(Button button) // Koodi, jolla nappien tyylit vaihtuu
        {
            button.BackColor = Color.FromArgb(36, 41, 51);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Montserrat Medium", 9);
            button.Cursor = Cursors.Hand;
        }

        private void lblProblem_Click(object sender, EventArgs e)
        {

        }

        private void panelAnswer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnidontknow_Click(object sender, EventArgs e) // Jos käyttäjä painaa "en tiedä", niin sovellus antaa vinkin käyttäjälle.
        {
            string hint;

            switch (currentQuestion)
            {
                case 1: hint = "Paina virtanappia ja tarkkaile, syttyykö mikään valo, pyörivätkö tuulettimet tai kuuluuko ääniä kotelosta."; break;
                case 2: hint = "Katso silmämääräisesti, että virtajohto on tiukasti kiinni sekä tietokoneen takana olevassa liittimessä että pistorasiassa."; break;
                case 3: hint = "Etsi tietokoneen takaa virtalähteen kytkin (yleensä merkitty I/O-symbolilla) ja tarkista, että se on I-asennossa."; break;
                case 4: hint = "Kokeile samaan pistorasiaan jotain muuta laitetta, esimerkiksi lamppua tai puhelimen laturia, ja katso toimiiko se."; break;
                case 5: hint = "Katso, syttyykö näyttöön mitään kuvaa tai tekstiä käynnistyksen aikana."; break;
                case 6: hint = "Katso silmämääräisesti kotelon tuuletusaukkoja ja tuulettimien ritilöitä - näkyykö niissä pölykertymää?"; break;
                case 7: hint = "Kuuntele ja katso koneen sisään (kone käynnissä), pyörivätkö kaikki tuulettimet normaalisti."; break;
                case 8: hint = "Tarkista, onko koneen ympärillä riittävästi tilaa ilmanvaihdolle ja ettei se ole suorassa auringonvalossa tai lämpöpatterin lähellä."; break;
                case 9: hint = "Muista tai tarkista ostokuitista, kuinka vanha tietokone on ja onko sille tehty huoltoa, esim. lämpötahnan vaihto."; break;
                case 10: hint = "Avaa Tehtävienhallinta (Ctrl+Shift+Esc) ja katso Käynnistys- ja Prosessit-välilehdiltä, kuinka monta ohjelmaa on käynnissä."; break;
                case 11: hint = "Avaa Resurssienhallinta ja tarkista C-aseman vapaa tila - Windows näyttää sen palkkina asemakuvakkeen alla."; break;
                case 12: hint = "Tarkista Windows Security -sovelluksesta, onko virustorjunta käytössä ja päivitetty."; break;
                case 13: hint = "Tarkista tietokoneen tiedot kohdasta Asetukset > Järjestelmä > Tietoja, tai kysy ostotiedoista, minkälainen kiintolevy koneessa on ja kuinka vanha se on."; break;
                case 14: hint = "Tarkista näytön oikeasta alakulmasta Wi-Fi- tai verkkokuvaketta, tai katso onko verkkokaapeli fyysisesti kiinni tietokoneessa."; break;
                case 15: hint = "Kokeile avata jokin verkkosivu puhelimella tai toisella laitteella samassa Wi-Fi-verkossa."; break;
                case 16: hint = "Katso, oletko viimeisen puolen tunnin aikana sammuttanut ja käynnistänyt reitittimen/modeemin uudelleen."; break;
                case 17: hint = "Kokeile avata selaimella jokin verkkosivu ja katso, latautuuko se."; break;
                case 18: hint = "Katso tehtäväpalkin oikeasta alakulmasta verkkokuvaketta - näkyykö siinä keltainen huutomerkki tai punainen rasti?"; break;
                case 19: hint = "Tarkista, palaako näytön virtavalo ja onko näytön virtapainiketta painettu."; break;
                case 20: hint = "Tarkista silmämääräisesti kaapelin molemmat päät - näytöstä ja tietokoneesta."; break;
                case 21: hint = "Katso näytön ruutua muutaman sekunnin ajan käynnistyksen jälkeen - näkyykö siinä teksti-ilmoitus vai onko ruutu täysin musta/pimeä."; break;
                case 22: hint = "Jos tietokoneessa on erillinen näytönohjain, sen liitännät ovat yleensä tietokoneen takana alempana kuin emolevyn liitännät. Tarkista, kummasta kaapeli lähtee."; break;
                case 23: hint = "Jos sinulla on toinen kaapeli tai näyttö saatavilla, kokeile vaihtaa se ja katso, muuttuuko tilanne."; break;
                default: hint = "Tarkista asia parhaasi mukaan tai pyydä tarvittaessa apua toiselta henkilöltä."; break;
            }

            MessageBox.Show(hint, "Vinkki", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistory_Click(object sender, EventArgs e) // Historia nappi
        {
            FormHistory historyForm = new FormHistory();
            historyForm.ShowDialog();
        }
    }
}