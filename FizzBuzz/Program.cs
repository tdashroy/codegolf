class C 
{ 
    static void Main() 
    { 
        for (var i = 0; i++ < 100; System.Console.Write($"{(i % 3 * i % 5 > 0 ? i : 0):#}{i % 3:;;Fizz}{i % 5:;;Buzz}\n")) ; 
    }
}