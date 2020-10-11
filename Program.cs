using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TestChrome testchrome = new TestChrome();
            //testchrome.zadanie1();
            //testchrome.zadanie2();

            TestFirefox testfirefox = new TestFirefox();
            testfirefox.zadanie1();
          

        }
    }
}
