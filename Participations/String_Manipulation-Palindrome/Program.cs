Console.WriteLine("Please enter a word to see if it is a palindrome. <<");
string word = Console.ReadLine();

string reversedWord = "";

for (int i = word.Length - 1; i >= 0; i = i - 1)
{
    reversedWord = reversedWord + word[i];
}

if (word == reversedWord)
{
    Console.WriteLine("The word is a palindrome.");
}
else
{
    Console.WriteLine("The word is not a palindrome.");
}