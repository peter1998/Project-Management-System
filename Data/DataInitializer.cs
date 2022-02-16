using Project_Management_System.Model.Entities;

namespace Project_Management_System.Data
{
    public class DataInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            Stack<ProjectTask> taskStack = new Stack<ProjectTask>();
            List<ProjectTask> taskList = new List<ProjectTask>();


            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDataContext>();
                context.Database.EnsureCreated();

                if (!context.Tasks.Any())
                {
                    context.Tasks.AddRange(new List<ProjectTask>()
                    {
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "As a User, I want to create a task.",
                            Description = "Build out a local office on Mars.",
                            Assignee = "Tundzhay Mollov",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.ReadyForTest,
                            Estimate = 48,
                            CreatedAt = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Broken button. New User can’t click the Next button on Step 2 of the Wizard.",
                            Description = "Assign the JSON data inside your fetch call to this state variable.",
                            Assignee = "Radina Petrishka",
                            Priority = Enums.Priority.Critical,
                            Status = Enums.Status.ToDo,
                            Estimate = 30,
                            CreatedAt = DateTime.ParseExact("02/02/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "As Sam Spendsalot, I want to one-click purchase so that I can get my goods as quickly as possible",
                            Description = "Leave all other fields blank or at their default values.",
                            Assignee = "Salem Fahed",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.Done,
                            Estimate = 24,
                            CreatedAt = DateTime.ParseExact("01/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Add support for teams larger than 20 people",
                            Description = "Fill in the fields using the data shown below.",
                            Assignee = "Ivan Tanev",
                            Priority = Enums.Priority.Low,
                            Status = Enums.Status.ReadyForTest,
                            Estimate = 30,
                            CreatedAt = DateTime.ParseExact("25/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "Make working with our space travel partners easier.",
                            Description = "Usually, a project would have issues in the backlog, and you can add these issues to a sprint so your team can work on them. ",
                            Assignee = "Borislava Petrova",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.InProgress,
                            Estimate = 10,
                            CreatedAt = DateTime.ParseExact("09/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Requesting available flights is now taking more than 5 seconds.",
                            Description = "You can create new issues or sub-tasks, organize your backlog, create versions, organize via epics, and start sprints.",
                            Assignee = "Yulian Ashikov",
                            Priority = Enums.Priority.Critical,
                            Status = Enums.Status.InProgress,
                            Estimate = 4,
                            CreatedAt = DateTime.ParseExact("02/04/2022","dd/MM/yyyy", null),
                        }
                    });
                }

                taskList.AddRange(new List<ProjectTask>()
                    {
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "As a User, I want to create a task.",
                            Description = "Build out a local office on Mars.",
                            Assignee = "Tundzhay Mollov",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.ReadyForTest,
                            Estimate = 48,
                            CreatedAt = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Broken button. New User can’t click the Next button on Step 2 of the Wizard.",
                            Description = "Assign the JSON data inside your fetch call to this state variable.",
                            Assignee = "Radina Petrishka",
                            Priority = Enums.Priority.Critical,
                            Status = Enums.Status.ToDo,
                            Estimate = 30,
                            CreatedAt = DateTime.ParseExact("02/02/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "As Sam Spendsalot, I want to one-click purchase so that I can get my goods as quickly as possible",
                            Description = "Leave all other fields blank or at their default values.",
                            Assignee = "Salem Fahed",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.Done,
                            Estimate = 24,
                            CreatedAt = DateTime.ParseExact("01/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Add support for teams larger than 20 people",
                            Description = "Fill in the fields using the data shown below.",
                            Assignee = "Ivan Tanev",
                            Priority = Enums.Priority.Low,
                            Status = Enums.Status.ReadyForTest,
                            Estimate = 30,
                            CreatedAt = DateTime.ParseExact("25/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Story,
                            Title = "Make working with our space travel partners easier.",
                            Description = "Usually, a project would have issues in the backlog, and you can add these issues to a sprint so your team can work on them. ",
                            Assignee = "Borislava Petrova",
                            Priority = Enums.Priority.Normal,
                            Status = Enums.Status.InProgress,
                            Estimate = 10,
                            CreatedAt = DateTime.ParseExact("09/01/2022","dd/MM/yyyy", null),
                        },
                        new ProjectTask()
                        {
                            Type = Enums.TrackType.Bug,
                            Title = "Requesting available flights is now taking more than 5 seconds.",
                            Description = "You can create new issues or sub-tasks, organize your backlog, create versions, organize via epics, and start sprints.",
                            Assignee = "Yulian Ashikov",
                            Priority = Enums.Priority.Critical,
                            Status = Enums.Status.InProgress,
                            Estimate = 4,
                            CreatedAt = DateTime.ParseExact("02/04/2022","dd/MM/yyyy", null),
                        }
                    });

                Stack<ProjectTask> taskStackInitializer = new Stack<ProjectTask>();

                if (!context.Projects.Any())
                {
                    context.Projects.AddRange(new List<Project>()
                    {
                       new Project()
                       {
                           Name = "QuantumDMS",
                           Backlog = taskStackInitializer.ToList()
                       },
                       new Project()
                       {
                           Name = "Gulp Project",
                           Backlog = taskStackInitializer.ToList()
                       }
                    }) ;
                }

                //if (!context.Projects_Tasks.Any())
                //{
                //    context.Projects_Tasks.AddRange(new List<Project_Task>()
                //    {
                //        new Project_Task()
                //        {
                //            ProjectId = 1,
                //            TaskId = 1,
                //        }
                //    });
                //}


                context.SaveChanges();
            }
            
        }
        
    }
}
