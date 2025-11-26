using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public class LoginNobox
   {

      Form frm = Application.OpenForms["MyNoBox"];

      string url = App.UrlUtama;

      WebView2DevToolsContext page;

      public bool isSuccess = true;


      public void stopTrue()
      {

      }

      public async Task Start(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {

         int Step = 0;
         try
         {
            Step = 2; // Blank Login
            await BlankLogin(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            Step = 3; //Login Tanpa Username
            await LoginBlankEmail(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            Step = 4; //Login Tanpa Password
            await LoginBlankPassword(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            Step = 5; //Login Tanpa Password
            await LoginWrongPassword(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            Step = 6;// untuk login
            await LoginNoCaptha(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            Step = 7;// untuk login
            await Login(webView21, page);

            if (((MyNoBox)frm).IsStopped == true) { ((MyNoBox)frm).StopToStart(); return; }

            ((MyNoBox)frm).Logs("Info", "Auto Login", "PASS");
         }
         catch (Exception ex)
         {
            ((MyNoBox)frm).Logs("Info", "Auto Login", "FAILED");
         }
         finally
         {
            ((MyNoBox)frm).StopToStart();
         }
      }

      public async Task BlankLogin(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Navigate($"{UrlTarget}");

            App.Log("- N - AutoLogin - Blank Sign In");

            Step = 3; // click Sign In
            await App.ClickBtn("//button [@type = 'submit']", page);

            Step = 6;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Sign In", "PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Sign In", "FAILED");
               App.NegaPass("-N-AutoLogin-Blank Sign In-PASS");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Sign In", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task LoginBlankEmail(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Reload();

            App.Log("- N - AutoLogin - Blank Email");

            var Success = await page.WaitForXPathAsync("//div[contains(@class, 'Recaptcha')]", new WaitForSelectorOptions() { Visible = true });

            Step = 3;
            await App.InputData("//input[@name='Username']", "", page);

            Step = 4;
            await App.InputData("//input[@name='Password']", "qwerty123", page);

            Step = 5; // click Sign In
            await App.ClickBtn("//button[@type = 'submit']", page);

            Step = 6;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Email", "PASS");
               App.NegaPass("-N-AutoLogin-Blank Password-PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Email", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Email", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task LoginBlankPassword(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Reload();

            App.Log("- N - AutoLogin - Blank Password");

            var Success = await page.WaitForXPathAsync("//div[contains(@class, 'Recaptcha')]", new WaitForSelectorOptions() { Visible = true });

            Step = 3;
            await App.InputData("//input[@name='Username']", "agielreri@gmail.com", page);

            Step = 4;
            await App.InputData("//input[@name='Password']", "", page);

            Step = 5; // click Sign In
            await App.ClickBtn("//button[@type = 'submit']", page);

            Step = 6;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Password", "PASS");
               App.NegaPass("-N-AutoLogin-Blank Password-PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Password", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "AutoLogin - Blank Password", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task LoginWrongPassword(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Reload();

            App.Log("- N - AutoLogin - Wrong Password");

            var Success = await page.WaitForXPathAsync("//div[contains(@class, 'Recaptcha')]", new WaitForSelectorOptions() { Visible = true });

            Step = 3;
            await App.InputData("//input[@name='Username']", "agielreri@gmail.com", page);

            Step = 4;
            await App.InputData("//input[@name='Password']", "yondagtaukoktanyasaya", page);

            Step = 5; // click Sign In
            await App.ClickBtn("//button[@type = 'submit']", page);

            Step = 6;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Wrong Password", "PASS");
               App.NegaPass("-N-AutoLogin-Wrong Password-PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Wrong Password", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("N", "AutoLogin - Wrong Password", "FAILED");
            App.NegaFail();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task LoginNoCaptha(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Reload();

            App.Log("- N - Autologin - Login No Captha");

            Step = 3;
            await App.InputData("//input[@name='Username']", "agielreri@gmail.com", page);

            Step = 4;
            await App.InputData("//input[@name='Password']", "qwerty123", page);

            Step = 5; // click Sign In
            await App.ClickBtn("//button[@type = 'submit']", page);

            Step = 6;
            var eror = await page.XPathAsync("//label[@class='error']");
            if (eror != null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Login No Captha", "PASS");
               App.NegaPass("-N-AutoLogin-Login No Captha-PASS");
            }
            else if(eror == null)
            {
               ((MyNoBox)frm).Logs("N", "AutoLogin - Login No Captha", "FAILED");
            }
            MyNoBox.count.PASS++;
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            App.NegaFail();
            ((MyNoBox)frm).Logs("N", "AutoLogin - Login No Captha", "FAILED");
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }

      public async Task Login(Microsoft.Web.WebView2.WinForms.WebView2 webView21, WebView2DevToolsContext page)
      {
         MyNoBox.count.Test++;
         int Step = 0;
         try
         {
            Step = 1; // set url target
            string UrlTarget = url;

            Step = 2; // pergi ke url target
            webView21.CoreWebView2.Reload();

            App.Log("- P - AutoLogin");

            var Success = await page.WaitForXPathAsync("//div[contains(@class, 'Recaptcha')]", new WaitForSelectorOptions() { Visible = true });

            Step = 3;
            await App.InputData("//input[@name='Username']", "agielreri@gmail.com", page);

            Step = 4;
            await App.InputData("//input[@name='Password']", "qwerty123", page);

            await Task.Delay(8000);

            Step = 5; // click Sign In
            await App.ClickBtn("//button [@type = 'submit']", page);

            await page.WaitForXPathAsync("//div[text()='Dashboard']");

            MyNoBox.count.PASS++;
            ((MyNoBox)frm).Logs("P", "Auto Login", "PASS");
            App.LogPass("-P-Auto Login-PASS");
         }
         catch (Exception ex)
         {
            MyNoBox.count.FAILED++;
            ((MyNoBox)frm).Logs("P", "Auto Login", "FAILED");
            App.LogFailed();
            App.LogFile.Write(Serilog.Events.LogEventLevel.Error, $"{Step} {ex.Message}");
            isSuccess = false;
         }
      }
   }
}

