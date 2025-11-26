using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class CampaignsMessageTemplatesFitur
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
            await SearchChanel(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Message Templates - Fitur", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Message Templates - Fitur", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Message Templates - Fitur Selesai");
         }
      }


      public async Task SearchChanel(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Message Template Fitur - Search Channel:");

            Step = 4; // click categori
            await App.ClickFilter("//span[text()='Channel']/following-sibling::div[contains(@class, 'container')]", page);

            await App.Click("//span[text()='Channel']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Message Template Fitur - Search Channel", "PASS");
            App.LogPass("- P - Message Template Fitur - Search Channel - PASS");
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Message Template Fitur - Search Channel", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}
