using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class CampaignsCRUD
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
            Step = 1;
            var pagepaket = await page.XPathAsync("//section[@class='content']//div[text()='Campaigns']");
            if (pagepaket.Length > 0)
            {
               goto Task;
            }
            else
            {
               var btnPaket = await page.XPathAsync("//a[@href='#nav_menu1_2']/../ul[contains(@class,'show')]");
               if (btnPaket.Length > 0)
               {
                  goto Task;
               }
               else
               {
                  var paket = await page.XPathAsync("//a[@href='#nav_menu1_2']");
                  if (paket.Length > 0)
                  {
                     await paket[0].EvaluateFunctionAsync("e => e.click()");
                     var subpaket = await page.WaitForXPathAsync("//a[@href='/Nobox/Campaign']", new WaitForSelectorOptions() { Visible = true });
                     if (subpaket != null)
                     {
                        await subpaket.ClickAsync();
                        goto Task;
                     }
                  }
               }
            }

         Task:
            Step = 1;
            await DMALLBlank(webView21, page);

            Step = 2;
            await DMChannelBlank(webView21, page);

            Step = 3;
            await DMAccountBlank(webView21, page);

            Step = 4;
            await DirectMessage(webView21, page);

            Step = 1; // Untuk Proses Create List
            await AllBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await NameBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await ChannelBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await AccountBlank(webView21, page);

            Step = 3; // Untuk Proses Create Tags
            await ListBlank(webView21, page);

            Step = 1; // Untuk Proses Create List
            await MessageBlank(webView21, page);

            Step = 3; // Untuk Proses Create Tags
            await CreateCampaign(webView21, page);

            Step = 4; // Untuk Proses Read Tags
            await ReadCampaign(webView21, page);

            Step = 5; // Untuk Proses Update Tags
            await UpdateCampaign(webView21, page);

            Step = 6; // Untuk Proses Delete Tags
            await DeleteCampaign(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Campaigns - CRUD", "PASS");

         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Campaigns - CRUD", "FAILED");

         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Campaigns - CRUD Selesai");
         }
      }

      public async Task DMALLBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaign - Direct Message - All Blank:");

            Step = 1; //click Quick Message
            await App.Click("//div[@title='Quick Message']", page);

            Step = 15; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            var notiv = await page.WaitForXPathAsync("//div[@id='toast-container']");
            if (notiv != null)
            {
               await notiv.EvaluateFunctionAsync("e => e.remove()");
            }

            Step = 17;
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - All Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - All Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - All Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
      public async Task DMContactBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaign - Direct Message - Contact Blank:");

            Step = 1; //click Quick Message
            await App.ClickBtn("//div[@title='Quick Message']", page);

            Step = 7; //  Input Channel
            await App.InputChannel("//label[text()='Channel']/..//span[text()]", page);

            Step = 8; // Input Account
            await App.ClickFilter("//label[text()='Account']/..//span[text()]", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            var notiv = await page.WaitForXPathAsync("//div[@id='toast-container']");
            if (notiv != null)
            {
               await notiv.EvaluateFunctionAsync("e => e.remove()");
            }

            Step = 13; // Proses Click Close
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Contact Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Contact Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Direct Message - Contact Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DMChannelBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Direct Message - Channel Blank:");

            Step = 1; //click Quick Message
            await App.ClickBtn("//div[@title='Quick Message']", page);

            Step = 2; // Input Contact
            await App.ClickFilter("//label[text()='*Contact']/following-sibling::input", page);

            Step = 8; // Input Account
            await App.ClickFilter("//label[text()='Account']/..//span[text()]", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            var notiv = await page.WaitForXPathAsync("//div[@id='toast-container']");
            if (notiv != null)
            {
               await notiv.EvaluateFunctionAsync("e => e.remove()");
            }

            Step = 13; // Proses Click Close
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Contact Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Contact Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("N", "Campaigns - Direct Message - Channel Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DMAccountBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Direct Message - Account Blank:");

            Step = 1; //click Quick Message
            await App.ClickBtn("//div[@title='Quick Message']", page);

            Step = 2; // Input Contact
            await App.ClickFilter("//label[text()='*Contact']/following-sibling::input", page);

            Step = 7; //  Input Channel
            await App.InputChannel("//label[text()='Channel']/..//span[text()]", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 16; //  Click Close
            var notiv = await page.WaitForXPathAsync("//div[@id='toast-container']");
            if (notiv != null)
            {
               await notiv.EvaluateFunctionAsync("e => e.remove()");
            }

            Step = 13; // Proses Click Close
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Account Blank", "PASS");

            }
            else if (eror == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaign - Direct Message - Account Blank", "FAILED");

            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("N", "Campaigns - Direct Message - Account Blank", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DirectMessage(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Direct Message:");

            Step = 1; //click Quick Message
            await page.WaitForXPathAsync("//div[@title='Quick Message']",new WaitForSelectorOptions() { Visible =true});
            await App.ClickBtn("//div[@title='Quick Message']", page);

            Step = 2; // Input Contact
            await App.ClickFilter("//label[text()='*Contact']/following-sibling::input", page);

            Step = 7; //  Input Channel
            await App.InputChannel("//label[text()='Channel']/..//span[text()]", page);

            Step = 8; // Input Account
            await App.ClickFilter("//label[text()='Account']/..//span[text()]", page);

            Step = 12; // Proses Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13; // Proses Click Close
            await App.ClickBtn("//button[contains(@class, 'ui-dialog-titlebar-close')]", page);

            Step = 13;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Campaign - Direct Message", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Campaign - Direct Message", "PASS");
                App.LogPass("- P - Campaigns - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Campaigns - Direct Message", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

         public async Task AllBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Insert - All Blank:");

            //Step = 4; //  Click Campaign
            //await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - All Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - All Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - All Blank", "FAILED");
            App.NegaFail();
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
            App.Log("- N - Campaigns - Insert - Name Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 9; //  Input Account
            await App.ClickDropdown("//label[text()='*Accounts']/following-sibling::input", page);      
            
            Step = 9; //  Input Account
            await App.InputChannel("//label[text()='*Channel']/../a", page);

            Step = 10; //  Type List
            await App.ClickDropdown("//label[text()='*Lists']/following-sibling::input", page);

            Step = 11; //  Type Message
            await App.InputData("//textarea[@name='BodyText']", "newww baru", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Name Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Name Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Name Blank", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task AccountBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Insert - Account Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Campaign
            await App.InputData("//input[@id='Nobox_Nobox_CampaignDialog12_Name']", "Scrape jual laptop", page);     
            
            Step = 7; //  Input Campaign
            await App.InputChannel("//label[text()='*Channel']/../a", page);

            Step = 10; //  Type List
            await App.ClickDropdown("//label[text()='*Lists']/following-sibling::input", page);

            Step = 11; //  Type Message
            await App.InputData("//textarea[@name='BodyText']", "newww baru", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Account Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Account Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Account Blank", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ChannelBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Insert - Channel Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Campaign
            await App.InputData("//input[@id='Nobox_Nobox_CampaignDialog12_Name']", "Scrape jual laptop", page);

            Step = 9; //  Input Account
            await App.ClickDropdown("//label[text()='*Accounts']/following-sibling::input", page);   
            
            Step = 9; //  Input Account
            await App.ClickBtn("//div[@id='s2id_Nobox_Nobox_CampaignDialog12_ChannelId']//abbr", page);

            Step = 10; //  Type List
            await App.ClickDropdown("//label[text()='*Lists']/following-sibling::input", page);

            Step = 11; //  Type Message
            await App.InputData("//textarea[@name='BodyText']", "newww baru", page);

            Step = 12; //  Click close
            await App.ClickBtn("//div[@id='s2id_Nobox_Nobox_CampaignDialog12_ChannelId']//abbr", page);

            Step = 13; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Channel Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Channel Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Channel Blank", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ListBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N -Campaigns - Insert - List Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Campaign
            await App.InputData("//input[@id='Nobox_Nobox_CampaignDialog12_Name']", "Scrape jual laptop", page);

            Step = 9; //  Input Account
            await App.ClickDropdown("//label[text()='*Accounts']/following-sibling::input", page);  
            
            Step = 10; //  Input Account
            await App.InputChannel("//label[text()='*Channel']/../a", page);

            Step = 11; //  Type Message
            await App.InputData("//textarea[@name='BodyText']", "newww baru", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - List Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - List Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - List Blank", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task MessageBlank(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- N - Campaigns - Insert - Message Blank:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Campaign
            await App.InputData("//input[@id='Nobox_Nobox_CampaignDialog12_Name']", "Scrape jual laptop", page);

            Step = 9; //  Input Account
            await App.ClickDropdown("//label[text()='*Accounts']/following-sibling::input", page);

            Step = 8;
            await App.InputChannel("//label[text()='*Channel']/../a", page);

            Step = 10; //  Type List
            await App.ClickDropdown("//label[text()='*Lists']/following-sibling::input", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 7; // Click Save Tags
            await App.ClickBtn("//button[contains(@class, 'panel-titlebar-close')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error != null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Message Blank", "PASS");
            }
            else if (Error == null)
            {
               ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Message Blank", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "Campaigns - Insert - Message Blank", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task CreateCampaign(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Insert:");

            Step = 4; //  Click Campaign
            await App.ClickBtn("//a[@href='/Nobox/Campaign']", page);

            Step = 5; //  Click Tambah Data List
            await App.ClickBtn("//div[contains(@class, 'add-button')]", page);

            Step = 6; //  Input Campaign
            await App.InputData("//input[@id='Nobox_Nobox_CampaignDialog12_Name']", "Scrape jual laptop", page);
            
            Step = 7; //  Input Campaign
            await App.InputChannel("//label[text()='*Channel']/../a", page);

            Step = 9; //  Input Account
            await App.ClickDropdown("//label[text()='*Accounts']/following-sibling::input", page);

            Step = 10; //  Type List
            await App.ClickDropdown("//label[text()='*Lists']/following-sibling::input", page);

            Step = 11; //  Type Message
            await App.InputData("//textarea[@name='BodyText']", "newww baru", page);

            Step = 12; //  Click Save Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            Step = 13;
            var Error = await page.XPathAsync("//label[@class='error']");
            if (Error.Length > 0)
            {
               ((MyNoBox)frm).Logs("P", "Campaigns - Insert", "FAILED");
            }
            else
            {
               ((MyNoBox)frm).Logs("P", "Campaigns - Insert", "PASS");
               App.LogPass("- P - Campaigns - Insert - PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Insert", "FAILED");
            App.LogFailed();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task ReadCampaign(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Read:");

            Step = 1; //  click Detail Tags
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Read", "PASS");
            App.LogPass("- P - Campaigns - Read - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Read", "FAILED");
            App.LogFailed();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task UpdateCampaign(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Campaigns - Update:");

            await App.Update("Update", "//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Update", "PASS");
            App.LogPass("- P - Campaigns - Update - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Update", "FAILED");
            App.LogFailed();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task DeleteCampaign(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P- Campaigns - Delete:");

            Step = 3; //  Click Read Contact
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            Step = 4; //  Click Delete Contact
            await App.ClickBtn("//div[contains(@class, 'delete-button')]", page);

            Step = 5; //  Click Ya Pop Up
            await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page); ;

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Delete", "PASS");
            App.LogPass("- P - Campaigns - Delete - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("P", "Campaigns - Delete", "FAILED");
            App.LogFailed();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}

