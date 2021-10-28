using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.IO;
using System.IO.Compression;

namespace SeleniumChomeStandAloneTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            
            var localChromeLocation = GetChrome();

            ChromeDriver driver;
            if (localChromeLocation != null)
            {
                options.BinaryLocation = localChromeLocation;
                driver = new ChromeDriver(options);
            }else
            {
                driver = new ChromeDriver();
            }
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Url"]);
        }

        static string GetChrome()
        {
            var chromeVersion = ConfigurationManager.AppSettings["ChromeVersion"];
            var actualPath = Directory.GetCurrentDirectory();

            var chromeExecutable = @$"{actualPath}\Chrome\{chromeVersion}\chrome.exe";

            var executeChromeFile = "";
            if (File.Exists(chromeExecutable))
            {
                //O arquivo do Chrome existe, então o Chrome já foi descompactado
                executeChromeFile = chromeExecutable;
                var para = "";
            }
            else
            {
                //O arquivo do Chrome NÃO existe, então o Chrome AINDA NÃO FOI descompactado
                var zipFile = $@"{actualPath}\Chrome\{chromeVersion}.zip";
                if (File.Exists(zipFile))
                {
                    Console.WriteLine($"-> Iniciando descompactação do Chrome na versão {chromeVersion}");
                    var zipFileDestinatio = $@"{actualPath}\Chrome\\";
                    ZipFile.ExtractToDirectory(zipFile, zipFileDestinatio);
                    Console.WriteLine("-> Descompactado");
                    return GetChrome();
                }
                else
                {
                    //Arquivo não existe
                    executeChromeFile = null;
                }
            }

            return executeChromeFile;
        }
    }
}
