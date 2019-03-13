using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Recipe_Helper
{
    /// <summary>
    /// Represent a profession in the game.
    /// </summary>
    class Profession
    {
        /// <summary>
        /// This profession's displayed name.
        /// </summary>
        string Name;

        /// <summary>
        /// The image to be displayed for this profession.
        /// </summary>
        Image Picture;

        /// <summary>
        /// The level to which the character has raised this profession.
        /// </summary>
        int Level;

        public Profession(string name, Image picture, int level)
        {
            Name = name;
            Picture = picture;
            Level = level;
        }
    }
}
