Console.Write("Skriv din mening här: ");

string input = Console.ReadLine();

int counter = 0;

for (int i = 0; i < input.Length; i++)
{
	if (char.IsLetter(input[i]))
	{
		counter++;
	}
    
}

Console.WriteLine("Antalet bokstäver: " + counter);