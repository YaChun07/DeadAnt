using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDeadAnt
{
    public class DeadAntClass
    {

        public static int deadAntCount(String ants)
        {
            int head = 0;
            int body = 0;
            int feet = 0;
            int deadAntAmount = 0;
            if (ants != null)
            {
                if (ants.Contains("ant"))
                {
                    ants = ants.Replace("ant", "");
                }
              
                for (int i = 0; i < ants.Length; i++)
                {

                    if (ants.ElementAt(i).Equals('a'))
                    {
                        head++;
                    }
                    else if (ants.ElementAt(i).Equals('n'))
                    {
                        body++;
                    }
                    else if (ants.ElementAt(i).Equals('t'))
                    {
                        feet++;
                    }
                    else
                    {
                        continue;
                    }
                    
                }          
                deadAntAmount = Math.Max(feet, Math.Max(head, body));
            }
            return deadAntAmount;
        }
    }
}
