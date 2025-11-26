using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm

{
   public class BroadcastMessagesFitur
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
            Step = 10; // Untuk login
            await FilterCampaigns(webView21, page);

            Step = 10; // Untuk login
            await FilterContact(webView21, page);

            Step = 11; // Untuk login
            await FilterStatus(webView21, page);

            Step = 12; // Untuk login
            await FilterTags(webView21, page);

            Step = 13; // Untuk login
            await ProcessBy(webView21, page);

            Step = 14; // Untuk login
            await IsRead(webView21, page);

            Step = 15; // untuk login
            await VCard(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Broadcast Messages", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Broadcast Messages", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Broadcast Messages Selesai");
         }
      }

      public async Task FilterCampaigns(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            var btnBroadcast = await page.XPathAsync("//a[@href='/Nobox/BroadcastMessages']");
            if (btnBroadcast.Length > 0)
            {
               await btnBroadcast[0].EvaluateFunctionAsync<string>("e => e.click()");
            }

            App.Log("- P - Broadcast Messages Fitur - Filter Campaigns:");

            Step = 2; // click categori
            await App.ClickFilter("//div[contains(@id, 's2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_CampaignId')]", page);

            await App.Click("//div[contains(@id, 's2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_CampaignId')]//abbr", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Campaigns", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Filter Campaigns - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Campaigns", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - Filter Contact:");

            Step = 1; // click categori
            await App.ClickFilter("//span[text()='Contact']/following-sibling::div[contains(@class, 'container')]", page);

            Step = 5; // click categori
            await App.Click("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_ContactId']//abbr", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Contact", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Filter Contact - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Contact", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterStatus(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - Filter Status:");

            Step = 1; // click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_Status']", page);

            Step = 5; // click categori
            await App.Click("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_Status']//abbr", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Status", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Filter Status - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Status", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterTags(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - FilterTags:");

            Step = 1; // click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_Tags']", page);

            Step = 5; // click categori
            await App.Click("//li[contains(@class, 'select2-search-choice')]//a", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Tags", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Filter Tags - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Filter Tags", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ProcessBy(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - ProcessBy:");

            Step = 1; // click categori
            await App.ClickFilter("//span[text()='Process By']/following-sibling::div[contains(@class, 'container')]", page);

            Step = 5; //  click categori
            await App.Click("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_ProcessBy']//abbr", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Process By", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Process By - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Process By", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task IsRead(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - IsRead:");

            Step = 1; // click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_IsRead']/a", page);

            Step = 5; // click close
            await App.Click("//div[@id='s2id_Nobox_Nobox_CampaignresultBroadcastGrid0_QuickFilter_IsRead']//abbr", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Is Read", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - Is Read - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - Is Read", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task VCard(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Broadcast Messages Fitur - VCard:");

            Step = 1; // click Detail Tags
            await App.ClickBtn("//div[contains(@class, 'slick-pg-last')]", page);

            Step = 2; // click Detail Tags
            await App.ClickBtn("//div[@class='slick-cell l1 r1']/a", page);

            Step = 2; // click categori
            await App.ClickBtn("//div[contains(@class, 'btn-vcard')]", page);

            Step = 3; // click categori
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - VCard", "PASS");
            App.LogPass("- P - Broadcast Message Fitur - VCard - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Broadcast Message Fitur - VCard", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}
