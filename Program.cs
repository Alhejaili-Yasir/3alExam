using System;
/* Task 1
public class Program{
    public static void Main(){
    string myname = "Yasir";
    int myage = 25;
    double myFavNum = 10.5;
    Console.WriteLine("My name is " + myname + ", and I am " + myage + " years old."+ " My favorite number is " + myFavNum);



    }
}*/

/* Task 3
public class Program{
    public void IsEven(int num){
        if(num % 2 == 0){
            Console.WriteLine(num + " is an even number");
        }
        else{
            Console.WriteLine(num + " is an odd number");
        }
    }
    public static void Main(){
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());


        Program program = new Program();
        program.IsEven(num);
        } } 
       
*/


      /* Task 4
public class Program{
    public static void Main(){
        Console.WriteLine("enter ur age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age > 12){
            Console.WriteLine("You Are a Child");

        }
        else if (age >= 18){
            Console.WriteLine("You Are an Adult");
        }
        else{
            Console.WriteLine("You Are a Teenager");
        }
        }
        }

        */

        /* Task 5

        public class Program{
            public static void Main(){
                Console.WriteLine("Enter a number from 1 to 12");
                        int month = Convert.ToInt32(Console.ReadLine());
                        switch(month){
                            case 1: Console.WriteLine("January"); 
                            break;
                            case 2: Console.WriteLine("February"); 
                            break;
                            case 3: Console.WriteLine("March"); 
                            break;
                            case 4: Console.WriteLine("April"); 
                            break;
                            case 5: Console.WriteLine("May"); 
                            break;
                            case 6: Console.WriteLine("June"); 
                            break;
                            case 7: Console.WriteLine("July"); 
                            break;
                            case 8: Console.WriteLine("August"); 
                            break;
                            case 9: Console.WriteLine("September"); break;
                            case 10: Console.WriteLine("October"); 
                            break;
                            case 11: Console.WriteLine("November"); 
                            break;
                            case 12: Console.WriteLine("December"); 
                            break;
                            default: Console.WriteLine("Invalid month"); 
                            break;
                        }
            }}  */

            /*Task 6

            public class Book{
                public string Title { get; set; }

                public string Author { get; set; }
                
                public double Price { get; set; }

                public void PrintDetails(){
                    Console.WriteLine("Title: " + Title);
                    Console.WriteLine("Author: " + Author);
                    Console.WriteLine("Price: " + Price);
    
            }
            public class Program {
                            public static void Main(){
                                Book book1 = new Book();
                                book1.Title = "book1";
                                book1.Author = "Yasir";
                                book1.Price = 99.99;

                                Book book2 = new Book();
                                book2.Title = "book2";
                                book2.Author = "Yasir";
                                book2.Price = 199.99;

                                Book book3 = new Book();
                                book3.Title = "book3";
                                book3.Author = "Yasir";
                                book3.Price = 299.99;

                                book1.PrintDetails();
                                book2.PrintDetails();
                                book3.PrintDetails();

            }

            }}*/

            
        
        






