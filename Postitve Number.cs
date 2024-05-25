List<int> n1 = new List<int>{ 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
var result = n1.Where(x => x > 0);
foreach ( var x in result )
	Console.WriteLine(x);