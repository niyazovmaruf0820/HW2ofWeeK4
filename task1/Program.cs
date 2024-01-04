using task1;

Car car = new Car(0);
System.Console.WriteLine("Amout of petrol : ");
int Amout = Convert.ToInt32(Console.ReadLine());
car.Rafuel(Amout);
car.Drive();