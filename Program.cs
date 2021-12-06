using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class MainClass
    {
        public static string yes_no(string value)
        {
            if (value == "y") { return "Yes"; }
            else { return "No"; }
        }

        public static void Main()
        {
            List<List<string>> all_tasks = new List<List<string>>(); // list of lists to contain all tasks
            List<string> first_task = new List<string>(); // list to contain first task details

            Console.WriteLine("Welcome to your To-Do App! Input your first task:");
            string first_task_name = Console.ReadLine(); // obtain task name from user
            if (first_task_name == null)
            {
                first_task_name = " ";
            }

            first_task.Add(Convert.ToString(DateTime.Now)); // add current time
            first_task.Add(first_task_name); // add task name

            Console.WriteLine("Is the task completed? y/n: ");
            string first_task_completed = Console.ReadLine();

            // retry if user inputs anything other than 'y' or 'n'
            while (first_task_completed != "y" && first_task_completed != "n")
            {
                Console.WriteLine("Invalid entry! Select either 'y' or 'n': ");
                first_task_completed = Console.ReadLine();
            }

            if (first_task_completed == "y" || first_task_completed == "n")
            {
                first_task.Add(first_task_completed);

                if (first_task_completed == "y")
                {
                    first_task.Add(Convert.ToString(DateTime.Now));
                }
            }

            // add the first task to the all_tasks list
            all_tasks.Add(first_task);

            // add more tasks
            Console.WriteLine("Task added successfully. Do you want to add another? y/n: ");
            string add_task = Console.ReadLine();

            while (add_task != "y" && add_task != "n")
            {
                Console.WriteLine("Invalid entry! Select either 'y' or 'n': ");
                add_task = Console.ReadLine();
            }

            while (add_task == "y")
            {
                List<string> new_task = new List<string>();

                Console.WriteLine("Input your next task: ");
                string new_task_name = Console.ReadLine();
                if (new_task_name == null)
                {
                    new_task_name = " ";
                }
                new_task.Add(Convert.ToString(DateTime.Now));
                new_task.Add(new_task_name);

                Console.WriteLine("Is the task completed? y/n:");
                string new_task_completed = Console.ReadLine();

                while (new_task_completed != "y" && new_task_completed != "n")
                {
                    Console.WriteLine("Invalid entry! Select either 'y' or 'n': ");
                    new_task_completed = Console.ReadLine();
                }

                if (new_task_completed == "y" || new_task_completed == "n")
                {
                    new_task.Add(new_task_completed);

                    if (new_task_completed == "y")
                    {
                        new_task.Add(Convert.ToString(DateTime.Now));
                    }
                }

                // add the new task details to the all_tasks list
                all_tasks.Add(new_task);

                // option to continue adding tasks
                Console.WriteLine("Task added successfully. Do you want to add another? y/n: ");
                add_task = Console.ReadLine();

                while (add_task != "y" && add_task != "n")
                {
                    Console.WriteLine("Invalid entry! Select either 'y' or 'n': ");
                    add_task = Console.ReadLine();
                }
            }
            /*
            The error is somewhere in the code below
            */

            // displaying results in tabular form
            string border = "\n ----------------------------------------------------------------------------------------- ";

            Console.WriteLine(border);
            Console.WriteLine(String.Format("| {0, -4} | {1, -15} | {2, -10} | {3, -23} | {4, -23} | {5}", "S.N.", "Task", "Completed?", "Time Created", "Time Completed", border));

            int i = 0;
            foreach (List<string> task in all_tasks)
            {
                i++;
                
                if (task.Count == 3) {
                    Console.WriteLine(String.Format("| {0, -4} | {1, -15} | {2, -10} | {3, -23} | {4, -23} | {5}", i, task[1], yes_no(Convert.ToString(task[2])), task[0], " ", border));
                }
                else {
                    Console.WriteLine(String.Format("| {0, -4} | {1, -15} | {2, -10} | {3, -23} | {4, -23} | {5}", i, task[1], yes_no(Convert.ToString(task[2])), task[0], task[3], border));
                }
                
                
            }
        }
    }
}