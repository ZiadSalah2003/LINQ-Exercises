List<string> n1 = new List<string> { "John", "Mary", "David", "Sarah" };
var result = n1.Skip(2);
foreach (var x in result)
	Console.WriteLine(x);