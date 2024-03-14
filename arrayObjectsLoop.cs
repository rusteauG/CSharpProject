// iterates through the array and compares each object's properties with the search criteria.



Employee[] employees = new Employee[7] { bethany, george, mary, bobJunior, kevin, kate, kim };
Employee targetEmployee = /* Your desired employee object (e.g., kim) */; // Replace with actual object

int index = -1; // Initialize to -1 to indicate not found

for (int i = 0; i < employees.Length; i++)
{
  if (employees[i].Equals(targetEmployee)) // Compare object properties (replace with your comparison logic)
  {
    index = i;
    break; // Exit loop once found
  }
}

if (index >= 0)
{
  Console.WriteLine($"Employee found at index: {index}");
}
else
{
  Console.WriteLine("Employee not found in the array.");
}

/*We iterate through the employees array using a for loop.
Inside the loop, we compare the current employee object (employees[i]) with the target employee (targetEmployee) using the Equals method (replace with your specific comparison logic).
If a match is found, the index is stored in the index variable, and the loop is exited using break.
After the loop completes, we check if index is greater than or equal to 0 (meaning a match was found) and print corresponding messages.*/
