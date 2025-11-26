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
   public class ContactListCRUD
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
            Step = 1; // Nama Kosong
            await NameBlank(webView21, page);

            Step = 3; // Untuk Proses Create List
            await CreateContact(webView21, page);

            Step = 4; // Untuk Proses Read List
            await ReadContact(webView21, page);

            Step = 5; // Untuk Proses Update List
            await UpdateContact(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Lists - CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Lists - CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Lists - CRUD Selesai");
         }
      }

      public async Task NameBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1;
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/List']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }

            App.Log("- N - List - Insert:");

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 8; // Click Close Panel
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "List - Insert - NameBlank", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "List - Insert - NameBlank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "List - Insert", "FAILED");
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
            App.Log("- P - List - Insert:");

            Step = 4; // Click List
            await App.ClickBtn("//a[@href='/Nobox/List']", page);

            Step = 5; // Click Button Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name List
            await App.InputData("//input [@id = 'Nobox_Nobox_ListDialog6_Nm']", "Scrape OLX Romania", page);

            Step = 7; // Click Save List
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "List - Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "List - Insert", "PASS");
               App.LogPass("- P - List - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List - Insert", "FAILED");
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
            App.Log("- P - List - Read:");

            Step = 3; // Click Detail Value Contact List
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List - Read", "PASS");
            App.LogPass("- P - List - Read - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List - Read", "PASS");
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
            App.Log("- P - List - Update:");

            await App.Update("Test Update", "//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List - Update", "PASS");
            App.LogPass("- P - List - Update - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List - Update", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}

