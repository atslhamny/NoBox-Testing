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
    public class ContactTagsFitur
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
                await Search(webView21, page);

                Step = 4; // Untuk Delete Tags
                await Refresh(webView21, page);

                Step = 5; // Untuk Delete Tags
                await ColumnPicker(webView21, page);

                Step = 6; // Untuk Delete Tags
                await Restore(webView21, page);

                Step = 7; // Untuk Delete Tags
                await Excel(webView21, page);

                Step = 8; // Untuk Delete Tags
                await PDF(webView21, page);

                Step = 9; // Untuk Delete Tags
                await Timer(webView21, page);

                ((MyNoBox)frm).Logs("Info", "Contact Tags - Fitur", "PASS");
            }
            catch (Exception ex)
            {
                ((MyNoBox)frm).Logs("Info", "Contact Tags - Fitur", "FAILED");
            }
            finally
            {
                ((MyNoBox)frm).updatestatus("Proses Contact Tags - Fitur Selesai");
            }
        }

        public async Task Search(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Search:");

                Step = 4; // Input Name
                await App.InputSearch("//input[@title='enter the text to search for...']", "contact", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Search", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Search-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Search", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task Refresh(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Refresh:");

                Step = 5; //Click Refresh
                await App.ClickBtn("//div[@class='tool-button refresh-button icon-tool-button']", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Refresh", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Refresh-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Refresh", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task ColumnPicker(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Column Picker:");

                Step = 1; // click columnpicker
                await App.ClickBtn("//div[@class='tool-button column-picker-button icon-tool-button']", page);

                Step = 3; //Click Ok
                await App.ClickBtn("//button[text()='OK']", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Column Picker", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Column Picker-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Column Picker", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task Restore(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Restore:");

                Step = 5; //Click Restore
                await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

                Step = 5; //Click Ok
                await App.ClickBtn("//button[contains(@class, 'btn btn-primary')]", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Restore", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Restore-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Restore", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task Excel(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Excel:");

                Step = 5; //Click Excel
                await App.ClickBtn("//div[@class='tool-button export-xlsx-button no-text']", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Excel", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Excel-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Excel", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task PDF(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - PDF:");

                Step = 5; //Click PDF
                await App.ClickBtn("//div[@class='tool-button export-pdf-button no-text']", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - PDF", "PASS");
                App.LogPass("-P-Contact Tags Fitur-PDF-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - PDF", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task Timer(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Contact Tags Fitur - Auto Refresh:");

                Step = 5; //Click Timer
                await App.ClickBtn("//div[@title='Auto Refresh in 10 seconds']", page);

                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Auto Refresh", "PASS");
                App.LogPass("-P-Contact Tags Fitur-Auto Refresh-PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Contact Tags Fitur - Auto Refresh", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
                isSuccess = false;
            }
        }
    }
}

