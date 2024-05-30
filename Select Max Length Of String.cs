List<string> n1 = new List<string> { "John", "Mary", "David", "Sarah" };
var result = n1.Where(x => x.Length > 4);
foreach (var x in result)
	Console.WriteLine(x);