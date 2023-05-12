//msg = welcom
//msg = Options 1-input value 2-delete value 3-exit
//Varibales
int optionSelection;
string? userInput1 = null, userInput2 = null ;
bool isCountinue = true;
//Code
Console.WriteLine("Welcome To Our Program");

while (isCountinue)
{
    Console.WriteLine("Selecte Option\n1 - Input Value\n2 - Display Value\n3 - Delete Value\n4 - Exit");
    Console.Write(">>");
    optionSelection = Convert.ToInt32(Console.ReadLine());
    switch (optionSelection)
    {
        case 1:
            if(userInput1 == null)
            {
                Console.Write("Enter Your Message: ");
                userInput1 = Console.ReadLine();
                Console.WriteLine("Input is Saved");
            }
            else if (userInput2 == null)
            {
                Console.Write("Enter Your Message: ");
                userInput2 = Console.ReadLine();
                Console.WriteLine("Input is Saved");
            }
            else
            {
                Console.WriteLine("There's already a data in list. Please Delete First");
            }
            Console.Write("Press Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine(userInput1);
            Console.WriteLine(userInput2);
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();
            break;
        case 3:
            userInput1 = null;
            userInput2 = null;
            Console.WriteLine("Your Data is Removed");
            Console.ReadLine();
            Console.Clear();
            break;
        case 4:
            isCountinue = false;
            break;
        default:
            Console.WriteLine("Khotti dya sida jaga jaa");
            break;
    }

}
Console.WriteLine("Bye Bye...");


Console.ReadLine();




/*if (optionSelection == 1)
{
    Console.WriteLine("In Input Value");
}
else if(optionSelection == 2)
{
    Console.WriteLine("In Delete Value");
}
else if(optionSelection == 3)
{
    Console.WriteLine("In Exit");
}
else
{
    Console.WriteLine("Khotti dya sida jaga jaa");
}*/
