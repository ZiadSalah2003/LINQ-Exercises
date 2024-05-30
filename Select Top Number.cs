List<int> n1 = new List<int> { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
var result = n1.Take(5);
foreach (var x in result)
	Console.WriteLine(x);