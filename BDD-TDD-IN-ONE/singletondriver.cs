using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BDD_TDD_IN_ONE
{
    public class singletondriver
    {
        public static IWebDriver driver = new ChromeDriver();        

    }
}
