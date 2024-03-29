//CRUD
//Create
List<int> numNums = [1, 2, 3, 4, 5];

//Read
// foreach (var num in numNums)
// {
//     Console.WriteLine(num);
// }

//Update
//This is the fastest
//numNums.Add(0);
//insert
//numNums.Insert(0, 0);

//Delete
//var newNum = numNums.Where((i) => i != 2);

//numNums.Remove(1);
numNums.RemoveAt(0);

foreach (var num in numNums)
{
    Console.WriteLine(num);
}
