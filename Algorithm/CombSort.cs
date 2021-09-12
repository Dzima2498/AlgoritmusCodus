using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CombSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            int step = (int)(Items.Count / 1.247330950103979);
            while (step > 0)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    int j = i;
                    while ((Items.Count > step + j)&& (Compare(Items[j], Items[j + step]) == 1))
                    {
                      Swop(j, j + step);
                      j++;
                        
                    }
                }

                step = (int)(step/1.247330950103979);
            }
        }
    }
}
