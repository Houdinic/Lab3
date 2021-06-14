using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Record
    {
        private string description;
        private string category;
        private float amount;
        private string date;
        public string Description { get; set; }
        public float Amount { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public Record(string despcription, string date, string category = "Empty", float amount = 0)
        {

        }


    }
}
