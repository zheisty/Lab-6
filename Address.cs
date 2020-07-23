using System;

 class Address
    {
        private string state;
        private string zipcode;
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (value.Length == 2)
                    state = value;
                else
                    Console.WriteLine("Invalid input for State");
            }
        }
        public string Zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                if (value.Length <= 5)
                    zipcode = value;
                else
                    Console.WriteLine("Invalid input for Zipcode");
            }
        }


        //This method means you have to type each information every single time a new address info is added
        public void display()
        {
            Console.WriteLine ("My Address is: ");
            Console.WriteLine(Addressline1);
            Console.WriteLine(Addressline2);
            Console.WriteLine(City);
            Console.WriteLine(State);
            Console.WriteLine(Zipcode);


        }
    }