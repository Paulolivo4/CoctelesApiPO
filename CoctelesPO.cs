using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoctelesApiPO
{
    public class CocktailResponse
    {
        public List<Cocktail> Drinks { get; set; }
    }

    public class Cocktail
    {
        public string StrDrink { get; set; }
        public string StrDrinkThumb { get; set; }
        public string StrInstructions { get; set; }
    }

}
