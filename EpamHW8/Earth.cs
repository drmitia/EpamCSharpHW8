using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW8
{
    internal class Earth : HeavenlyBody
    {
        public override void ReportAboutLife()
        {
            Console.WriteLine("Життя присутнє");
        }
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Земля обертається навколо Сонця");
        }
        
    }
}
