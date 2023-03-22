List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var squaredNumbers = from int Number in numbers
                     let SqrNo = Number * Number
                     select new { Number, SqrNo };


foreach (var num in squaredNumbers)
    Console.WriteLine(num);

Console.ReadLine();