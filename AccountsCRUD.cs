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
   public class AccountsCRUD
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
            var btnAccount = await page.XPathAsync("//ul[@id='s_sidebar_menu1']/li[4]/a");
            if (btnAccount.Length > 0)
            {
               await btnAccount[0].EvaluateFunctionAsync<string>("e => e.click()");
            }

            Step = 1;
            await AllBlank(webView21, page);

            Step = 2;
            await CategoryBlank(webView21, page);

            Step = 3;
            await NameBlank(webView21, page);

            Step = 4;
            await ClientIdBlank(webView21, page);

            Step = 5; // Untuk Create Accounts
            await CreateContact(webView21, page);

            Step = 6; // Untuk Read Accounts
            await ReadAccount(webView21, page);

            Step = 7; // Untuk Update Accounts
            await UpdateAccount(webView21, page);

            Step = 8; // Untuk Delete Accounts
            await DeleteAccount(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Accounts - CRUD", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Accounts - CRUD", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Accounts - CRUD Selesai");
         }
      }

      public async Task AllBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Account - Blank Insert:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Account']", page);

            Step = 1; // Click Button Tambah Data account
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 2; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 14;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert - All Blank ", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert - All Blank ", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Account - Insert - All Blank ", "FAILED");
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
            App.Log("- N - Account - Insert Blank Category:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Account']", page);

            Step = 3; //  Click Button Tambah Data account
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 5; //  Input Name account
            await page.Keyboard.TypeAsync("Ijul Kurniawan");

            Step = 4; //  Hapus Category
            await App.ClickBtn("//div[@id='s2id_Nobox_Nobox_AccountDialog11_Category']//abbr", page);

            Step = 8; // ClientId
            await App.InputData("//div[contains(@class, 'ApiClient')]/input", "6345", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 14;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank Category", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank Category", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("P", "Account - Insert Blank Category", "FAILED");
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
            App.Log(" - N - Accounts - Insert - Name Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Account']", page);

            Step = 4; // Click Button Tambah Data account
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; // Input Name categori
            await App.InputChannel("//div[contains(@class, 'field Channel')]//span[text()='--select--']", page);

            Step = 8; //Input ClientId
            await App.InputData("//div[contains(@class, 'ApiClient')]/input", "634", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 14;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank Name", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank Name", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Account - Insert Blank Name", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }


      public async Task ClientIdBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log(" - N - Accounts - Insert - ClientId Blank:");

            Step = 4; // Click Button Tambah Data account
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 7; // Input Name categori
            await App.InputChannel("//div[contains(@class, 'field Channel')]//span[text()='--select--']", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);


            Step = 14;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank ClientId", "PASS");
            }
            else if(Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Account - Insert Blank CLientId", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Account - Insert Blank ClientId", "FAILED");
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
            App.Log("- P - Account - Insert:");

            Step = 3; //  Click DropDown account
            await App.ClickBtn("//ul[@id='s_sidebar_menu1']/li[4]/a", page);

            Step = 4; //  Click Button Tambah Data account
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 5; //  Input Name account
            await page.Keyboard.TypeAsync("Ijul Kurniawan");

            Step = 7; //  Input Name categori
            await App.InputChannel("//div[contains(@class, 'field Channel')]//span[text()='--select--']", page);

            Step = 8; // ClientId
            await App.InputData("//div[contains(@class, 'ApiClient')]/input", "634", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Account - Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Account - Insert", "PASS");
               App.NegaPass("- P - Account - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account - Insert", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ReadAccount(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts - Read:");

            Step = 3; //  Click Detail Contact 
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            ((MyNoBox)frm).Logs("P", "Account - Read", "PASS");
            App.LogPass("- P - Account - Read - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account - Read", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task UpdateAccount(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts - Update:");

            await App.Update("Update", "//div[contains(@class, 'save-and-close-button')]", page);

            ((MyNoBox)frm).Logs("P", "Account - Update", "PASS");
            App.LogPass("- P - Account - Update - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account - Update", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DeleteAccount(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts - Delete:");

            Step = 3; // Click Detail Value account
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; //Click Delete Value account
            await App.ClickBtn("//div[contains(@class, 'delete-button')]", page);

            Step = 5; //Click Yes Alert Delete Value account
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            ((MyNoBox)frm).Logs("P", "Account - Delete", "PASS");
            App.LogPass("- P - Account - Delete - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account - Delete", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}

