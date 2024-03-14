//Write a program to ask the user about the validity of a simple statement. The program should accept the response then display the statement as well as the response. The response should be true or false. For this question, you must use a variable of type bool. It is useful to know that Convert.ToBoolean() can work with true, True, true, TRUE etc
Console.Write("Is this statement True or False: The Earth is flat. ");
bool isvalid = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"\nThe statement is: {false}\n");
Console.WriteLine($"\nThe answer is: False\n");