using System.IO;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the hint below. Use '_' for the unknown letters.");
string hint = Console.ReadLine();

string pokemonList = File.ReadAllText(@"..\..\..\..\PokemonList.txt");

string pattern = hint.Replace('_', '.');
Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
Match answer = regex.Match(pokemonList);

Console.WriteLine();
Console.WriteLine(answer.Value);

Console.WriteLine();
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
