using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Recipe_Helper
{
    /// <summary>
    /// A property that an entity can have.
    /// </summary>
    class Property
    {
        /// <summary>
        /// This property's displayed name.
        /// </summary>
        public string Name;

        /// <summary>
        /// The data type this property's value is treated as.
        /// </summary>
        public Type ValueType;

        /// <summary>
        /// The icon displayed for this property.
        /// </summary>
        public Image Picture;

        public Property(string name, Type valueType, Image picture)
        {
            Name = name;
            ValueType = valueType;
            Picture = picture;
        }
    }
}
