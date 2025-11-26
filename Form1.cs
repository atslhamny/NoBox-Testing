using WebView2;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System;
using WebView2.DevTools.Dom;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using DesignNoBox;
using System.Net.Http;

namespace MyNoBoxWinForm
{
   public partial class MyNoBox : Form
   {
      int idLogs = 0;
      public bool IsStopped = false;
      WebView2DevToolsContext page;
      public bool isSuccess = true;
      string url = "https://id.mynobox.com";
      string CampaignsUrl = "Campaign";
      string ContactsUrl = "Contact";
      string AccountsUrl = "Account";

      public static CountResult count;

      string[] SetMenu = { "Campaigns", "Contacts", "Accounts" };

      public MyNoBox()
      {
         InitializeComponent();
         count = new CountResult(this);
      }

      public void StopToStart()
      {
         BtnStart.Text = "Start";
         BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void iconButton1_Click(object sender, EventArgs e)
      {

      }

      private void iconButton2_Click(object sender, EventArgs e)
      {

      }

      private void label2_Click_1(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         var set = new Setting();
         set.Show();
      }

      private async void BtnStart_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            if (BtnStart.Text == "Start")
            {
               BtnStart.Text = "Stop";
               BtnStart.BackColor = System.Drawing.Color.Blue;

               string test = this.CBMenu.Text;

               Step = 1; //Auto Login
               var pageLog = await page.XPathAsync("//body[@id='s-LoginPage']");
               if (pageLog.Length > 0)
               {
                  await new LoginNobox().Start(webView21, page);

                  BtnStart.Text = "Start";
                  BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
                  IsStopped = true;
                  if (IsStopped == true)
                  {

                  }
               }

               Step = 2; // Run All
               if ((test == "All" || test == "All") && !IsStopped)
               {
                  int Tsk = 0;
                  try
                  {
                     Tsk = 1;
                     Logs("Info", "Run All Task Campaigns", "Run");
                     await new CampaignsCRUD().Start(webView21, page);
                     await new CampaignsFitur().Start(webView21, page);
                     await new BroadcastMessagesFitur().Start(webView21, page);
                     await new CampaignsMessageTemplatesCRUD().Start(webView21, page);
                     await new CampaignsMessageTemplatesFitur().Start(webView21, page);
                     await new CampaignsTagsCRUD().Start(webView21, page);
                     //await new CampaignsTagsFitur().Start(webView21, page);

                     Tsk = 2;
                     Logs("Info", "Run All Task Contacts", "Run");
                     await new ContactCRUD().Start(webView21, page);
                     await new ContactFitur().Start(webView21, page);
                     await new ContactListCRUD().Start(webView21, page);
                     await new ContactListFitur().Start(webView21, page);
                     await new ContactTagsCRUD().Start(webView21, page);
                     //await new ContactTagsFitur().Start(webView21, page);

                     Tsk = 3;
                     Logs("Info", "Run All Task Accounts", "Run");
                     await new AccountsCRUD().Start(webView21, page);
                     await new AccountsFitur().Start(webView21, page);

                     Logs("Info", "Run All Task", "DONE");

                     BtnStart.Text = "Start";
                     BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
                     IsStopped = true;
                     if (IsStopped == true)
                     {

                     }

                  }
                  catch (Exception tsk)
                  {
                     App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{tsk} {tsk.Message}");
                     string msg = $"Start Error Step {Tsk} : {tsk.Message}";
                     MessageBox.Show(msg);
                  }
               }
               Step = 3; // Run Paket Campaigns
               if ((test == "Campaigns" || test == "Campaigns") && !IsStopped)
               {
                  Logs("Info", "Paket Campaigns Run Task", "Run");
                  await new CampaignsCRUD().Start(webView21, page);                
                  await new CampaignsFitur().Start(webView21, page);
                  await new BroadcastMessagesFitur().Start(webView21, page);
                  await new CampaignsMessageTemplatesCRUD().Start(webView21, page);
                  await new CampaignsMessageTemplatesFitur().Start(webView21, page);
                  await new CampaignsTagsCRUD().Start(webView21, page);
                  //await new CampaignsTagsFitur().Start(webView21, page);
                  Logs("Info", "Paket Campaigns", "DONE");

                  BtnStart.Text = "Start";
                  BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
                  IsStopped = true;
                  if (IsStopped == true)
                  {

                  }
               }
               Step = 4; // Run Paket Contacts
               if ((test == "Contacts" || test == "Contacts") && !IsStopped)
               {
                  Logs("Info", "Paket Contacts Run Task", "Run");
                  await new ContactCRUD().Start(webView21, page);
                  await new ContactFitur().Start(webView21, page);
                  await new ContactListCRUD().Start(webView21, page);
                  await new ContactListFitur().Start(webView21, page);
                  await new ContactTagsCRUD().Start(webView21, page);
                  //await new ContactTagsFitur().Start(webView21, page);

                  Logs("Info", "Paket Contacts", "DONE");

                  BtnStart.Text = "Start";
                  BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
                  IsStopped = true;
                  if (IsStopped == true)
                  {

                  }
               }
               Step = 5; // Run Paket Accounts
               if ((test == "Accounts" || test == "Accounts") && !IsStopped)
               {
                  Logs("Info", "Paket Account Run Task", "Run");
                  await new AccountsCRUD().Start(webView21, page);
                  await new AccountsFitur().Start(webView21, page);
                  Logs("Info", "Paket Accounts", "DONE");

                  BtnStart.Text = "Start";
                  BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
                  IsStopped = true;
                  if (IsStopped == true)
                  {

                  }
               }
               if (IsStopped == true)
               {
                  //Logs("Info", "Scrape Has Stopped by User");
               }
               else
               {
                  //Logs("Info", $"{Tool} is Completed");
               }

               IsStopped = false;
            }
            else
            {
               BtnStart.Text = "Start";
               BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
               IsStopped = true;
               if (IsStopped == true)
               {

               }
            }

         }
         catch (Exception ex)
         {
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            string msg = $"Start Error Step {Step} : {ex.Message}";
            MessageBox.Show(msg);
         }
      }

