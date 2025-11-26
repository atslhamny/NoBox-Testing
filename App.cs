using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Serilog;
using WebView2.DevTools.Dom;

namespace MyNoBoxWinForm
{
   public static class App
   {
      public static string UrlUtama = "https://id.mynobox.com";

      // penanganan untuk console dan serilog
      public static ILogger LogFile;

      public static void Setup()
      {
         LogFile = new LoggerConfiguration().WriteTo.File(@"D:\KerjaanUbig\SoftwareTesting\MyNoBoxWinForm\MyNoBoxWinForm\Log\Test - MyNoBox -  " + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".txt").CreateLogger();
      }

      public static void Log(string teks)
      {
         Console.ForegroundColor = ConsoleColor.White;
         Console.Write(DateTime.Now.ToString("HH:mm:ss"));
         Console.Write(teks);
      }

      public static void LogPass(string text)
      {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("PASS");
         LogFile.Write(Serilog.Events.LogEventLevel.Information, text);
      }
      public static void LogFailed()
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("FAILED");
      }
      public static void NegaFail()
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("FAILED");
      }
      public static void NegaPass(string text)
      {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("PASS");
         LogFile.Write(Serilog.Events.LogEventLevel.Information, text);
      }

      // penanganan fungsi click+input data dll
      public static async Task ClickFilter(string selector, WebView2DevToolsContext page)
      {
         var Click = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await Click.ClickAsync();
         await Task.Delay(1000);
         await Click.PressAsync("Enter");
      }

      public static async Task Click(string selector, WebView2DevToolsContext page)
      {
         await Task.Delay(1000);
         var Clickk = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await Clickk.ClickAsync();
      }

      public static async Task ClickBtn(string selector, WebView2DevToolsContext page)
      {
         var ClickBtn = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await ClickBtn.EvaluateFunctionAsync("e => e.click()");
      }

      public static async Task InputData(string selector, string input, WebView2DevToolsContext page)
      {
         var InputData = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await InputData.TypeAsync(input);
      }

      public static async Task ClickDropdown(string selector, WebView2DevToolsContext page)
      {
         var Click = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await Click.ClickAsync();
         await Task.Delay(1000);
         await page.Keyboard.PressAsync("Enter");
      }     
      
      public static async Task InputChannel(string selector, WebView2DevToolsContext page)
      {
         var Click = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await Click.ClickAsync();
         await Task.Delay(1000);
         await page.Keyboard.TypeAsync("Telegram");
         await Task.Delay(1000);
         await page.Keyboard.PressAsync("Enter");
      }

      public static async Task FilterNegara(string selector, string input, WebView2DevToolsContext page)
      {
         var Click = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await Click.ClickAsync();
         await Task.Delay(1000);
         await Click.TypeAsync(input);
         await Task.Delay(1000);
         await Click.PressAsync("Enter");
      }

      public static async Task InputSearch(string selector, string input, WebView2DevToolsContext page)
      {
         var InputData = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await InputData.TypeAsync(input);
         await page.Keyboard.PressAsync("Enter");
      }

      public static async Task Update(string input, string selector, WebView2DevToolsContext page)
      {
         await page.Keyboard.TypeAsync(input);
         var ClickBtn = await page.WaitForXPathAsync(selector, new WaitForSelectorOptions() { Visible = true });
         await ClickBtn.EvaluateFunctionAsync<string>("e => e.click()");
      }
   }
}
