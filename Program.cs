// Generate a random array length between 3 and 9
int randomLength = new Random().Next(3, 10);

static string[] GenerateRandomStringArray(int randomLength)
{
    // Create an array of random length
    string[] randomArray = new string[randomLength];

    // Define a string of all possible characters
    string allCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789%$*:-)+=!,.";

    // Fill the array with random strings
    for (int i = 0; i < randomLength; i++)
    {
        // Create a random string with random length between 1 and 9
        string randomString = "";
        for (int j = 0; j < new Random().Next(1, 10); j++)
        {
            // Generate a random character from the string of all possible characters
            char randomChar = allCharacters[new Random().Next(allCharacters.Length)];
            randomString += randomChar;
        }

        // Add the random string to the array
        randomArray[i] = randomString;
    }
    return randomArray;
}

static string[] ThreeLengthArrayOfString(string[] strArray, int randomLength)
{
    string[] threeLengthArray = new string[randomLength]; ;
    int i = 0;
    foreach (string str in strArray)
    {
        if (str.Length < 4)
        {
            threeLengthArray[i] = str;
            i++;
        }
    }
    return threeLengthArray;
}

// Print the array of strings
static void PrintArrayOfString(string[] strArray)
{
    foreach (string str in strArray)
    {
        Console.Write(str + " ");
    }
}

string[] strArray = GenerateRandomStringArray(randomLength);
PrintArrayOfString(strArray);
Console.WriteLine($"\n\nrandomLength = {randomLength}\n");
PrintArrayOfString(ThreeLengthArrayOfString(strArray, randomLength));
