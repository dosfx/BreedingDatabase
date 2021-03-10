using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedingDatabase
{
    public enum BreedingType
    {
        Unrolled = 0,
        Mutant = 1,
        CommonUncommon = 2,
        Hybrid = 3
    }

    public static class BreedingTypeExtensions
    {
        private static readonly string[] PetTypeNames =
        {
            string.Empty,
            "Mutant",
            "C/UC",
            "Hybrid"
        };

        private static readonly Color[] PetTypeColors =
        {
            SystemColors.Window,
            ColorTranslator.FromHtml("#edff97"),
            ColorTranslator.FromHtml("#cfe2f3"),
            ColorTranslator.FromHtml("#fce8b2")
        };

        public static string GetName(this BreedingType petType)
        {
            return PetTypeNames[(int)petType];
        }

        public static Color GetColor(this BreedingType petType)
        {
            return PetTypeColors[(int)petType];
        }
    }
}
