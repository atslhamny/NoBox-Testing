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
   public class ContactListFitur
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
            Step = 3; // Untuk login
            await AddfromContact(webView21, page);

            Step = 4; // Untuk login
            await AddfromCampaignsTarget(webView21, page);

            Step = 2; // Untuk login
            await DeleteAllContact(webView21, page);

            Step = 2; // Untuk login
            await DeleteContact(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Lists - Fitur", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Lists - Fitur", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Lists - Fitur Selesai");
         }
      }

      public async Task AddfromContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("-P-List Fitur-Add From Contact:");

            Step = 3; // click categori
            await App.ClickBtn("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; // Click Refresh
            await App.ClickBtn("//div[contains(@class, 'add-button-contact')]", page);

            Step = 4; // Click Refresh
            await App.ClickBtn("//button[contains(text(),'Add from Contacts')]", page);

            Step = 4; // Click Refresh
            var clickCheckbox = await page.XPathAsync("//span[@class='select-all-items check-box no-float']");
            if (clickCheckbox.Length > 0)
            {
               await clickCheckbox[0].EvaluateFunctionAsync<string>("e => e.click()");
               await App.ClickBtn("//button[text()='OK']", page);
            }
            else
            {
               await App.ClickBtn("//button[text()='Cancel']", page);
            }

            Step = 6;
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 12; // Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List Fitur - Add From Contact", "PASS");
            App.LogPass("-P-List Fitur-Add From Contact-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List Fitur - Add From Contact", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task AddfromCampaignsTarget(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("-P-List Fitur-Add From Campaigns Target:");

            Step = 3; // Proses click categori
            await App.ClickBtn("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; // Click Refresh
            await App.ClickBtn("//div[contains(@class, 'add-button-contact')]", page);

            Step = 4; // Click Refresh
            await App.ClickBtn("//button[contains(text(),'Add from Campaign Targets')]", page);

            Step = 4; // Click Refresh
            await App.ClickBtn("//div[@class='slick-cell l0 r0']/span", page);

            Step = 5; //Click Ok
            await App.ClickBtn("//button[text()='OK']", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List Fitur - Add From Campaigns Target", "PASS");
            App.LogPass("-P-List Fitur-Add From Campaigns Target-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List Fitur - Add From Campaigns Target", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DeleteAllContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("-P-List Fitur-Delete All Contact:");

            Step = 3; //  click categori
            await App.ClickBtn("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; // Click Tags
            await App.ClickBtn("//div[contains(@class, 'delete-all-contact')]", page);

            Step = 5; //  Click Yes Alert Delete Value Contact List
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List Fitur - Delete All Contact", "PASS");
            App.LogPass("-P-List Fitur-Delete All Contact-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List Fitur - Delete All Contact", "PASS");
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
            App.Log("-P-List Fitur-Delete:");

            Step = 4; // Click Delete Value Contact  List
            await App.ClickBtn("//div[contains(@class, 'delete-button')]", page);

            Step = 5; // Click Yes Alert Delete Value Contact List
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "List Fitur - Delete", "PASS");
            App.LogPass("-P-List Fitur-Delete-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "List Fitur - Delete", "PASS");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }


   }
}

