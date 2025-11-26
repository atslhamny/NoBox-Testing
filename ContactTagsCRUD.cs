using MyNoBoxWinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class ContactTagsCRUD
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
            await CreateContact(webView21, page);

            Step = 4; // Untuk Proses Read Tags
            await ReadContact(webView21, page);

            Step = 5; // Untuk Proses Update Tags
            await UpdateContact(webView21, page);

            Step = 6; // Untuk Proses Delete Tags
            await DeleteContact(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Contact Tags-CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Contact Tags-CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Contact Tags-CRUD Selesai");
         }
      }

      public async Task NameBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1;
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/Contact/Tags']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }

            App.Log("- N - Contact Tags - Insert:");

            Step = 5; //  Click Button Tambah Data Tags
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 8; // Klik Ok Null
            await App.ClickBtn("//div/button[text()='OK']", page);

            Step = 4; //  Click Tags
            await App.ClickBtn("//button[@class='ui-dialog-titlebar-close']", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Contact Tags-Insert-NameBlank", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Contact Tags-Insert-Name Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Contact Tags-Insert-Name Blank", "PASS");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task CreateContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contact Tags - Insert:");

            Step = 4; // Click Tags
            await App.ClickBtn("//a[@href='/Nobox/Contact/Tags']", page);

            Step = 5; // Click Button Tambah Data Tags
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name Tags
            await App.InputData("//label[@title='Name']/following-sibling::input", "contact baru lagi", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Contact Tags-Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Contact Tags-Insert", "PASS");
               App.LogPass("-P-Contact Tags-Insert-PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contact Tags-Insert", "PASS");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ReadContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contact Tags - Read:");

            Step = 3; // Click Detail Value Contact Tags
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div[1]/div[2]/a", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contact Tags-Read", "PASS");
            App.LogPass("-P-Contact Tags-Read-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contact Tags-Read", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task UpdateContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contact Tags - Update:");

            await App.Update("Update Test", "//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contact Tags-Update", "PASS");
            App.LogPass("-P-Contact Tags-Update-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contact Tags-Update", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DeleteContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contact Tags - Delete:");

            Step = 3; // Click Detail Value Contact Tags
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div[3]/div[1]/a", page);

            Step = 4; // Click Delete Value Contact  Tags
            await App.ClickBtn("//div[contains(@class, 'delete-button')]", page);

            Step = 5; // Click Yes Alert Delete Value Contact Tags
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contact Tags-Delete", "PASS");
            App.LogPass("-P-Contact Tags-Delete:");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contact Tags-Delete", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}
