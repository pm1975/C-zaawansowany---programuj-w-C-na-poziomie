using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * value objects:
             * Entitiy - klasa służąca do zapisu do bazy danych
             * Dto - data transfer objects - obiekty do transportu danych
             * ViewModel - model dla widoku, dla użytkownika
             * ApiModel
             */

            var entity = new UserEntity
            {
                Name = "Piotr",
                Age = 45,
                Email = "piotr@email.com"
            };

            //var dto = new UserDto
            //{
            //    Name = entity.Name,
            //    Age = entity.Age,
            //    Email = entity.Email,
            //    IsAboveEighteen = entity.Age > 18
            //};

            //powstały narzędzia, które zrobią to automatycznie, np. Automaper

            var mapper = new UserMapper();

            var dto = mapper.Map(entity);
        }
    }

    //słówko virtual
    public abstract class SomeClass
    {
        public virtual void SomeFunction()
        {
            Console.WriteLine("Cos sie dzieje nie wazne od klasy pochodnej");
        }
    }

    public class SomeClass2 : SomeClass
    {
        public new void SomeFunction()
        {

        }
    }
}
