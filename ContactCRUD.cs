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
   public class ContactCRUD
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
            var pagepaket = await page.XPathAsync("//section[@class='content']//div[text()='Contacts']");
            if (pagepaket.Length > 0)
            {
               goto Task;
            }
            else
            {
               var btnPaket = await page.XPathAsync("//a[@href='#nav_menu1_3']/../ul[contains(@class,'show')]");
               if (btnPaket.Length > 0)
               {
                  goto Task;
               }
               else
               {
                  var paket = await page.XPathAsync("//a[@href='#nav_menu1_3']");
                  if (paket.Length > 0)
                  {
                     await paket[0].EvaluateFunctionAsync("e => e.click()");
                     var subpaket = await page.WaitForXPathAsync("//a[@href='/Nobox/Contact']", new WaitForSelectorOptions() { Visible = true });
                     if (subpaket != null)
                     {
                        await subpaket.ClickAsync();
                        goto Task;
                     }
                  }
               }
            }
         Task:
            Step = 1; // Untuk Proses Create Tags
            await AllBlank(webView21, page);

            Step = 2; // Untuk Proses Create Tags
            await NameBlank(webView21, page);

            Step = 3;
            await CategoryBlank(webView21, page);

            Step = 4; // Untuk Proses Create Tags
            await ExtIdBlank(webView21, page);

            Step = 5;
            await CreateContact(webView21, page);

            Step = 6; // Untuk Proses Read Tags
            await ReadContact(webView21, page);

            Step = 7; // Untuk Proses Update Tags
            await UpdateContact(webView21, page);

            Step = 8; // Untuk Proses Delete Tags
            await DeleteContact(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Contact - CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Contact - CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Contact - CRUD Selesai");
         }
      }

      public async Task AllBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {

            App.Log("- N - Contacts-Insert - All Blank:");


            Step = 5; //  Click Button Tambah Data Contact
            await App.Click("//div[contains(@class, 'add-button')]", page);

            Step = 15; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - All Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - All Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Contacts - Insert - All Blank", "FAILED");
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
            App.Log("- N - Contacts-Insert - Name Blank:");

            Step = 4; // Click Contact
            await App.Click("//a[@href='/Nobox/Contact']", page);

            Step = 5; //  Click Button Tambah Data Contact
            await App.Click("//div[contains(@class, 'add-button')]", page);

            Step = 7; //  Input Category contact
            await App.InputData("//input[@name = 'Category']", "Scraper", page);

            Step = 12; // Isi Ext Id
            await App.InputData("//input[@name = 'ExtId']", "67", page);

            Step = 15; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);


            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts-Insert-Name Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - Name Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Contacts - Insert - Name Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task CategoryBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Contacts-Insert - Category Blank:");

            Step = 4; // Click Contact
            await App.Click("//a[@href='/Nobox/Contact']", page);

            Step = 5; // Click Button Tambah Data Contact
            await App.Click("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name contact
            await App.InputData("//input[@name = 'Name']", "Agiel Retri", page);

            Step = 12; // Isi Ext Id
            await App.InputData("//input[@name = 'ExtId']", "634", page);

            Step = 15; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - Category Blank", "PASS");
            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - Category Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Contacts - Insert - Category Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ExtIdBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Contacts - Insert - ExtId Blank:");

            Step = 4; // Click Contact
            await App.Click("//a[@href='/Nobox/Contact']", page);

            Step = 5; // Click Button Tambah Data Contact
            await App.Click("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name contact
            await App.InputData("//input[@name = 'Name']", "Agiel Retri", page);

            Step = 7; // Input Category contact
            await App.InputData("//input[@name = 'Category']", "Scraper", page);

            Step = 15; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - ExtId Blank", "PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Contacts - Insert - ExtId Blank", "FAILED");
               App.LogPass("- N - Contacts - Insert - ExtId Blank - PASS");
            }
            MyNoBox.count.PASS++;

         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("N", "Contacts - Insert - ExtId Blank", "FAILED");
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
            App.Log("- P - Contacts - Insert:");

            Step = 4; // Click Contact
            await App.Click("//a[@href='/Nobox/Contact']", page);

            Step = 5; // Click Button Tambah Data Contact
            await App.Click("//div[contains(@class, 'add-button')]", page);

            Step = 6; // Input Name contact
            await App.InputData("//input[@name = 'Name']", "Agiel Retri", page);

            Step = 7; // Input Category contact
            await App.InputData("//input[@name = 'Category']", "Scraper", page);

            Step = 12; // Isi Ext Id
            await App.InputData("//input[@name = 'ExtId']", "2376", page);

            Step = 15; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Contacts - Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Contacts - Insert", "PASS");
               App.LogPass("- P - Contacts -Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
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
            App.Log("- P - Contacts - Read:");

            Step = 3; // Click Detail Value Contact Tags
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            ((MyNoBox)frm).Logs("P", "Contacts - Read", "PASS");
            App.LogPass("- P - Contacts - Read - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts - Read", "FAILED");
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
            App.Log("- P - Contacts - Update:");

            await App.Update("Update", "//div[contains(@class, 'save-and-close-button')]", page);

            ((MyNoBox)frm).Logs("P", "Contacts - Updates", "PASS");
            App.LogPass("- P - Contacts - Update - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts - Updates", "FAILED");
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
            App.Log("- P - Contacts - Delete:");

            Step = 3; // Click Detail Value Contact Tags
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; // Click Delete Value Contact  Tags
            await App.Click("//div[contains(@class, 'delete-button')]", page);

            Step = 5; // Click Yes Alert Delete Value Contact Tags
            await App.Click("//button[contains(@class, 'btn btn-primary')]", page);

            ((MyNoBox)frm).Logs("P", "Contacts - Delete", "PASS");
            App.LogPass("- P - Contacts - Delete - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts - Delete", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

   }
}
