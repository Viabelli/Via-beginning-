using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    public class KarşılaştırmaMetotAtak_Atak
    {
        public int Add(Character x,List<Character> y)
        {
            var puan = 0;
            var normalatak = x.Attack;
            
                foreach (var item in y)
                {
                x.Attack = normalatak;
                var normalattack1 = item.Attack;    
                    if (x.Burc == item.AntiBurc && x.AntiBurc == item.Burc)
                    {
                        x.Attack += item.Anti;
                        item.Attack += x.Anti;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                    item.Attack = normalattack1;
                    continue;
                    }
                    if (x.Burc == item.EtkiBurc && x.AntiBurc == item.Burc)
                    {
                        item.Attack += item.Etki;
                        item.Attack += x.Anti;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                    item.Attack = normalattack1;
                    continue;
                    }
                    if (x.Burc == item.AntiBurc)
                    {
                        x.Attack += item.Anti;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                        continue;
                    }
                    if (x.Burc == item.EtkiBurc)
                    {
                        item.Attack += item.Etki;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                    item.Attack = normalattack1;
                    continue;
                    }
                    if (x.EtkiBurc == item.Burc)
                    {
                        x.Attack += x.Etki;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                        continue;
                    }
                    if (x.AntiBurc == item.Burc)
                    {
                        item.Attack += x.Anti;
                        if (x.Attack > item.Attack)
                        {
                            puan += 2;
                        }
                    item.Attack = normalattack1;
                    continue;
                    }
                    if (x.Attack > item.Attack)
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
