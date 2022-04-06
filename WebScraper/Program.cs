using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//get driver instance
IWebDriver driver = new ChromeDriver();

//set scraping url
driver.Url = "https://toptalent.co/turkiyedeki-universiteler-listesi";

//get table element
IWebElement table = driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div/div[4]/div/div/div[1]/table"));

//select all rows
IList<IWebElement> rows = table.FindElements(By.TagName("tr"));

//foreach rows
foreach (var item in rows)
{
    //select all columns
    IList<IWebElement> columns = item.FindElements(By.TagName("td"));

    //foreach columns
    Console.WriteLine(columns[2].Text);
    Console.WriteLine(columns[3].Text);
    Console.WriteLine(columns[4].Text);
}
