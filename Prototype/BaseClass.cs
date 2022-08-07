using System;
namespace Prototype
{
    public abstract class BaseClass
    {
        private int _Id;

        public int Id { get => _Id; }
        public BaseClass(int id)
        {
            _Id = id;
            Console.WriteLine($"Создан объект с Id={Id}");
        }

        public void GetId()
        {
            Console.WriteLine(Id); ;
        }

        public abstract BaseClass Clone();
    }
}