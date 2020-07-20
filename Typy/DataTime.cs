using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    public struct DataTime
    {

    }

    public enum PayrollType
    {
        //domyślnie pierwszy typ przyjmuje wartość '0', a później domyślnie przjmuje całkowite
        Contractor = 1,
        Salaries,
        Executive,
        Hourly
    }
}
