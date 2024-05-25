List<int> n1 = new List<int> { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
var result = n1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
foreach (var item in result)
{
	Console.WriteLine($"Number: {item.Key}, Frequency: {item.Value}");
}