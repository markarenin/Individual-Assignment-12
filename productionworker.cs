using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_12
{
    internal class ProductionWorker : Employee
    {
        private int shift_number;
        private decimal hourly_part_rate;

        public ProductionWorker(string name, int number, int shift_number, decimal hourly_part_rate)
        {
            this.Name = name;
            this.Number = number;
            this.shift_number = shift_number;
            this.hourly_part_rate = hourly_part_rate;
        }

        public int Shift_number { 
            get => shift_number;
            set
            {
                if (value > 3)
                {
                    MessageBox.Show("The Shift Number can not be higher than 3");
                } else
                {
                    this.shift_number = value;
                }
            }
        }
        public decimal Hourly_part_rate { get => hourly_part_rate; set => hourly_part_rate = value; }

        public String get_shift_number_value()
        {
            switch (this.shift_number)
            {
                case 1: return "Day shift";
                case 2: return "Night shift";
                default:
                    return "Day & Night shift";
            }
        }
    }
}
