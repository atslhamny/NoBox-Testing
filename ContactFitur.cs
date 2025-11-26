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
   public class ContactFitur
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
            Step = 2;
            await FilterCategory(webView21, page);

            Step = 3; // Filter Country
            await FilterCountry(webView21, page);

            Step = 4;  // Filter State
            await FilterState(webView21, page);

            Step = 5; // Filter City
            await FilterCity(webView21, page);

            Step = 5; // Filter City
            await FilterTool(webView21, page);

            Step = 5; // Filter City
            await FilterList(webView21, page);

            Step = 5; // Filter City
            await FilterTags(webView21, page);

            Step = 11; // rstore
            await GoogleContact(webView21, page);

            Step = 12; // rstore
            await VCard(webView21, page);

            ((MyNoBox)frm).Logs("Info", "Contact - Fitur", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Contact - Fitur", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).updatestatus("Proses Contact - Fitur Selesai");
         }
      }

      public async Task FilterCategory(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter Category:");

            Step = 5; // Filter Country
            await App.Click("//div[@class='slick-cell l2 r2']/a", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Category", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter Category - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Category", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterCountry(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter Country:");

            Step = 3; // Filter Country
            await App.FilterNegara("//div [@id='s2id_Nobox_Nobox_LeadGrid0_QuickFilter_Country']", "Indonesia", page);

            Step = 4;
            await App.Click("//span[text()='Country']/following-sibling::div//abbr", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Country", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter Country - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Country", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterState(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter State:");

            Step = 1;
            await App.FilterNegara("//div[@id='s2id_Nobox_Nobox_LeadGrid0_QuickFilter_State']", "East Java", page);

            Step = 4;
            await App.Click("//span[text()='State']/following-sibling::div//abbr", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter State", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter State - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter State", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
      public async Task FilterCity(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter City:");

            Step = 1; // Click Search Status
            await App.FilterNegara("//div[@id='s2id_Nobox_Nobox_LeadGrid0_QuickFilter_City']", "Bangkalan", page);

            Step = 4;
            await App.Click("//span[text()='City']/following-sibling::div//abbr", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter City", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter City - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter City", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task FilterTool(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter Tool:");

            Step = 3; // click categori
            await App.ClickFilter("//div[@id='s2id_Nobox_Nobox_LeadGrid0_QuickFilter_Tool']", page);

            Step = 4;
            await App.Click("//span[text()='Tool']/following-sibling::div//abbr", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Tool", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter Tool - PASS");

         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Tool", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
      public async Task FilterList(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Filter List:");

            Step = 1; // Type List
            await App.ClickFilter("//input[@id='s2id_autogen5']", page);

            Step = 2;
            await App.Click("//a[@class='select2-search-choice-close']", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter List", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter List - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter List", "PASS");
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
            App.Log("- P - Contacts Fitur - FilterTags:");

            Step = 1; // Type List
            await App.ClickFilter("//input[@id='s2id_autogen6']", page);

            Step = 2; // Type List
            await App.Click("//a[@class='select2-search-choice-close']", page);

            Step = 3;
            await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Tags", "PASS");
            App.LogPass("- P - Contacts Fitur - Filter Tags - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Filter Tags", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task GoogleContact(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            App.Log("- P - Contacts Fitur - Google Contacts:");

            Step = 5; // Klik Download Google Contacts
            await App.ClickBtn("//div[@title='Export to Google Contacts file import']", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Google Contacts", "PASS");
            App.LogPass("- P - Contacts Fitur - Google Contacts - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - Google Contacts", "FAILED");
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
            App.Log("- P - Contacts Fitur - VCard:");

            Step = 1; // Klik Value
            await App.Click("//div[@class='slick-cell l0 r0']/a", page);

            Step = 2; // Klik VCard
            await App.ClickBtn("//div[contains(@class, 'btn-vcard')]", page);

            Step = 3; // Click Save Campaign Tags
            await App.ClickBtn("//div[contains(@class, 'save-and-close-button')]", page);

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - VCard", "PASS");
            App.LogPass("- P - Contacts Fitur - VCard - PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.LogFailed();
            ((MyNoBox)frm).Logs("P", "Contacts Fitur - VCard", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }

      }
   }
}