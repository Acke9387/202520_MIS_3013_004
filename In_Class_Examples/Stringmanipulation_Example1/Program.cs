string sentence = "Acres of almond trees lined the interstate highway which complimented the crazy driving nuts.";

Console.WriteLine($"There are {sentence.Length} letters in the string:\n");
Console.WriteLine($"The last letter of the sentence is {sentence[sentence.Length - 1]}");

sentence = sentence.ToUpper();
// Loop through the string and print every other letter
for (int i = 0; i < sentence.Length; i = i + 2)
{
    Console.WriteLine(sentence[i]);
}

