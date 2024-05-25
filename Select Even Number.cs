List<int> n1 = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = n1.Where(x => x % 2 == 0);
foreach ( var x in result )
	Console.WriteLine(x);