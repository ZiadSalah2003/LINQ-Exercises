List<int> n1 = new List<int> { 3, 9, 2, 8, 6, 5 };
var result = n1.Select(x => x * x);
foreach (var x in result)
	Console.WriteLine(x);