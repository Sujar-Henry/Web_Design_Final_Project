﻿using System;


        [Route("{id:int}/{newDescription}")]
        


        [Route("{description}")]
        public string SearchTaskByDescription(string description)
        {
            var task = IndexModel.tasks.FirstOrDefault(t => t.Description.ToLower() == description.ToLower());

            if (task != null)
            {
                return $"Task found: {task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}";
            }

            return "Task was not found";
        }
        {
            var task = IndexModel.tasks.FirstOrDefault(t => t.Id == id);

            return task.Id.ToString() + " " + task.Description + " " + task.DueDate + " " + task.IsCompleted + " " + task.CompletionDate;
        }
        {
            string final = "";
            for (int i = 1; i <= IndexModel.tasks.Count; i++)
            {
                var task = IndexModel.tasks.FirstOrDefault(t => t.Id == i);

                string task_string = "Task" + i + "-" + task.Id.ToString() + " " + task.Description + " " + task.DueDate + " " + task.IsCompleted + " " + task.CompletionDate + "\n";

                final += task_string;

            }
            return final;
        }
        {
            string final = "";
            for (int i = 1; i <= IndexModel.tasks.Count; i++)
            {
                var task = IndexModel.tasks.FirstOrDefault(t => t.Id == i);

                string task_string = "Task" + i + "-" + task.Id.ToString() + " " + task.Description + " " + task.DueDate + " " + task.IsCompleted + " " + task.CompletionDate + "\n";
                if (task.IsCompleted)
                {
                    final += task_string;
                }

            }
            return final;
        }

        [Route("{id:int}")]
        public string MarkTaskAsCompleted(int id)
        {
            var task = IndexModel.tasks.FirstOrDefault(t => t.Id == id);

            if (task != null)
            {
                task.IsCompleted = true;
                task.CompletionDate = DateTime.Now;
                return "Task marked as complete";
            }

            return "Task was not found";
        }

        //Sorting

        public string SortTasksByCompletedStatus()
        {
            var sortedTasks = IndexModel.tasks.OrderBy(t => t.IsCompleted).ToList();

            string result = "Sorted Tasks by Completed Status:\n";

            foreach (var task in sortedTasks)
            {
                result += $"{task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}\n";
            }

            return result;
        }


        public string SortTasksByCompletionDate()
        {
            var sortedTasks = IndexModel.tasks.OrderBy(t => t.CompletionDate).ToList();

            string result = "Sorted Tasks by Completion Date:\n";

            foreach (var task in sortedTasks)
            {
                result += $"{task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}\n";
            }

            return result;
        }


        public string SortTasksByDueDate()
        {
            var sortedTasks = IndexModel.tasks.OrderBy(t => t.DueDate).ToList();

            string result = "Sorted Tasks by Due Date:\n";

            foreach (var task in sortedTasks)
            {
                result += $"{task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}\n";
            }

            return result;
        }

        //Filtering
        public string FilterByCompletionStatus()
        {
            string final = "Filtered Tasks by Completion Status:\n";
            for (int i = 1; i <= IndexModel.tasks.Count; i++)
            {
                var task = IndexModel.tasks.FirstOrDefault(t => t.Id == i);

                string task_string = "Task" + i + "-" + task.Id.ToString() + " " + task.Description + " " + task.DueDate + " " + task.IsCompleted + " " + task.CompletionDate + "\n";
                if (task.IsCompleted)
                {
                    final += task_string;
                }

            }
            return final;
        }

        public string FilterTasksByDueDate()
        {
            var sortedTasks = IndexModel.tasks.OrderBy(t => t.DueDate).ToList();

            string result = "Filtered Tasks by Due Date:\n";

            foreach (var task in sortedTasks)
            {
                result += $"{task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}\n";
            }

            return result;
        }

        public string FilterTasksByCompletionDate()
        {
            var sortedTasks = IndexModel.tasks.OrderBy(t => t.CompletionDate).ToList();

            string result = "Filter Tasks by Completion Date:\n";

            foreach (var task in sortedTasks)
            {
                result += $"{task.Id} - {task.Description} - {task.DueDate} - {task.IsCompleted} - {task.CompletionDate}\n";
            }

            return result;
        }