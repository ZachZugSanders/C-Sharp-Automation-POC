using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

public class BrowserFactory
{

    private static BrowserFactory instance = new BrowserFactory();

    //  for completion not used...
    private static string browserType = null;

    private ThreadLocal<FirefoxDriver> threadLocal = new ThreadLocal<FirefoxDriver>();

    private BrowserFactory()
    {
    }

    public static BrowserFactory getInstance()
    {
        return instance;
    }

    public FirefoxDriver getDriver()
    {
        return threadLocal.Value;
    }

    public void removeDriver()
    {
        this.threadLocal.Value.Quit();
        this.threadLocal.Dispose();
    }
}