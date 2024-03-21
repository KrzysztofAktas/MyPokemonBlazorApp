using MyPokemonBlazorApp.Model;

namespace MyPokemonBlazorApp.Components.Pages
{
    public class PokemonImageGrabber
    {
        private const string NOT_FOUND = "img/notfound.png";

        public string GetImageUrl(Pokemon pokemon)
        {
            if (pokemon is null) return NOT_FOUND;

            var name = pokemon.Name.Split("Mega")[0]
                .Replace("'", string.Empty)
                .Replace("♀", "-f")
                .Replace("♂", "-m")
                .Replace(". ", "-")
                .Replace("Plant Cloak", "")
                .Replace("Primal Kyogre", "")
                .Replace("Primal Groudon", "")
                .Replace("Normal Forme", "")
                .Replace("Attack Forme", "")
                .Replace("Defence Forme", "")
                .Replace("Speed Forme", "")
                .Replace("Hoopa Confined", "")
                .Replace("Hoopa Unbound", "")
                .Replace("Average Size", "")
                .Replace("Small Size", "")
                .Replace("Large Size", "")
                .Replace("Super Size", "")
                .Replace("Blade Forme", "")
                .Replace("Shield Forme", "")
                .Replace("MeowsticMale", "Meowstic-Male")
                .Replace("MeowsticFemale", "Meowstic-Female")
                .Replace(" Forme", "")
                .Replace("Heat Rotom", "")
                .Replace("Wash Rotom", "")
                .Replace("Frost Rotom", "")
                .Replace("Fan Rotom", "")
                .Replace("Mow Rotom", "")
                .Replace(" Jr.", "-jr")
                .ToLowerInvariant();

            var imageUrl = $"https://img.pokemondb.net/artwork/large/{name}.jpg";
            return imageUrl;
        }
    }
}
