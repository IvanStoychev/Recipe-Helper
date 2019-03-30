using Recipe_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Helper.ViewModels
{
    class PropertyDisplayViewModel
    {
        public static List<string> GetPropertyTypes()
        {
            return PropertyDisplayModel.PropertyTypes;
        }
    }
}
