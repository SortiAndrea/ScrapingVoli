using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ScrapySharp.Extensions;
using System.Net;
using System.Diagnostics;

namespace ScrapingVoli
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();

        Dictionary<string, string> airports = new Dictionary<string, string>();
        private string partenzaAeroporto;
        private string airportCode;

        private int budget;
        private string tipoViaggio;

        public Form1()
        {
            InitializeComponent();

            // Aggiungi il gestore dell'evento SelectedIndexChanged alla ListView
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            // Nascondi la ListView all'inizio
            listView1.Visible = false;

            // Associa l'evento del clic alla TextBox
            txtPartenza.Click += new EventHandler(textBox2_Click);

            cbBudget.SelectedIndexChanged += new EventHandler(cbBudget_SelectedIndexChanged_1);


            cbCategoria.SelectedIndexChanged += new EventHandler(cbCategoria_SelectedIndexChanged);



            rbSpecifica.Visible = false;

            rbIntervallo.Visible = false;
            panelPartenza.Visible = false;


            txtPartenza.Click += new EventHandler(txtPartenza_Click);

            rbSpecifica.CheckedChanged += new EventHandler(rbSpecifica_CheckedChanged);
            rbIntervallo.CheckedChanged += new EventHandler(rbIntervallo_CheckedChanged);

            dtPartenza.Visible = false;
            dtRitorno.Visible = false;
        }

        private struct programmazione
        {
            public string canale;
            public string titolo;
            public string orario;
            public string descrizione;

            public override string ToString()
            {
                return $"{orario} * {canale} * {titolo} * {descrizione}";
            }


        }
        List<programmazione> elencoProgrammi = new List<programmazione>();
        programmazione programmaAttuale;

        private int num = 0;

        public void PopulateAirports()
        {
            // Aggiungi gli aeroporti e i relativi codici al dizionario

            airports.Add("Heathrow (Londra, Regno Unito)", "LHR");
            airports.Add("Gatwick (Londra, Regno Unito)", "LGW");
            airports.Add("Stansted (Londra, Regno Unito)", "STN");
            airports.Add("Charles de Gaulle (Parigi, Francia)", "CDG");
            airports.Add("Orly (Parigi, Francia)", "ORY");
            airports.Add("Francoforte (Germania)", "FRA");
            airports.Add("Monaco di Baviera (Germania)", "MUC");
            airports.Add("Schiphol (Amsterdam, Paesi Bassi)", "AMS");
            airports.Add("Madrid-Barajas (Madrid, Spagna)", "MAD");
            airports.Add("Barcellona-El Prat (Barcellona, Spagna)", "BCN");
            airports.Add("Fiumicino (Roma, Italia)", "FCO");
            airports.Add("Malpensa (Milano, Italia)", "MXP");
            airports.Add("Eleftherios Venizelos (Atene, Grecia)", "ATH");
            airports.Add("Portela (Lisbona, Portogallo)", "LIS");
            airports.Add("Dublino (Irlanda)", "DUB");
            airports.Add("Nationale (Bruxelles, Belgio)", "BRU");
            airports.Add("Kastrup (Copenaghen, Danimarca)", "CPH");
            airports.Add("Arlanda (Stoccolma, Svezia)", "ARN");
            airports.Add("Bromma (Stoccolma, Svezia)", "BMA");
            // Aggiungi altri aeroporti secondo necessità
        }

        public void InitializeListView()
        {
            // Imposta le proprietà della ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Aggiungi le colonne alla ListView
            listView1.Columns.Add("Aeroporto", 200);
            listView1.Columns.Add("Codice", 100);

            // Popola la ListView con gli aeroporti e i codici
            foreach (var airport in airports)
            {
                ListViewItem item = new ListViewItem(airport.Key);
                item.SubItems.Add(airport.Value);
                listView1.Items.Add(item);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Mostra il testo selezionato nella TextBox
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
            }

        }

        private void cbBudget_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verifica se è selezionato l'elemento "50"
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "20")
            {
                // Imposta il valore della variabile a 50
                budget = 20;

            }
            // Verifica se è selezionato l'elemento "50"
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "50")
            {
                // Imposta il valore della variabile a 50
                budget = 50;
            }
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "60")
            {
                // Imposta il valore della variabile a 50
                budget = 60;
            }

            // Verifica se è selezionato l'elemento "50"
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "80")
            {
                // Imposta il valore della variabile a 50
                budget = 80;
            }
            // Verifica se è selezionato l'elemento "50"
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "100")
            {
                // Imposta il valore della variabile a 50
                budget = 100;
            }
            // Verifica se è selezionato l'elemento "50"
            if (cbBudget.SelectedItem != null && cbBudget.SelectedItem.ToString() == "150")
            {
                // Imposta il valore della variabile a 50
                budget = 150;
            }
        }

        private void dtPartenza_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtPartenza.Value;

            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void dtRitorno_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate2 = dtRitorno.Value;

            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == "CITTA'")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "CTY";

            }
            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == "FAMIGLIA")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "FAM";

            }
            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == "GOLF")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "GLF";


            }
            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == "VITA NOTTURNA")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "NIT";

            }
            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == " ALL'APERTO")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "OUT";

            }

            if (cbCategoria.SelectedItem != null && cbCategoria.SelectedItem.ToString() == "MARE")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "SEA";
            }
        }

        private void rbSpecifica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSpecifica.Checked)
            {
                dtPartenza.Visible = true;

            }
        }

        private void rbIntervallo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntervallo.Checked)
            {
                dtPartenza.Visible = true;
                dtRitorno.Visible = true;

            }
            else
            {
                dtRitorno.Visible = false;
            }
        }

        private void btnVolo_Click(object sender, EventArgs e)
        {
            //ANDATA
            DateTime selectedDate = dtPartenza.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate); // Aggiungi questa linea per il debug
            string message = $"La data formattata è: {formattedDate}";
            // MessageBox.Show(message, "Data Formattata", MessageBoxButtons.OK, MessageBoxIcon.Information);






            //RITORNO
            DateTime selectedDate2 = dtRitorno.Value;
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate2); // Aggiungi questa linea per il debug
            string message2 = $"La data formattata è: {formattedDate2}";
            // MessageBox.Show(message2, "Data Formattata", MessageBoxButtons.OK, MessageBoxIcon.Information);





            // Verifica se è stato selezionato un aeroporto
            if (listView1.SelectedItems.Count > 0)
            {
                // Ottieni il nome e il codice dell'aeroporto selezionato
                partenzaAeroporto = listView1.SelectedItems[0].Text;
                airportCode = listView1.SelectedItems[0].SubItems[1].Text;

            }
            else
            {
                MessageBox.Show("Seleziona un aeroporto prima di procedere.");
            }
            //  string message3 = $"Informazioni:\nPartenza: {airportCode}\nBudget: {budget}\nData di Andata: {formattedDate}\nData di Ritorno: {formattedDate2}";
            // MessageBox.Show(message3, "Dettagli Viaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget={budget}&trip-type-category={tipoViaggio}");

            txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget={budget}&trip-type-category={tipoViaggio}";
            Process.Start(txtLink.Text);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private async void btnCartina_Click(object sender, EventArgs e)
        {
            var luogo = textBox1.Text;
            string urlCartina = $"https://www.google.com/search?q={luogo}+cartina&tbm=isch&source=lnms";
            textBox1.Text = urlCartina;

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            WebPage webpage = await browser.NavigateToPageAsync(new Uri(urlCartina));

            //rg_i

            //var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("div.BnJWBc").ToList();
            var html = webpage.Html.OwnerDocument.DocumentNode.CssSelect("html").First().InnerHtml;

            System.IO.File.WriteAllText(@"test.html", html);

            var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.H8Rx8c").ToList();
            var urlImg = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.H8Rx8c").First().GetAttributeValue("src");



            var request = WebRequest.Create(urlImg);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream);
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------

        private void btnMeteo_Click_1(object sender, EventArgs e)
        {
            var luogo = textBox1.Text;
            string url = $"https://www.3bmeteo.com/meteo/{luogo}";

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Massimizza la finestra del browser
            IWebDriver driver = new ChromeDriver(options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl($"https://www.3bmeteo.com/meteo/{luogo}");

            try
            {
                // Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione
                var buttonMeteo = driver.FindElement(By.CssSelector("div#iubenda-cs-banner"));
                var buttonMeteo1 = buttonMeteo.FindElement(By.CssSelector("div.iubenda-cs-container"));
                var buttonMeteo2 = buttonMeteo1.FindElement(By.CssSelector("div.iubenda-cs-content"));
                var buttonMeteo3 = buttonMeteo2.FindElement(By.CssSelector("div.iubenda-cs-rationale"));
                var buttonMeteo4 = buttonMeteo3.FindElement(By.CssSelector("div.iubenda-cs-opt-group"));
                var buttonMeteo5 = buttonMeteo4.FindElement(By.CssSelector("div.iubenda-cs-opt-group-consent"));
                var buttonMeteo6 = buttonMeteo5.FindElement(By.CssSelector("button.iubenda-cs-accept-btn"));


                // Esegui il clic sul bottone
                buttonMeteo6.Click();

                IWebElement divElement = driver.FindElement(By.XPath("//div[@id='wrapper']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//section[@id='main']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='box noMarg']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div


                // Ora puoi catturare uno screenshot del quinto figlio div
                Screenshot screenshot = ((ITakesScreenshot)child1).GetScreenshot();
                screenshot.SaveAsFile($"div_screenshot{num}.png");
            }

            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }

            finally
            {
                // Chiudi il WebDriver
                driver.Quit();
                pictureBox2.Image = Image.FromFile($"div_screenshot{num}.png");

                num++;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------
        
        private void btnIndicazioni_Click_1(object sender, EventArgs e)
        {
            var luogo = textBox1.Text;
            string url = $"https://www.travel365.it/destinazioni/europa/italia/lombardia/{luogo}/";

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Massimizza la finestra del browser
            IWebDriver driver = new ChromeDriver(options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl($"https://www.travel365.it/destinazioni/europa/italia/lombardia/{luogo}/");

            try
            {
                // Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione

                var buttonIndicazioni = driver.FindElement(By.CssSelector("div.fc-consent-root"));
                var buttonIndicazioni1 = buttonIndicazioni.FindElement(By.CssSelector("div.fc-dialog-container"));
                var buttonIndicazioni2 = buttonIndicazioni1.FindElement(By.CssSelector("div.fc-dialog"));
                var buttonIndicazioni3 = buttonIndicazioni2.FindElement(By.CssSelector("div.fc-footer-buttons-container"));
                var buttonIndicazioni4 = buttonIndicazioni3.FindElement(By.CssSelector("div.fc-footer-buttons"));
                var buttonIndicazioni5 = buttonIndicazioni4.FindElement(By.CssSelector("button.fc-button"));


                // Esegui il clic sul bottone
                buttonIndicazioni5.Click();

                IWebElement divElement = driver.FindElement(By.XPath("//div[@id='content']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//div[@id='pagecity']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='stickycontainer']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child2 = child1.FindElement(By.XPath(".//div[@class='transport']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div

                // Ora puoi catturare uno screenshot del quinto figlio div
                Screenshot screenshot = ((ITakesScreenshot)child2).GetScreenshot();
                screenshot.SaveAsFile($"div_screenshot{num}.png");
            }

            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }

            finally
            {
                // Chiudi il WebDriver
                driver.Quit();
                pictureBox3.Image = Image.FromFile($"div_screenshot{num}.png");

                num++;
            }
        }

        private void txtPartenza_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------




    }
}
