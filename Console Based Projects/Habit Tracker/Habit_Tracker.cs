using System;
using System.Collections.Generic;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Habit> habits = new List<Habit>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Habit Tracker ---");
                Console.WriteLine("1. Add Habit");
                Console.WriteLine("2. View Habits");
                Console.WriteLine("3. Complete Habit");
                Console.WriteLine("4. Remove Habit");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddHabit(habits);
                        break;
                    case "2":
                        ViewHabits(habits);
                        break;
                    case "3":
                        CompleteHabit(habits);
                        break;
                    case "4":
                        RemoveHabit(habits);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddHabit(List<Habit> habits)
        {
            Console.Write("Enter the name of the habit: ");
            string name = Console.ReadLine();
            habits.Add(new Habit(name));
            Console.WriteLine($"Habit '{name}' added.");
        }

        static void ViewHabits(List<Habit> habits)
        {
            Console.WriteLine("\nYour Habits:");
            foreach (var habit in habits)
            {
                Console.WriteLine(habit);
            }
        }

        static void CompleteHabit(List<Habit> habits)
        {
            Console.Write("Enter the name of the habit you completed: ");
            string name = Console.ReadLine();
            Habit habit = habits.Find(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (habit != null)
            {
                habit.Complete();
                Console.WriteLine($"Habit '{name}' marked as completed.");
            }
            else
            {
                Console.WriteLine($"Habit '{name}' not found.");
            }
        }

        static void RemoveHabit(List<Habit> habits)
        {
            Console.Write("Enter the name of the habit to remove: ");
            string name = Console.ReadLine();
            Habit habit = habits.Find(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (habit != null)
            {
                habits.Remove(habit);
                Console.WriteLine($"Habit '{name}' removed.");
            }
            else
            {
                Console.WriteLine($"Habit '{name}' not found.");
            }
        }
    }

    class Habit
    {
        public string Name { get; private set; }
        public bool IsCompleted { get; private set; }

        public Habit(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"{Name} - {(IsCompleted ? "Completed" : "Not Completed")}";
        }
    }
}
