using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class CampaignsTagsCRUD
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
            Step = 3; // Untuk Proses Create Tags
            await NameBlank(webView21, page);

            Step = 3; // Untuk Proses Create Tags
            await CreateTags(webView21, page);

            Step = 4; // Untuk Proses Read Tags
            await ReadTags(webView21, page);

            Step = 5; // Untuk Proses Update Tags
            await UpdateTags(webView21, page);

            Step = 6; // Untuk Proses Delete Tags
            await DeleteTags(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Campaigns Tags - CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Campaigns Tags - CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Campaigns Tags - CRUD Selesai");
         }
      }

      public async Task NameBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1;
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/Campaign/Tags']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }
            App.Log("- N - Campaigns Tags - Insert:");

            Step = 5; // Click Button Tambah Data Tags
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 8; // Click Save List
            await App.Click("//button[text()='OK']", page);

            Step = 7; // Click Save Tags
            await App.Click("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns-Tags-Insert", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Tags - Insert", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Campaigns - Tags - Insert", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }


      public async Task CreateTags(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns-Tags-Insert:");

            Step = 4; //  Click Tags
            await App.ClickBtn("//a[@href='/Nobox/Campaign/Tags']", page);

            Step = 5; //  Click Button Tambah Data Tags
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Name Tags
            await App.InputData("//label[@title='Name']/following-sibling::input", "test campaigns tags", page);

            Step = 7; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Insert", "PASS");
               App.LogPass("- P - Campaigns - Tags - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Insert", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ReadTags(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns-Tags-Read:");

            Step = 3; //  Click Detail Value Campaign Tags
            await App.Click("//div[@class='slick-cell l1 r1']/a", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Read", "PASS");
            App.LogPass("- P - Campaigns - Tags - Read - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Read", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task UpdateTags(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns-Tags-Update:");

            await App.Update("Update", "//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Update", "PASS");
            App.LogPass("- P - Campaigns -Tags - Update - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Update", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DeleteTags(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns-Tags-Delete:");

            Step = 3; //  Click Detail Value Campaign
            await App.Click("//div[@class='slick-cell l1 r1']/a", page);

            Step = 4; //  Click Delete Value Campaign
            await App.ClickBtn("//div[contains(@class, 'delete-button')]", page);

            Step = 5; //  Click Yes Alert Delete Value Campaign
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Delete", "PASS");
            App.LogPass("- P - Campaigns - Tags - Delete - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Tags - Delete", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}
