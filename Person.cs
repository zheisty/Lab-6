using System;

class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Socialsecuritynumber { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }



        public Address PermanentAddress;

        public Person ()
        {
            PermanentAddress = new Address();
           
        }

          public Person (string fname, string lname)
        {
          Firstname = fname;
          Lastname = lname;
          
            PermanentAddress = new Address();
           
        }
      

        // when it says virtual, it allows for inherited classes to change some information in the intro method
        public virtual void Intro()
        {
            Console.WriteLine("Hello my Name is " + Firstname + " " + Lastname);
            PermanentAddress.display();
        }
        public void isBirthday()
        {
          if ((DateTime.Today.Month == Dateofbirth.Month) && (DateTime.Today.Day== Dateofbirth.Day))
          
          Console.WriteLine("It is your birthday!");
          else
          Console.WriteLine("Today is not your birthday");
        }
    }