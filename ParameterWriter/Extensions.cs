using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterWriter
{
    public static class Extensions
    {
        public static long GetElementId(this Element elem)
        {
#if R2017 || R2018 || R2019 || R2020 || R2021 || R2022 || R2023
            return (long)elem.Id.IntegerValue;
#else
            return elem.Id.Value;
#endif
        }

    }
}
