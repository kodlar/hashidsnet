using HashidsNet;
var hashids = new Hashids("this is my salt",11);
var hash = hashids.Encode(1);
Console.WriteLine(hash);
var numbers = hashids.Decode(hash);
Console.WriteLine(numbers[0]);
Console.ReadLine();