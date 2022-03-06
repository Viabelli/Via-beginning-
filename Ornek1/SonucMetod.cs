using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class SonucMetod
    {
        public void Sonuc(List<Character>  x, List<Character> y)
        {
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            KarşılaştırmaMetotAtak_Atak metot1 = new KarşılaştırmaMetotAtak_Atak();
            KarşılaştırmaMetodAtak_Defans metot2 = new KarşılaştırmaMetodAtak_Defans();
            KarşılaştırmaMetodDefans_Atak metot3 = new KarşılaştırmaMetodDefans_Atak();
            foreach (var item in x)
            {
                result1 = metot1.Add(item, y);
                result2 = metot2.Add(item, y);
                result3 = metot3.Add(item, y);  
                
                Console.WriteLine(item.Name + " puanı = " + (result1+result2+result3)/3);
            }

            
        }
    }
}
