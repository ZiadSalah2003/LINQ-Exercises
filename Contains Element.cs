List<string> n1 = new List<string> { "John", "Mary", "David", "Sarah" };
var result = n1.Where(x => x.Contains('a'));
foreach (var x in result)
	Console.WriteLine(x);