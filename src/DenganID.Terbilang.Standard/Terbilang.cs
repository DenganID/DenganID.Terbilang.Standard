using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DenganID.Terbilang.Standard
{
    public class Terbilang : ITerbilang
    {
        private string Run(long number, bool hasNol = false)
        {
            string result = "";
            Dictionary<int, string> satuan = new Dictionary<int, string>();
            if (hasNol)
            {
                satuan.Add(0, "nol");
            }
            else
            {
                satuan.Add(0, "");
            }
            satuan.Add(1, "satu");
            satuan.Add(2, "dua");
            satuan.Add(3, "tiga");
            satuan.Add(4, "empat");
            satuan.Add(5, "lima");
            satuan.Add(6, "enam");
            satuan.Add(7, "tujuh");
            satuan.Add(8, "delapan");
            satuan.Add(9, "sembilan");
            satuan.Add(10, "sepuluh");
            satuan.Add(11, "sebelas");
            satuan.Add(12, "dua belas");

            if (number < 12)
            {
                result = satuan[Convert.ToInt32(number)];
            }
            else if (number < 20)
            {
                result = $"{Run(number - 10)} belas";
            }
            else if (number < 100)
            {
                result = $"{Run(number / 10)} puluh {Run(number % 10)}";
            }
            else if (number < 200)
            {
                result = $"seratus {Run(number - 100)}";
            }
            else if (number < 1000)
            {
                result = $"{Run(number / 100)} ratus {Run(number % 100)}";
            }
            else if (number < 2000)
            {
                result = $"seribu {Run(number - 1000)}";
            }
            else if (number < 1000000)
            {
                result = $"{Run(number / 1000)} ribu {Run(number % 1000)}";
            }
            else if (number < 2000000)
            {
                result = $"satu juta {Run(number - 1000000)}";
            }
            else if (number < 1000000000)
            {
                result = $"{Run(number / 1000000)} juta {Run(number % 1000000)}";
            } else if (number < 2000000000)
            {
                result = $"satu milyar {Run(number - 1000000000)}";
            } else if (number < 2000000000000)
            {
                result = $"satu triliun {Run(number - 1000000000000)}";
            }
            else if (number < 1000000000000000)
            {
                result = $"{Run(number / 1000000000000)} triliun {Run(number % 1000000000000)}";
            }
            
            return result.Trim();
        }
        public string From(int number)
        {
            return Run(number);
        }

        public string From(long number)
        {
            return Run(number);
        }
        
        
        public string From(float number)
        {
            return Run(Convert.ToInt64(number));
        }

        public async Task<string> FromAsync(int number)
        {
            return await Task.FromResult<string>(From(number));
        }

        public async Task<string> FromAsync(long number)
        {
            return await Task.FromResult<string>(From(number));
        }

        
        public async Task<string> FromAsync(float number)
        {
            return await Task.FromResult<string>(From(number));
        }
    }
}