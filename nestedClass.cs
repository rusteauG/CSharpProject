//nested class and lamba ordeby
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Name = "John", Age = 20 });
            list.Add(new Person { Name = "Neville", Age = 46 });
            list.Add(new Person { Name = "Laura", Age = 50 });
            list.Add(new Person { Name = "Kalebi", Age = 12 });
            var sortedAge = list.OrderBy(x => x.Age).ToList();

            foreach
                (var person in sortedAge.OrderBy(x=>x.Name))
            {
                Console.WriteLine(person.Name);
                
            }
            foreach(Person person in sortedAge)
            {
                Console.WriteLine(person.Age);
            }


            int i = 10;
            object o = i; //boxing
            
            Console.WriteLine(o);



            // Create an engine
            Engine engine = new Engine();

            // Create a car with the engine
            Car car = new Car("MyCoolCar", "Red", engine);

            // Start the car engine
            car.Start();

            // Stop the car engine
            car.Engine.Stop();