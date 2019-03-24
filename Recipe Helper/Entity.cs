using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Recipe_Helper
{
    /// <summary>
    /// A representation of an entity in the game.
    /// </summary>
    class Entity
    {
        /// <summary>
        /// The type of the entity.
        /// </summary>
        public string Type;

        /// <summary>
        /// A collection of properties this entity has and their values.
        /// </summary>
        public Dictionary<Property, object> Properties;

        /// <summary>
        /// A collection of required professions and their levels in order to craft this entity.
        /// </summary>
        public Dictionary<Profession, int> ProfessionRequirements;

        /// <summary>
        /// The image of this entity.
        /// </summary>
        public Image Picture;

        public Entity(string type, Dictionary<Property, object> properties, Dictionary<Profession, int> requirements, Image picture)
        {
            Type = type;
            Properties = properties;
            ProfessionRequirements = requirements;
            Picture = picture;
        }
    }
}
