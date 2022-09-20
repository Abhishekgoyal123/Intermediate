// See https://aka.ms/new-console-template for more information

using Exercise_6;
Console.WriteLine("Hello, World!");

WorkflowEngine we = new WorkflowEngine();

//Activity_1 a1 = new Activity_1();
//Workflow wl = new Workflow(a1);
//we.Run(wl);


List<IActivity> activities = new List<IActivity>();
activities.Add(new Activity_1());
activities.Add(new Activity_2());
we.Run(activities);