using System;

 class Faculty : Person
    {
        private string id;
        private string title;
        private DateTime dateofemplyment;
        private string employer;
        private string yearlysalary;
        private bool tenured;



        public string Id
        { get; set; }
        public string University
        {get;set;}
        public string Title
        { get; set; }
        public DateTime DateofEmployment
        { get; set; }
        public string Employer
        { get; set; }
        public double Yearlysalary
        { get; set; }
        public bool Tenured
        { get; set; }

        // No parameter constructor
        public Faculty()
        {
            Title = "Instructor";

        }

        //2 Parameter constructor. Firstname of the instructor and lastname of the instructor
        public Faculty(string Firstname, string Lastname)
        {
            Title = "Instructor";
        }
      
        public bool GrantTenure()
        {
          if ((DateTime.Today.Year-DateofEmployment.Year)>= 5)
          return Tenured= true;
          else
          return Tenured = false;
        }

        public void Promote()
        {
          if (((DateTime.Today.Year-DateofEmployment.Year)>= 2)&& Title == "Instructor")
          Title = "Assistant Professor";
          else
          Title = "Instructor";
          
          if (((DateTime.Today.Year-DateofEmployment.Year)>= 5)&& Title == "Assistant Professor")
          Title = "Associate Professor";
          else
          Title = "Assistant Professor";

          if (((DateTime.Today.Year-DateofEmployment.Year)>= 10)&& Title == "Associate Professor")
          Title = "Professor";
          else
          Title = "Associate Professor";

          if (Title == "Professor")
          Console.WriteLine ("No More Promotions Possible");
          else
          Title = "Professor";
        }

        public override void Intro()
        {
          base.Intro();
          Console.WriteLine ("My name is " + Firstname + " " + Lastname + ", and I am a  " + Title + " at " + University + " since " + DateofEmployment.Year);
        }
    }