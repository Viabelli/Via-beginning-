using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    public class KarşılaştırmaMetodAtak_Defans
    {
        public int Add(Character x, List<Character> y)
        {
            var puan = 0;
            var normalatak = x.Attack;

            foreach (var item in y)
            {
                x.Attack = normalatak;
                var normalattack1 = item.Defence;
                if (x.Name == item.Name)
                {
                    continue;
                }
                if (x.Burc == item.AntiBurc && x.AntiBurc == item.Burc)
                {
                    x.Attack += item.Anti;
                    item.Defence += x.Anti;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    item.Defence = normalattack1;
                    continue;
                }
                if (x.Burc == item.EtkiBurc && x.AntiBurc == item.Burc)
                {
                    item.Defence += item.Etki;
                    item.Defence += x.Anti;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    item.Defence = normalattack1;
                    continue;
                }
                if (x.Burc == item.AntiBurc)
                {
                    x.Attack += item.Anti;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    continue;
                }
                if (x.Burc == item.EtkiBurc)
                {
                    item.Defence += item.Etki;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    item.Defence = normalattack1;
                    continue;
                }
                if (x.EtkiBurc == item.Burc)
                {
                    x.Attack += x.Etki;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    continue;
                }
                if (x.AntiBurc == item.Burc)
                {
                    item.Defence += x.Anti;
                    if (x.Attack > item.Defence)
                    {
                        puan += 2;
                    }
                    item.Defence = normalattack1;
                    continue;
                }
                if (x.Attack > item.Defence)
                {
                    puan += 2;
                    continue;
                }

                continue;
            }

            return puan;
        }
    }
}