      public async void startBrowser()
      {
         await webView21.EnsureCoreWebView2Async(null);

         webView21.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;
         webView21.CoreWebView2.AddWebResourceRequestedFilter(null, Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext.Image);

         page = await webView21.CoreWebView2.CreateDevToolsContextAsync();
         webView21.CoreWebView2.Navigate(url);

      }

      private void MyNoBox_Load(object sender, EventArgs e)
      {

         foreach (var item in SetMenu)
         {
            string filter = UpperCaseFirstChar(item);
            this.CBMenu.Items.Add(filter);
         }

         startBrowser();


      }

      private void CBMenu_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (this.CBMenu.Text == "All" || this.CBMenu.Text == "All")
         {
            string UrlKategori = $"{url}";
            webView21.CoreWebView2.Navigate(UrlKategori);
         }
         if (this.CBMenu.Text == "Campaigns" || this.CBMenu.Text == "Campaigns")
         {
            string UrlKategori = $"{url}/Nobox/{CampaignsUrl}";
            webView21.CoreWebView2.Navigate(UrlKategori);
         }
         if (this.CBMenu.Text == "Contacts" || this.CBMenu.Text == "Contacts")
         {
            string UrlKategori = $"{url}/Nobox/{ContactsUrl}";
            webView21.CoreWebView2.Navigate(UrlKategori);
         }
         if (this.CBMenu.Text == "Accounts" || this.CBMenu.Text == "Accounts")
         {
            string UrlKategori = $"{url}/Nobox/{AccountsUrl}";
            webView21.CoreWebView2.Navigate(UrlKategori);
         }

      }

      private void CoreWebView2_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
      {
         e.Response = webView21.CoreWebView2.Environment.CreateWebResourceResponse(null, 404, "Not found", null);
      }

      static public string UpperCaseFirstChar(string text)
      {
         string ret = "";
         string[] txt = text.Split(' ');
         int x = 0;
         foreach (var item in txt)
         {
            x += 1;
            ret += Regex.Replace(item, "^[a-z]", m => m.Value.ToUpper());
            if (x < txt.Length)
            {
               ret += " ";
            }
         }
         return ret;
      }

      public void updatestatus(string status)
      {
         this.lblPreview.Text = status;
      }     

      public class CountResult
      {
         private MyNoBox NoBox;

         public CountResult(MyNoBox nobox)
         {
            NoBox = nobox;
         }

         private int test;
         private int pass;
         private int fail;

         public int Test {
            get { return test; } 
            set
            {
               test = value;
               NoBox.label1.Text = "Test : " + test;
            }
         }
         public int PASS
         {
            get { return pass; }
            set
            {
               pass = value;
               NoBox.label3.Text = "Pass : " + pass;
            }
         }
         public int FAILED
         {
            get { return fail; }
            set
            {
               fail = value;
               NoBox.label2.Text = "Fail : " + fail;
            }
         }
      }

      public class logsitems
      {
         public int idLogs { get; set; }
         public string timeNow { get; set; }
         public string Type { get; set; }
         public string Process { get; set; }
         public string Result { get; set; }
      }

      public void Logs(string Type, string Process, string Result)
      {

         this.lblPreview.Text = $"{Process}";
         DateTime localDate = DateTime.Now;

         DateTime utcDate = DateTime.UtcNow;
         string timeNow = localDate.ToString("MM/dd/yyyy HH:mm:ss");
         var lgitem = new logsitems();
         lgitem.idLogs = idLogs + 1;
         lgitem.timeNow = timeNow;
         lgitem.Type = Type;
         lgitem.Process = Process;
         lgitem.Result = Result;
         logsitemsBindingSource.List.Insert(0, lgitem);
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
