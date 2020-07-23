using System;

 class Program
    {
        static void Main(string[] args)
        {
           /* Address addr1 = new Address();
            addr1.Addressline1 = "123 Main St.";
            addr1.Addressline2 = "None";
            addr1.City = "Rocky River";
            addr1.State = "Ohio";
            addr1.Zipcode = "44116";

            addr1.display();


            Person p1 = new Person();

            p1.Firstname = "John";
            p1.Lastname = "Smith";
            p1.PermanentAddress.Addressline1 = "2758 Kingsbury Dr";
            p1.PermanentAddress.Addressline2 = "None";
            p1.PermanentAddress.City = "Rocky River";
            p1.PermanentAddress.State = "OH";
            p1.PermanentAddress.Zipcode = "44116";
            p1.Dateofbirth = Convert.ToDateTime (("07/22/1998"));
            p1.Intro();
            p1.isBirthday(); 
            
           Console.WriteLine ("Testing Student 1");
            Student s1 = new Student();
            s1.Firstname = "John";
            s1.Lastname = "Smith";
            s1.PermanentAddress.Addressline1 = "2758 Kingsbury Dr";
            s1.PermanentAddress.Addressline2 = "None";
            s1.PermanentAddress.City = "Rocky River";
            s1.PermanentAddress.State = "OH";
            s1.PermanentAddress.Zipcode = "44116";
            s1.Dateofbirth = Convert.ToDateTime("01/01/1989");
            s1.GPA= 2.0;
            s1.School = "University of Arizona";
            s1.Intro();
            s1.isBirthday();
            s1.SetAcademicStanding ();
            Console.WriteLine ("Academic Standing is " + s1.Academicstanding);
              
             Console.WriteLine ("Testing Student 2");
            Student s2 = new Student("Zach","Heisterkamp");
            s2.PermanentAddress.Addressline1 = "111 Anywhere Dr";
            s2.PermanentAddress.Addressline2 = "None";
            s2.PermanentAddress.City = "Rocky River";
            s2.PermanentAddress.State = "OH";
            s2.PermanentAddress.Zipcode = "44116";
            s2.Dateofbirth = Convert.ToDateTime("07/29/1998");
            s2.GPA= 3.0;
            s2.School = "University of Arizona";
            s2.Intro();
            s2.isBirthday();
            s2.SetAcademicStanding ();
            Console.WriteLine ("Academic Standing is " + s2.Academicstanding);*/

            Console.WriteLine ("Faculty Member 1");
            Faculty f1 = new Faculty ();
            f1.Firstname = "Zachary";
            f1.Lastname = "Heisterkamp";
            f1.Title = "Instructor";
            f1.PermanentAddress.Addressline1 = "123 Main St.";
            f1.PermanentAddress.Addressline2 = "None";
            f1.PermanentAddress.City = "Rocky River";
            f1.PermanentAddress.State = "OH";
            f1.PermanentAddress.Zipcode = "44116";
            f1.DateofEmployment = Convert.ToDateTime("01/01/1989");
            f1.University = "The University of Arizona";
             f1.Promote();
            f1.Intro();
           
            
            

        }
    }
