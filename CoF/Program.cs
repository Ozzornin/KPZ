
using CoF.ConcreteHandlers;

Console.WriteLine("Hello, World!");


//it would be interesting to make a chain in depth,
//but for the sake of saving time I did not want to do it
var handler1 = new FirstHandler();
var handler2 = new SecondHandler();
var handler3 = new ThirdHandler();
var handler4 = new FourthHandler();
var handler5 = new FifthHandler();

handler1.SetNext(handler2);
handler2.SetNext(handler3);
handler3.SetNext(handler4);
handler4.SetNext(handler5);

Console.WriteLine("1 - Support" +
    "\n2 - Questions about bills" +
    "\n3 - Tariffs" +
    "\n4 - New connection" +
    "\n5 - Other");

int x;
int.TryParse(Console.ReadLine(), out x);

Console.WriteLine(handler1.Handle(x));

Console.ReadLine();

