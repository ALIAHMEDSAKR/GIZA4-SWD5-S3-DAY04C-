
namespace AssignmentD04
{

    public class Program
    {
        public static void Main()
        {
            #region Question 1
            /*
            Problem: Write a program that: 
                o Initializes a one-dimensional array in three different ways (new int[size], 
                initializer list, and Array syntax sugar). 
                o Assigns values to each element in the array and prints them. 
                o Demonstrates an IndexOutOfRangeException. 
            */
            // Way 1: Using new int[size]
            // int[] arr1 = new int[5];
            
            // // Way 2: Using initializer list
            // int[] arr2 = {1,2,3,4,5};
            
            // // Way 3: Using Array syntax sugar (new[] {values})
            // int[] arr3 = new[] {1,2,3,4,5};

            // for (int i = 0; i < arr1.Length; i++)
            // {
            //     arr1[i] = i + 1;
            // }

            // foreach (var item in arr1)
            // {
            //     Console.WriteLine(item);
            // }

            //arr1[7] = 8; // IndexOutOfRangeException Example
            

            //  Question: What is the default value assigned to array elements in C#? 
            /*
            int: 0
            bool: false
            char: '\0' (NULl)
            reference types: null
            nullable/value types: their default (e.g., int? -> null)
            structs/enums: all fields zeroed (enum -> 0)
            */

            #endregion

            #region Question 2
            /*
            Problem: Write a program to: 
                o Create two arrays (arr1 and arr2). 
                o Perform a shallow copy and demonstrate how modifying one affects the other. 
                o Perform a deep copy using the Clone method and show that modifications do not 
                affect the copied array.
            */
            int[] arr1 = {1,2,3,4,5};
            
            int[] arr2 = arr1;

            arr2[0] = 5;
            Console.WriteLine(arr1[0]);

            arr2 = (int[])arr1.Clone();

            arr2[0] = 1;
            Console.WriteLine(arr1[0]);

            



            //  Question: What is the difference between Array.Clone() and Array.Copy()? 
            /*
            Clone : 
            creates a brand new array instance on the Heap and copies all elements into it.
            Return Type: It returns an object. You must cast it back to your specific array type
            Memory: It handles the memory allocation for you.

            Copy :
            It copies elements from a source array to a destination array that you have already created.
            Memory: You must manually allocate the memory for the destination array before calling this.
            */
            #endregion

            #region Question 3
            /*
             Problem: Write a program to: 
                o Create a 2D array with student grades (3 students, 3 subjects each). 
                o Take input from the user to fill the array. 
                o Print the grades for each student using nested loops. 
            */

            
            int[,] grades = new int[3, 3];

            
            Console.WriteLine("--- Enter Grades ---");
            for (int i = 0; i < grades.GetLength(0); i++) 
            {
                Console.WriteLine($"Enter grades for Student {i + 1}:");
                for (int j = 0; j < grades.GetLength(1); j++) 
                {
                    Console.Write($"  Subject {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("\n--- Student Report ---");
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.Write($"Student {i + 1} Grades: ");
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.Write(grades[i, j] + " ");
                }
                Console.WriteLine(); 
            }

             




            //  Question: What is the difference between GetLength() and Length for multidimensional arrays? 
            
            //The main difference is between counting the total capacity versus counting the size of a specific dimension.
            /*
            Length (Property)
            Definition: Returns the total number of elements in the entire array, regardless of dimensions.
            It multiplies the size of all dimensions together.
            Because 3 students * 3 subjects = 9 total 

            GetLength(dimension) (Method)
            Definition: Returns the number of elements in a specific dimension (index).

            Usage: You must pass an integer to specify which dimension you want to check (0 for rows, 1 for columns, etc.).
            */

            #endregion


            #region Question 3

        int[] numbers = { 9, 2, 7, 4, 5 };
        
        Console.WriteLine("--- Initial Array ---");
        PrintArray(numbers);

        // 1. Sort: Arranges elements in ascending order
        Array.Sort(numbers);
        Console.WriteLine("\n1. After Array.Sort():");
        PrintArray(numbers);

        // 2. Reverse: Reverses the order of elements
        Array.Reverse(numbers);
        Console.WriteLine("\n2. After Array.Reverse():");
        PrintArray(numbers);

        // 3. IndexOf: Finds the index of a specific element (e.g., finding '7')
        int index = Array.IndexOf(numbers, 7);
        Console.WriteLine($"\n3. After Array.IndexOf(7):");
        Console.WriteLine($"   Element 7 found at index: {index}");

        // 4. Copy: Copies elements to a new array
        int[] targetArray = new int[5];
        // Copy first 3 elements from 'numbers' to 'targetArray'
        Array.Copy(numbers, targetArray, 3); 
        Console.WriteLine("\n4. After Array.Copy() (First 3 elements copied to new array):");
        PrintArray(targetArray);

        // 5. Clear: Sets elements to their default value (0 for int, null for objects)
        // Clearing index 0 to 2 (exclusive of length, so 2 elements: index 0 and 1)
        Array.Clear(numbers, 0, 2); 
        Console.WriteLine("\n5. After Array.Clear() (Cleared first 2 elements):");
        PrintArray(numbers);


        // Array.Copy() vs Array.ConstrainedCopy()
        //The primary difference lies in reliability and how they handle failures (exceptions).
        /*
        .Copy
        If an error occurs halfway through ,
        it throws an exception, but the elements already copied remain in the destination array.
        Result: The destination array is left in a "corrupted" or partial state.

        .ConstrainedCopy()
        Behavior: It performs a strict check before copying any data. It guarantees that the copy operation will succeed completely or not happen at all.
        Failure State: If the copy cannot be completed successfully , it throws an exception without modifying the destination array.
        Result: The destination array remains unchanged (safe state).
        */

        #endregion

            #region Question 4
                
            /*
             Problem: Create a program that: 
                o Uses a for loop to print all elements of a 1D array. 
                o Uses a foreach loop to print all elements of the same array. 
                o Uses a while loop to print all elements in reverse order. 
            */

            int[] data = { 10, 20, 30, 40, 50 };

            // 1. For Loop
            Console.WriteLine("--- For Loop (All Elements) ---");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            // 2. Foreach Loop
            Console.WriteLine("\n--- Foreach Loop (All Elements) ---");
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 3. While Loop (Reverse Order)
            Console.WriteLine("\n--- While Loop (Reverse Order) ---");
            int index = data.Length - 1; // Start at the last index
            while (index >= 0)
            {
                Console.Write(data[index] + " ");
                index--; // Decrement to move backwards
            }
            Console.WriteLine();





            //  Question: Why is foreach preferred for read-only operations on arrays?

            /*
            1. Safety (Read-Only Nature):
            The iteration variable in a foreach loop is immutable (read-only). 
            You cannot accidentally modify the value of the element inside the loop 
            (e.g., item = 5 will throw a compiler error). This prevents bugs where data is changed unintentionally.

            2. Simplicity and Intent:
            It eliminates the need for managing loop counters (i, j) or checking array bounds (Length). 
            This makes the code cleaner, easier to read, and explicitly signals that you are just "reading" the data, not manipulating indexes.

            3. bounds checking:
            Because there is no index variable to manage manually, you can never get an "IndexOutOfRangeException" 
            by accidentally going one step too far (off-by-one error).
            */

            #endregion


           #region Q5
           /*
             Problem: Write a program that: 
                o Repeatedly asks the user for a positive odd number. 
                o Uses defensive coding to validate input using int.TryParse and a do-while loop. 
            */

            int number;
            bool isValid = false;

            do
            {
                Console.Write("Please enter a positive odd number: ");
                string input = Console.ReadLine();

                // 1. Check if input is a valid integer (Defensive Coding)
                if (int.TryParse(input, out number))
                {
                    // 2. Check if positive AND odd
                    if (number > 0 && number % 2 != 0)
                    {
                        isValid = true;
                        Console.WriteLine($"Success! You entered: {number}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid. The number must be positive and odd.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }

            } while (!isValid);





            //  Question: Why is input validation important when working with user inputs?

            /*
            1. Preventing Crashes (Stability):
            Without validation, unexpected input (like typing "abc" when the program expects a number) 
            can cause runtime errors (System.FormatException) that crash the application. 
            Methods like int.TryParse prevent this by handling the error gracefully.

            2. Security (Defensive Coding):
            Unvalidated input is the root cause of many security vulnerabilities, such as SQL Injection. 
            Hackers often try to input malicious code strings to trick the system. 
            Validation ensures only expected data types pass through.

            3. Data Integrity:
            It ensures the data processed by your program is accurate and meaningful. 
            For example, preventing a user from entering a negative age ensures your database 
            doesn't contain logical errors.
            */

            #endregion

            #region Q6
                /*
             Problem: Write a program to: 
                o Create a 2D array with fixed values. 
                o Print the array elements in a matrix format (rows and columns). 
            */

            // 1. Create a 2D array with fixed values
            int[,] matrix = {
                { 1, 50, 3 },
                { 12, 5, 600 },
                { 7, 88, 9 }
            };

            Console.WriteLine("--- Matrix Display ---");

            // 2. Print elements in matrix format
            for (int i = 0; i < matrix.GetLength(0); i++) // Loop through rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Loop through columns
                {
                    // Printing with padding to ensure columns align perfectly
                    // {0, 5} means: print the number, right-aligned, within a 5-character width
                    Console.Write("{0, 5}", matrix[i, j]);
                }
                Console.WriteLine(); // Move to the next line after printing a full row
            }





            //  Question: How can you format the output of a 2D array for better readability?

            /*
            1. Using String Padding (Alignment):
            The most common method is using composite formatting with alignment, e.g., Console.Write("{0, 5}", value).
            - The number '5' reserves 5 spaces for the value.
            - If the value is "1", it adds 4 spaces of padding.
            - If the value is "100", it adds 2 spaces.
            This ensures that even if numbers have different lengths (1 digit vs 3 digits), the columns remain straight.

            2. Using Escape Sequences (\t):
            You can use the tab character: Console.Write(value + "\t").
            This inserts a fixed tab space. It is simpler but can sometimes break alignment if a number is very long and crosses the tab stop.

            3. Visual Separators:
            Adding characters like " | " between elements helps the eye distinguish columns clearly.
            */

            #endregion

            #region Q7

                
            /*
             Problem: Write a program to: 
                o Sort an array of integers using Array.Sort(). 
                o Search for a specific value using Array.IndexOf() and Array.LastIndexOf(). 
            */

            int[] numbers = { 5, 1, 9, 2, 5, 8, 5 };

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            // 1. Sort the array
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:   " + string.Join(", ", numbers));

            // 2. Search for a specific value (e.g., 5)
            int target = 5;

            // Find the first occurrence
            int firstIndex = Array.IndexOf(numbers, target);
            // Find the last occurrence
            int lastIndex = Array.LastIndexOf(numbers, target);

            Console.WriteLine($"\nSearching for number {target}...");
            if (firstIndex != -1)
            {
                Console.WriteLine($"First occurrence found at index: {firstIndex}");
                Console.WriteLine($"Last occurrence found at index:  {lastIndex}");
            }
            else
            {
                Console.WriteLine("Value not found.");
            }





            //  Question: What is the time complexity of Array.Sort()?

            /*
            1. Average Case: O(n log n)
            Array.Sort uses the Introsort algorithm (Introspective Sort). This is a hybrid sorting algorithm that 
            starts with QuickSort. In most scenarios, it performs at O(n log n), which is very efficient 
            for general-purpose sorting.

            2. Worst Case: O(n log n)
            Unlike standard QuickSort which can degrade to O(n²) if the data is already sorted or bad pivots are chosen, 
            Introsort detects this degradation. If the recursion depth gets too deep (indicating QuickSort is struggling), 
            it switches to HeapSort, which guarantees O(n log n) performance even in the worst case.

            3. Small Arrays:
            For very small partitions (fewer than 16 elements), it switches to Insertion Sort, which is 
            faster for tiny datasets (O(n)).
            */

            #endregion

            #region Q8
                
            /*
             Problem: Write a program that: 
                o Creates an array of integers. 
                o Uses a for loop to calculate and print the sum of all elements. 
                o Uses a foreach loop to calculate the same sum. 
            */

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sumFor = 0;
            int sumForeach = 0;

            // 1. Using a For Loop
            for (int i = 0; i < numbers.Length; i++)
            {
                sumFor += numbers[i];
            }
            Console.WriteLine($"Sum using For Loop:     {sumFor}");

            // 2. Using a Foreach Loop
            foreach (int num in numbers)
            {
                sumForeach += num;
            }
            Console.WriteLine($"Sum using Foreach Loop: {sumForeach}");





            //  Question: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?

            /*
            1. For Arrays (The verdict):
            For raw arrays (int[]), there is effectively NO performance difference in modern C#.
            The C# compiler and JIT (Just-In-Time) compiler optimize 'foreach' loops on arrays 
            to generate the exact same machine code as a standard 'for' loop. It removes the 
            overhead of creating an Enumerator object.

            2. For Generic Collections (e.g., List<T>):
            A 'for' loop can be slightly more efficient than 'foreach' for Lists because 'foreach' 
            technically involves creating an Enumerator struct/object to traverse the collection. 
            However, this difference is usually negligible for most applications.

            3. Conclusion:
            Since the performance is identical for arrays, 'foreach' is generally preferred 
            because it is cleaner, easier to read, and prevents "off-by-one" index errors.
            */

            #endregion
            
            #region Enum-Question
            /*
             Problem: 
                o Define an enum called DayOfWeek with values: Monday...Sunday.
                o Write a program that takes an integer input from the user (1-7).
                o Print the corresponding day using the enum.
                o Use Enum.Parse to convert the input.
            */

            Console.Write("Enter a number (1-7) to get the day: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);

                    // Validate if the parsed integer is actually defined in our Enum (1-7)
                    if (Enum.IsDefined(typeof(DayOfWeek), day))
                    {
                        Console.WriteLine($"The day is: {day}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid format. Please enter a numeric value.");
                }
            }


            // if the user enters a value like 8 or 100:
            // The program prints: "Invalid input. Please enter a number between 1 and 7."
            #endregion


           
        }

        



            // Define the Enum (Starting at 1 to match natural input 1-7)
            enum DayOfWeek
            {
                Monday = 1,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }
        static void PrintArray(int[] arr)
        {
        Console.WriteLine("[ " + string.Join(", ", arr) + " ]");
        }
    }
    
}


