
// Checks a password if it has uppercase letters and doesn’t include symbols




//variables
string passwordOne;
string passwordTwo;
string passwordOneLower;
bool allLowerCaseOne = true;
bool allLetters;
string passwordOneLetters;


//asks for the password the first time and saves it to passwordOne
Console.WriteLine("Please type a password with all lowercase and no " +
    "symbols, then press enter");
passwordOne = Console.ReadLine();

// checks to make sure passwordOne is all lower case
passwordOneLower = passwordOne.ToLower();
allLowerCaseOne = passwordOne == passwordOneLower;
Console.WriteLine("first lowercase attempt wrong");

//keeps asking for the password until it is all lowercase
while (allLowerCaseOne == false)
{
    Console.WriteLine("Password can only contain lowercase letters. \n " +
        "Please re-enter your password now.");
    passwordOne = Console.ReadLine();
    passwordOneLower = passwordOne.ToLower();
    allLowerCaseOne = passwordOne == passwordOneLower;
    if (allLowerCaseOne == false)
        Console.WriteLine("second lowercase attempt wrong");

}

//checks to make sure passwordOne is only letters
foreach (char x in passwordOne)
{
    if (char.IsLetter(x))
        break;
    else
    {
                            //trying to make an if statement to break out if all letters are lowercase then check both conditions
    }
    {


        while (!char.IsLetter(x))
        {
            Console.WriteLine("Password can only contain lowercase letters." +
                "(first attempt) \n " +
                "Please re-enter your password now.");
            passwordOne = Console.ReadLine();
            Console.WriteLine("second attempt");


        }

    }
        
}

/* correct password sequence
if (allLowerCaseOne == true) && 


*/

















/*
string passwordOne;
string passwordTwo;
bool allLowerCase;
//asks for password
Console.WriteLine("Please type a password with all lowercase and no symbols, then press enter");
string passwordOne = Console.ReadLine();

//checks to make sure password is all lowercase

allLowerCase = passwordOne && passwordOne.ToLower();
Console.WriteLine(allLowerCase);




//checks to make sure password is all letters




//asks for password again
Console.WriteLine("Please re-enter your password");
string passwordTwo = Console.ReadLine();
if (passwordOne == passwordTwo)
{
    string finalPassword = passwordOne;
    Console.WriteLine("Your password has been set.");
}

*/




