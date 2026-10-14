namespace numlist
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>();
            string choice = "";

            while (choice != "Q")
            {
                Console.WriteLine("\nP - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("S - Smallest number");
                Console.WriteLine("L - Largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "P":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - The list is empty");
                        }
                        else
                        {
                            int i = 0;

                            Console.Write("[");
                            while (i < numbers.Count)
                            {
                                Console.Write(numbers[i] + " ");
                                i++;
                            }
                            Console.WriteLine("]");
                        }
                        break;

                    case "A":
                        Console.Write("Enter a number to add: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;
                        int j = 0;

                        while (j < numbers.Count)
                        {
                            if (numbers[j] == num)
                            {
                                exists = true;
                                break;
                            }
                            j++;
                        }

                        if (exists)
                        {
                            Console.WriteLine("Number already exists");
                        }
                        else
                        {
                            numbers.Add(num);
                            Console.WriteLine($"{num} added");
                        }
                        break;

                    case "S":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            int i = 1;

                            while (i < numbers.Count)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                                i++;
                            }

                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        break;

                    case "L":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            int i = 1;

                            while (i < numbers.Count)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                                i++;
                            }

                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;

                    case "F":
                        Console.Write("Enter a number to find: ");
                        int search = Convert.ToInt32(Console.ReadLine());

                        int index = -1;
                        int k = 0;

                        while (k < numbers.Count)
                        {
                            if (numbers[k] == search)
                            {
                                index = k;
                                break;
                            }
                            k++;
                        }

                        if (index != -1)
                        {
                            Console.WriteLine($"{search} found at index {index}");
                        }
                        else
                        {
                            Console.WriteLine($"{search} not found");
                        }
                        break;

                    case "C":
                        numbers.Clear();
                        Console.WriteLine("List cleared");
                        break;

                    case "Q":
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            }

        }
    }
}
