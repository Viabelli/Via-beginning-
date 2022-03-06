using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    public class KarşılaştırmaMetodDefans_Atak
    {
        public int Add(Character x, List<Character> y)
        {
            var puan = 0;
            var normaldefans = x.Defence;

            foreach (var item in y)
            {
                x.Defence = normaldefans;
                var normalattack1 = item.Attack;
                if (x.Burc == item.AntiBurc && x.AntiBurc == item.Burc)
                {
                    x.Defence += item.Anti;
                    item.Attack += x.Anti;
                    if (x.Defence > item.Attack)
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
                    if (x.Defence > item.Attack)
                    {
                        puan += 2;
                    }
                    item.Attack = normalattack1;
                    continue;
                }
                if (x.Burc == item.AntiBurc)
                {
                    x.Defence += item.Anti;
                    if (x.Defence > item.Attack)
                    {
                        puan += 2;
                    }
                    continue;
                }
                if (x.Burc == item.EtkiBurc)
                {
                    item.Attack += item.Etki;
                    if (x.Defence > item.Attack)
                    {
                        puan += 2;
                    }
                    item.Attack = normalattack1;
                    continue;
                }
                if (x.EtkiBurc == item.Burc)
                {
                    x.Defence += x.Etki;
                    if (x.Defence > item.Attack)
                    {
                        puan += 2;
                    }
                    continue;
                }
                if (x.AntiBurc == item.Burc)
                {
                    item.Attack += x.Anti;
                    if (x.Defence > item.Attack)
                    {
                        puan += 2;
                    }
                    item.Attack = normalattack1;
                    continue;
                }
                if (x.Defence > item.Attack)
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
