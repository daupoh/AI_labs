using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    static class SCValidator
    {
        const string c_sNotValidReferencer = "Ошибка: Ссылка не указывает на объект!";

        public static void CheckReferenceIsNotNull(Object rObject)
        {
            string sParameters = "with object is " + rObject.ToString();
            if (rObject == null)
            {
                Debug.WriteLine(c_sNotValidReferencer + sParameters);
                throw new FormatException(c_sNotValidReferencer);
            }
        }
    }
}
