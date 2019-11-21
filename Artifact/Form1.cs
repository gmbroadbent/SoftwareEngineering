using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// PM> Install-Package NewsAPI
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

// PM> Install-Package SpotifyAPI.Web
// PM> Install-Package SpotifyAPI.Web.Auth
/*using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;*/


namespace SE
{
    public partial class Form1 : Form
    {

        private NewsApiClient APIn;
        private List<string> Headlines = new List<string>();
        //private SpotifyWebAPI APIs;

        public Form1()
        {
            InitializeComponent();


            label1.Text = "Program Start";

            SetDefaults();
            SetUp();


            if (!ValidateNewsAPI())
            {

                TextBox.Text = "News API failed validation\nCheck credentials";

                Disable();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public bool ValidateNewsAPI()
        {
            /*
             * Fetches NewsAPI credentials to create new client
             */

            Console.WriteLine("Validating News API");
            label1.Text = label1.Text + "\nValidating News API";

            string API_key = "";
            string path = FindCredentials();

            label1.Text += "\nAPI key path: " + path;

            if (File.Exists(path))
            {
                API_key = File.ReadLines(path).Skip(0).Take(1).First();
                label1.Text = label1.Text + "\nAPI Key aquired";
            }
            else
            {
                label1.Text = label1.Text + "\nERROR: No news credentials found";
                return false;
            }

            APIn = new NewsApiClient(API_key);
            label1.Text = label1.Text + "\nAPI client created";

            return true;

            //return API;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "\nButton Clicked";

            TopHeadlinesRequest request = GenerateHeadlinesRequest();
            var response = await APIn.GetTopHeadlinesAsync(request);

            label1.Text += label1.Text + "\nResponse recieved";

            if (response.Status == Statuses.Ok)
            {
                Console.WriteLine("Responses: " + response.TotalResults);
                label1.Text += ("Responses: " + response.TotalResults);

                foreach (var article in response.Articles)
                {
                    /*
                    Console.WriteLine("Title: {0} - ({1})", article.Title, article.PublishedAt);
                    Console.WriteLine("Author: {0}", article.Author);
                    Console.WriteLine("Description: {0}", article.Description);
                    */

                    string txt = "";
                    txt += "Title: " + article.Title;
                    txt += "\nPublished: " + article.PublishedAt;
                    txt += "\nAuthor: " + article.Author;
                    txt += "\nDescription: " + article.Description;
                    txt += "\nSource: " + article.Source.Name + "\n\n";

                    TextBox.Text += txt;


                    if (article.Title.Length > 5)
                    {
                        Headlines.Add(article.Title);
                    }
                }
            }
            else
            {
                label1.Text = label1.Text + "\nError fetching data" + response.Error.Code;
                label1.Text = label1.Text + "\n\t" + response.Error.Message;

                TextBox.Text = label1.Text + "\nError fetching data" + response.Error.Code;
                TextBox.Text = label1.Text + "\n\t" + response.Error.Message;
            }


            label1.Text = label1.Text + "\nButton push end";


        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (Check_ToDate.Checked) { ToDate.Enabled = true; }
            else { ToDate.Enabled = false; }

        }

        private void Check_FromDate_CheckedChanged(object sender, EventArgs e)
        {

            if (Check_FromDate.Checked) { FromDate.Enabled = true; }
            else { FromDate.Enabled = false; }

        }

        private void Check_Country_CheckedChanged(object sender, EventArgs e)
        {

            if (Check_Country.Checked) { Country.Enabled = true; }
            else { Country.Enabled = false; }

        }




        private string FindCredentials()
        {
            /*
             * Looks through available drives to find folder containing NewsAPI credentials
            */

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives)
            {
                if (d.IsReady)
                {
                    string Path = d.RootDirectory + @"SE\credentials.txt";

                    if (File.Exists(Path))
                    {
                        return Path;
                    }
                }
            }

            return "";

        }

        private void SetDefaults()
        {
            /*
             * Sets default values for options
             * Sets minimum and maximum date values according to NewsAPI constraints
             */

            ToDate.MaxDate = DateTime.Now;
            ToDate.MinDate = DateTime.Now.AddMonths(-1);
            ToDate.Value = ToDate.MaxDate;

            FromDate.MaxDate = DateTime.Now.AddDays(-1);
            FromDate.MinDate = DateTime.Now.AddMonths(-1);
            FromDate.Value = FromDate.MinDate;

            Check_ToDate.Checked = true;
            Check_FromDate.Checked = true;
            Check_Country.Checked = true;
            Check_Catagory.Checked = true;

            Country.SelectedItem = "UK";

            Catagory.SelectedItem = "General";

        }


        private EverythingRequest GenerateEverythingRequest() 
        {
            /*
             *  Creates Everything Request between selected dates
            */

            EverythingRequest request = new EverythingRequest();

            request.Q = "spotify";
            request.Language = Languages.EN;
            request.SortBy = SortBys.PublishedAt;

            if(Check_ToDate.Enabled && Check_FromDate.Enabled)
            {
                if (ToDate.Value.Date < FromDate.Value.Date)
                {
                    ToDate.Value = ToDate.MaxDate;
                }
            }

            if (Check_FromDate.Checked){ request.From = FromDate.Value.Date; }
            if (Check_ToDate.Checked){ request.To = ToDate.Value.Date; }

            return request;

        }

        private TopHeadlinesRequest GenerateHeadlinesRequest()
        {
            /*
             *  Creates Headlines Request based on menu selection
            */

            TopHeadlinesRequest request = new TopHeadlinesRequest();


            if(Check_Country.Checked)
            {
                switch(Country.SelectedItem.ToString().ToUpper())
                {
                    case ("UAE"): request.Country = Countries.AE; break;
                    case ("ARGENTINA"): request.Country = Countries.AR; break;
                    case ("AUSTRIA"): request.Country = Countries.AT; break;
                    case ("AUSTRALIA"): request.Country = Countries.AU; break;
                    case ("BELGIUM"): request.Country = Countries.BE; break;
                    case ("BULGARIA"): request.Country = Countries.BG; break;
                    case ("BRAZIL"): request.Country = Countries.BR; break;
                    case ("CANADA"): request.Country = Countries.CA; break;
                    case ("SWITZERLAND"): request.Country = Countries.CH; break;
                    case ("CHINA"): request.Country = Countries.CN; break;
                    case ("COLUMBIA"): request.Country = Countries.CO; break;
                    case ("CUBA"): request.Country = Countries.CU; break;
                    case ("CZECHIA"): request.Country = Countries.CZ; break;
                    case ("GERMANY"): request.Country = Countries.DE; break;
                    case ("EGYPT"): request.Country = Countries.EG; break;
                    case ("FRANCE"): request.Country = Countries.FR; break;
                    case ("UK"): request.Country = Countries.GB; break;
                    case ("GREECE"): request.Country = Countries.GR; break;
                    case ("HONG KONG"): request.Country = Countries.HK; break;
                    case ("HUNGARY"): request.Country = Countries.HU; break;
                    case ("INDONESIA"): request.Country = Countries.ID; break;
                    case ("IRELAND"): request.Country = Countries.IE; break;
                    case ("ISRAEL"): request.Country = Countries.IL; break;
                    case ("INDIA"): request.Country = Countries.IN; break;
                    case ("ITALY"): request.Country = Countries.IT; break;
                    case ("JAPAN"): request.Country = Countries.JP; break;
                    case ("KOREA"): request.Country = Countries.KR; break;
                    case ("LITHUANIA"): request.Country = Countries.LT; break;
                    case ("LATVIA"): request.Country = Countries.LV; break;
                    case ("MOROCCO"): request.Country = Countries.MA; break;
                    case ("MEXICO"): request.Country = Countries.MX; break;
                    case ("MALAYSIA"): request.Country = Countries.MY; break;
                    case ("NIGERIA"): request.Country = Countries.NG; break;
                    case ("NETHERLANDS"): request.Country = Countries.NL; break;
                    case ("NORWAY"): request.Country = Countries.NO; break;
                    case ("NEW ZEALAND"): request.Country = Countries.NZ; break;
                    case ("PHILIPPINES"): request.Country = Countries.PH; break;
                    case ("POLAND"): request.Country = Countries.PL; break;
                    case ("PORTUGAL"): request.Country = Countries.PT; break;
                    case ("ROMANIA"): request.Country = Countries.RO; break;
                    case ("SERBIA"): request.Country = Countries.RS; break;
                    case ("RUSSIA"): request.Country = Countries.RU; break;
                    case ("SAUDI ARABIA"): request.Country = Countries.SA; break;
                    case ("SWEDEN"): request.Country = Countries.SE; break;
                    case ("SLOVENIA"): request.Country = Countries.SI; break;
                    case ("SLOVAKIA"): request.Country = Countries.SK; break;
                    case ("THAILAND"): request.Country = Countries.TH; break;
                    case ("TURKEY"): request.Country = Countries.TR; break;
                    case ("TAIWAN"): request.Country = Countries.TW; break;
                    case ("UKRAINE"): request.Country = Countries.UA; break;
                    case ("US"): request.Country = Countries.US; break;
                    case ("VENEZUELA"): request.Country = Countries.VE; break;
                    case ("SOUTH AFRICA"): request.Country = Countries.ZA; break;
                    default: request.Country = Countries.GB; break;
                }
            }

            if(Check_Catagory.Checked)
            {

                switch (Catagory.SelectedItem.ToString().ToUpper())
                {
                    case ("BUSINESS"): request.Category = Categories.Business; break;
                    case ("ENTERTAINMENT"): request.Category = Categories.Entertainment; break;
                    case ("HEALTH"): request.Category = Categories.Health; break;
                    case ("SCIENCE"): request.Category = Categories.Science; break;
                    case ("SPORTS"): request.Category = Categories.Sports; break;
                    case ("TECHNOLOGY"): request.Category = Categories.Technology; break;
                    default: request.Category = Categories.Technology; break;
                }

            }


            return request;

        }


        private void Disable()
        {
            /*
             *  If NewsAPI credentials fail validation, user prevented from doing anything but exiting
            */

            button1.Enabled = false;

            FromDate.Enabled = false;
            ToDate.Enabled = false;

            TextBox.Enabled = false;

            Check_FromDate.Enabled = false;
            Check_ToDate.Enabled = false;
            Check_Country.Enabled = false;
            Check_Catagory.Enabled = false;

            Country.Enabled = false;

            Catagory.Enabled = false;

        }

        private void ExportHeadlines()
        {
            /*
             *  Sends headlines to file for Python to read and use for Spotify API
            */

            string path = @"Headlines.txt";

            StreamWriter writer = new StreamWriter(path);

            foreach (string headline in Headlines)
            {
                writer.WriteLine(headline);
                Console.WriteLine(headline);
            }

            writer.Close();

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {

            if(Headlines.Count != 0)
            {
                ExportHeadlines();
            }

        }

        private void SetUp()
        {
            /*
             *  Ensures that 'Headlines' file exists before required
             *  File needs to be somewhere accessable by Python
            */

            string path = @"Headlines.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
