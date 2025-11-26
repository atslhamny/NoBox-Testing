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
    public class CampaignsTagsFitur
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
                Step = 3; // Untuk Search
                await Search(webView21, page);

                Step = 4; // Untuk Refresh Halaman Campaign  Tags
                await Refresh(webView21, page);

                Step = 5; // Untuk Pick ColoumPicker
                await ColoumPicker(webView21, page);

                Step = 6; // Untuk Restore Data
                await Restore(webView21, page);

                Step = 7; // Untuk Generate Data Ke Excel
                await ExcelGenerator(webView21, page);

                Step = 8; // Untuk Generate Data Ke Pdf
                await PdfGenerator(webView21, page);

                Step = 9; // Untuk AutoRefresh
                await AutoRefresh(webView21, page);

                ((MyNoBox)frm).Logs("Info", "Campaigns Tags - Fitur", "PASS");
            }
            catch (Exception ex)
            {
                ((MyNoBox)frm).Logs("Info", "Campaigns Tags - Fitur", "FAILED");
            }
            finally
            {
                ((MyNoBox)frm).updatestatus("Proses Campaigns Tags - Fitur Selesai");
            }
        }

        public async Task Search(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - Search:");

                Step = 4; //  Input Name
                await App.InputSearch("//input[@title='enter the text to search for...']", "Test", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Search", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Search - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Search", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }


        public async Task Refresh(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - Refresh:");

                Step = 1;
                await App.ClickBtn("//div[@class='tool-button refresh-button icon-tool-button']", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Refresh", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Refresh - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Refresh", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task ColoumPicker(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - Column Picker:");

                Step = 1; // Click Coloum Picker
                await App.ClickBtn("//div[contains(@class, 'column-picker-button')]", page);

                Step = 3; // Klik Ok untuk menutup Proses
                await App.ClickBtn("//button[text()='OK']", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Column Picker", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Column Picker - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Column Picker", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task Restore(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - Restore:");

                Step = 1; // Klik Button Restore
                await App.ClickBtn("//div[@title='Restore to default grid settings']", page);

                Step = 2; // Klik Button Yes
                await App.ClickBtn("//button[text()='Yes']", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Restore", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Restore - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Restore", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }

        }

        public async Task ExcelGenerator(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur-Excel:");

                Step = 1; // Klik Button Excel
                await App.ClickBtn("//div[contains(@class, 'export-xlsx-button')]", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Excel", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Excel - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Excel", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task PdfGenerator(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - PDF:");

                Step = 1; // Klik Button Excel
                await App.ClickBtn("//div[contains(@class, 'export-pdf-button')]", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - PDF", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - PDF - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - PDF", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }

        public async Task AutoRefresh(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
        {
            int Step = 0;
            try
            {
                App.Log("- P - Campaigns Tags Fitur - Auto Refresh:");

                Step = 5; //Click Timer
                await App.ClickBtn("//div[@title='Auto Refresh in 10 seconds']", page);

                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Auto Refresh", "PASS");
                App.LogPass("- P - Campaigns Tags Fitur - Auto Refresh - PASS");
            }
            catch (Exception ex)
            {
                App.LogFailed();
                ((MyNoBox)frm).Logs("P", "Campaigns Tags Fitur - Auto Refresh", "FAILED");
                App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} : {ex.Message}");
                isSuccess = false;
            }
        }
    }
}

