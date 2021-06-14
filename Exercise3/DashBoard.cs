using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class DashBoard
    {
        public static void Run()
        {
            Menu menu = new Menu();
            int userChoice = menu.PrintOptions();
            switch (userChoice)
            {
                default:
                    break;
                case (int)Options.Add:
                    ManageRecord.Add();
                    break;
                case (int)Options.Delete:
                    ManageRecord.DeleteData();
                    break;
                case (int)Options.Modify:
                    ManageRecord.ModifyTab();
                    break;
                case (int)Options.Normalization:
                    ManageRecord.NormalizeDescriptions();
                    break;
                case (int)Options.Search:
                    Console.WriteLine("Please enter the keyword you want to search");
                    ManageRecord.SearchText(Console.ReadLine());
                    break;
                case (int)Options.Show:
                    Console.WriteLine("Please enter the Category you want to search");
                    ManageRecord.SearchCategory(Console.ReadLine());
                    break;
                case (int)Options.Sort:
                    ManageRecord.SortData();
                    break;
            }
        }
        
    }
}
