using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;


namespace MyNoBoxWinForm
{
   public class CampaignsFitur
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
           

            Step = 8; // Untuk Search Chanel
            await ChanelSearch(webView21, page);

            Step = 9; // Untuk Search Status
            await StatusSearch(webView21, page);

            Step = 9; // Untuk Search Status
            await AccountSearch(webView21, page);

            Step = 11; // Untuk Search List
            await ListSearch(webView21, page);

            Step = 11; // Untuk Search List
            await TagsSearch(webView21, page);

            Step = 18;
            await ProcessToDone(webView21, page);

            Step = 19;
            await Canceled(webView21, page);

            //Step = 20;
            //await GenerateMessageFitur();

            Step = 21;
            await Clone(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Campaigns - Fitur", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Campaigns - Fitur", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Campaigns - Fitur Selesai");
         }
      }

      public async Task ChanelSearch(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Channel Search:");

            Step = 1;
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_CampaignGrid0_QuickFilter_ChannelId']", page);

            Step = 2;
            await App.Click("//span[text()='Channel']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Channel Search", "PASS");
            App.LogPass("- P - Campaigns Fitur - Channel Search - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Channel Search", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task StatusSearch(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Status Search:");

            Step = 1;
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_CampaignGrid0_QuickFilter_Status']", page);

            Step = 2;
            await App.Click("//span[text()='Status']/following-sibling::div//abbr", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Status Search", "PASS");
            App.LogPass("- P - Campaigns Fitur - Status Search - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Status Search", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task AccountSearch(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Accounts Search:");

            Step = 1;
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[4]/a", page);

            Step = 2;
            await App.Click("//a[@class='select2-search-choice-close']", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Account Search", "PASS");
            App.LogPass("- P - Campaigns Fitur - Account Search-PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - AccountSearch", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ListSearch(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - List Search:");

            Step = 1;
            await App.ClickFilter("//input[@id='s2id_autogen4']", page);

            Step = 2;
            await App.Click("//a[@class='select2-search-choice-close']", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - List Search", "PASS");
            App.LogPass("- P - Campaigns Fitur - List Search - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - ListSearch", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task TagsSearch(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Tags Search:");

            Step = 1;
            await App.ClickFilter("//input[@id='s2id_autogen5']", page);

            Step = 2;
            await App.Click("//a[@class='select2-search-choice-close']", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Tags Search", "PASS");
            App.LogPass("- P - Campaigns Fitur - Tags Search - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Tags Search", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ProcessToDone(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Process To Done:");

            Step = 1; // Klik Nama Sesuai Status
            await App.Click("//div[@class='slick-cell l2 r2']/div[contains(text(), 'DRAFT')]", page);

            Step = 2; // Klik Name
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[1]/a", page);

            Step = 3; //  Klik Proses
            await App.ClickBtn("//div[@title='Process this campaign']", page);

            Step = 4; //  Klik Yes
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            Step = 5;
            await App.ClickBtn("//button[text()='OK']", page);

            Step = 6; // Klik Save
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 8; // Klik Button Restore
            await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

            Step = 9; // Klik Button Yes restore
            await App.ClickBtn("//button[text()='Yes']", page);

            Step = 10; // Click Refresh
            await App.ClickBtn("//div[@class='tool-button refresh-button icon-tool-button']", page);

            Step = 10; // Klik Nama Lgi
            await App.Click("//div[@class='slick-cell l2 r2']/div[contains(text(), 'PROCESS')]", page);

            Step = 11; // Klik Name
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[1]/a", page);

            Step = 12; // Klik Done
            await App.ClickBtn("//div[@title='mark as done this campaign']", page);

            Step = 13; // Klik Yes
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            Step = 14; // Klik Save 
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; // Klik Button Restore
            await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

            Step = 17; // Klik Button Yes
            await App.ClickBtn("//button[text()='Yes']", page);

            Step = 10; // Click Refresh
            await App.ClickBtn("//div[@class='tool-button refresh-button icon-tool-button']", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Process To Done", "PASS");
            App.LogPass("- P - Campaigns Fitur - Process To Done- PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Process To Done", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task Canceled(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Cancel ");

            Step = 0;
            await App.Click("//div[@class='slick-cell l2 r2']/div[contains(text(), 'PROCESS')]", page);

            Step = 1; // Klik Name
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[1]/a", page);

            Step = 2; //  Klik Cancel
            await App.ClickBtn("//div[@title='Cancel this campaign']", page);

            Step = 3; // Klik Yes 
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

            Step = 4; // Klik Save
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);
            ;
            Step = 6; // Klik Button Restore
            await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

            Step = 7; // Klik Button Yes
            await App.ClickBtn("//button[text()='Yes']", page);

            Step = 10; // Click Refresh
            await App.ClickBtn("//div[@class='tool-button refresh-button icon-tool-button']", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Canceled", "PASS");
            App.LogPass("- P - Campaigns Fitur - Canceled - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Canceled", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      //public async Task GenerateMessageFitur()
      //{
      //    int Step = 0;
      //    try
      //    {
      //        App.Log(" Campaigns Fitur - Generate Messages ");

      //        Step = 5; //Klik Name
      //        await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[1]/a", page);

      //        Step = 5; //Klik Name
      //        await App.Click("//a[@id='ui-id-3']", page);

      //        Step = 6; //Click Generate Message
      //        await App.ClickBtn("//div[@class='panel-titlebar']/following-sibling::div//div[@title='Generate Messages']", page););

      //        Step = 5; //Klik Name
      //        await App.Click("//button[text()='Yes']", page);

      //        Step = 15; //Klik Save
      //        await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

      //        App.LogPass(" Campaigns Fitur - Generate Messages:PASS  ");
      //    }
      //    catch (Exception ex)
      //    {

      //        App.LogFailed(" Campaigns Fitur - Generate Messages:FAILED  ");
      //        App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
      //        isSuccess = false;
      //    }
      //}

      public async Task Clone(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns Fitur - Clone:");

            Step = 0;
            await App.Click("//div[@class='slick-cell l2 r2']/div[contains(text(), 'DONE')]", page);

            Step = 1; // Klik Name
            await App.Click("//div[contains(@class,'top grid-canvas-left')]/div/div[1]/a", page);

            Step = 2; // Proses Klik Cancel
            await App.ClickBtn("//div[contains(@class, 'clone-button')]", page);

            Step = 4; // Klik Save
            await App.ClickBtn("//div[contains(@id,'Nobox_CampaignDialog')][2]//span[text()=' Save']", page);

            Step = 15; //Klik Save
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Clone", "PASS");
            App.LogPass("- P - Campaigns Fitur - Clone - PASS");

            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns Fitur - Clone", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}

