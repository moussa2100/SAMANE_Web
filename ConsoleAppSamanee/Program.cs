// See https://aka.ms/new-console-template for more information


using WebApplication1.Models;

//AppDbContext appDbContext = new AppDbContext();

//var results = appDbContext.Cars.FirstOrDefault(c => c.car_year == 2021);
//-----------------------------------------------------------------------------
//Func<int, int> doublee = (x) =>
//                                {
//                                    return x * 2;
//                                };

//var rand = Enumerable.Range(1, 3);

//var result =  rand.Select(doublee);
//-----------------------------------------------------------------------------

IEnumerable<int> number=new int[] { 1,2,3};

Func<int, int> triple = x => x * 3;

number = number.Select(x=> x *3);

//var range = Enumerable.Range(1, 3);
//var triples = range.Select(triple);


number.ToList().ForEach( n=> Console.Write(n + "-") );
Console.ReadLine();