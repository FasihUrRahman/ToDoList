//ToDoList With Array

//Variables
int optionSelector, i = 0, deleteSelector, a=0, arryLength; 
string? inputValue = null, isContinue = "true";

//Get Array Length
Console.Write("How Many Tasks You Have Today: ");
arryLength = Convert.ToInt32(Console.ReadLine());
string[] inputsByUser = new string[arryLength];

//CodeStart
//Loop For Restart Code
while (isContinue == "true")
{
    Console.WriteLine("\tTodo List");   //Title Message
    Console.WriteLine("Options\n1 - Input Value\n2 - Output Value\n3 - Clear Value\n4 - Exit"); //User Selections
    Console.Write(">>");
    optionSelector = Convert.ToInt32(Console.ReadLine());   //Input Selctions
    switch (optionSelector)
    {
        case 1:
            //Getting Input
            Console.Write("Enter Your Message: ");
            inputValue = Console.ReadLine();
            //Conditions To Check Array is Full Or Not
            if (inputValue == "")
            {
                Console.WriteLine("Please Input Something....");
            }
            else if ((i + 1) > arryLength)
            {
                Console.WriteLine("Please Delete Message First");
            }
            else if (inputsByUser[i] == null)
            {
                inputsByUser[i] = inputValue;
                i++;
                Console.WriteLine("Query Has Been Added");
            }
            Console.Write("Hit Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();
            break;
            //End Getting Input
        case 2:
            //OutPut Value
            
            a = 0;  //Variable To Check Input Values 
            if (inputsByUser[a] == null)    //Check if Array is Null
            {
                Console.WriteLine("Please Input A Value");
            }
            else
            {
                for (int j = 0; j < inputsByUser.Length; j++)    //Loop For Check Input Value
                {
                    if (inputsByUser[j] != null)    //Condition To Check Values
                    {
                        a++;
                    }
                }
                for (int k = 0; k < a; k++) //Loop For Those Values Which are Getting From User
                {
                    Console.WriteLine($"Your Message is \"{inputsByUser[k]}\"");    //Queries To Display
                }
            }
            Console.Write("Hit Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();
            break;
            //End OutPut Value
        case 3:
            //Clear Value
            a = 0;
            if (inputsByUser[a] == null)    //Check if Array is Null
            {
                Console.WriteLine("Please Input A Value Before Delete AnyThing");
            }
            else //If Array is Not Null
            {
                //Loop To Check input Values
                for (int j = 0; j < inputsByUser.Length; j++)
                {
                    if (inputsByUser[j] != null)
                    {
                        a++;
                    }
                }
                Console.WriteLine("Select The Message You wanna Delete");
                //Loop To Print out Values
                for (int j = 0; j < a; j++)
                {
                    Console.WriteLine($"{j + 1} - \"{inputsByUser[j]}\"");
                }
                Console.Write(">>");
                deleteSelector = Convert.ToInt32(Console.ReadLine());   //Get Value For input
                //Condition For Check The valid Input
                if (deleteSelector <= inputsByUser.Length)
                {
                    inputsByUser[deleteSelector - 1] = null;
                    //Loop For Delete and Assigning Value to That Deleted Query Values
                    for (int j = deleteSelector - 1; j < a; j++)
                    {
                        if (j + 1 < inputsByUser.Length)
                            inputsByUser[j] = inputsByUser[j + 1];
                        else
                            inputsByUser[j] = null;
                    }
                    i -= 1;
                    Console.WriteLine("Your Query Has Been Deleted");
                }
                else
                {
                    Console.WriteLine("Please Select Right Option");
                }
            }
            Console.Write("Hit Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
            //End Clear Value
        case 4:
            //Exit
            isContinue = "false";   //False While Condiotion
            break;
            //End Exit
    }
}