List<char> n1 = new List<char>();
for (char c = 'a'; c <= 'z'; c++)
	n1.Add(c);
n1.Add('a');
n1.Add('z');
var result = n1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
foreach (var x in result)
	Console.WriteLine($"Character: {x.Key}, Frequency: {x.Value}");