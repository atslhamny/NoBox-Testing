using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class AccountsFitur
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
            Step = 3; // Untuk Delete Tags
            await SearchCategori(webView21, page);

            Step = 5; // Untuk Delete Tags
            await SearchUsers(webView21, page);

            Step = 6; // Untuk Delete Tags
            await SearchStatus(webView21, page);


            ((MyNoBox)frm).Logs("Info", "Accounts - Fitur", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Accounts - Fitur", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Accounts - Fitur Selesai");
         }
      }

      public async Task SearchCategori(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts Fitur - Search Category:");

            Step = 3; //  click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_AccountGrid0_QuickFilter_Category']", page);

            Step = 4;
            await App.Click("//span[text()='Category']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Category", "PASS");
            App.LogPass("- P - Account Fitur - Search Category-PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Category", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task SearchChannel(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts Fitur - Search Channel:");

            Step = 3; //  click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_AccountGrid0_QuickFilter_Channel']", page);

            Step = 4;
            await App.Click("//span[text()='Channel']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Channel", "PASS");
            App.LogPass("- P - Account Fitur - Search Channel - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Channel", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task SearchUsers(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts Fitur - Search Users:");

            Step = 1; // Klik search Users
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_AccountGrid0_QuickFilter_Users']/ul/li/input", page);

            Step = 4;
            await App.Click("//span[text()='Users']/following-sibling::div//a", page);

            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Users", "PASS");
            App.LogPass("- P - Account Fitur - Search Users - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Users", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task SearchStatus(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Accounts Fitur - Search Status:");

            Step = 1; // Klik Searh Status
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_AccountGrid0_QuickFilter_Status']/a", page);

            Step = 4;
            await App.Click("//span[text()='Status']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Status", "PASS");
            App.LogPass("- P - Account Fitur - Search Status - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Account Fitur - Search Status", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }


   }
}
