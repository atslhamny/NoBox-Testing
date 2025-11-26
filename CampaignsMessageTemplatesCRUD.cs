using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class CampaignsMessageTemplatesCRUD
   {
      Form frm = Application.OpenForms["MyNoBox"];
      string url = App.UrlUtama;
      WebView2DevToolsContext page;
      public bool isSuccess = true;

      public async Task Start(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         int Step = 0;
         try
         {
            Step = 1; // Untuk Proses Create List
            await AllBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await NameBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await ChannelBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await MessageBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await Create(webView21, page);

            Step = 2; // Untuk Proses Read List
            await Read(webView21, page);

            Step = 3; // Untuk Proses Update List
            await Update(webView21, page);

            Step = 4; // Untuk Proses Delete List
            await Delete(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Message Templates - CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Message Templates - CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Message Templates - CRUD Selesai");
         }

      }

      public async Task AllBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1;
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/CampaignTemplate']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }
            App.Log("- N - Campaigns - Message Template - Insert - All Blank:");

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 8; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - All Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - All Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Message Template - Insert - All Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task NameBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Message Template - Insert - Name Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/CampaignTemplate']", page);

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; // Input Name List
            await App.InputData("//textarea[@name='BodyText']", "menambahkan 50 contact ke channel wa", page);

            Step = 8; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - Name Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - Name Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Message Template - Insert - Name Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ChannelBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Message Template - Insert - Channel Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/CampaignTemplate']", page);

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name List
            await App.InputData("//input[@name='Name']", "Tambah 40 contact ke wa", page);

            Step = 7; // Input Name List
            await App.InputData("//textarea[@name='BodyText']", "menambahkan 50 contact ke channel wa", page);

            Step = 7; //  Click close
            await App.ClickBtn("//div[@id='s2id_Nobox_Nobox_CampaignTemplateDialog6_ChannelId']//abbr", page);

            Step = 8; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - Channel Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert - Channel Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Message Template - Insert - Channel Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task MessageBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1;
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/CampaignTemplate']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }

            App.Log("- N - Campaigns - Message Template - Insert:"); ;

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name List
            await App.InputData("//input[@name='Name']", "Tambah 100 contact ke wa", page);

            Step = 8; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Message Template - Insert", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Message Template - Insert", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }


      public async Task Create(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Message Template - Insert:");

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name List
            await App.InputData("//input[@name='Name']", "Tambah 100 contact ke wa", page);

            Step = 7; // Input Name List
            await App.InputData("//textarea[@name='BodyText']", "menambahkan 50 contact ke channel wa", page);

            Step = 8; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Message Template-Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Message Template - Insert", "PASS");
               App.LogPass("- P - Message Template - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Message Template - Insert", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task Read(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Message Template - Read:");

            Step = 3; // Click Detail Value Contact List
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            ((MyNoBox)frm).Logs("P", "Message Template - Read", "PASS");
            App.LogPass("- P - Message Template - Read - PASS");
            MyNoBox.count.PASS++;
         }

         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Message Template - Read", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task Update(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Message Template - Update:");

            await App.Update("Update", "//div[contains(@class, 'save-and-close-button')]", page);

            ((MyNoBox)frm).Logs("P", "Message Template - Update", "PASS");
            App.LogPass("-P-Message Template  - Update - PASS");
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Message Template - Update", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task Delete(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Message Template - Delete:");

            Step = 3; // Click Detail Value Contact List
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; // Click Delete Value Contact  List
            await App.ClickBtn("//i[contains(@class, 'fa fa-trash-o text-red')]", page);

            Step = 5; // Click Yes Alert Delete Value Contact List
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            ((MyNoBox)frm).Logs("P", "Message Template - Delete", "PASS");
            App.LogPass("- P - Message Template - Delete - PASS");
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Message Template - Delete", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}