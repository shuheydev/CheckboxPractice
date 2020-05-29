using CheckboxPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckboxPractice.ViewModels
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public decimal Age { get; set; }

        public IList<Item> Items { get; set; }
    }


}
