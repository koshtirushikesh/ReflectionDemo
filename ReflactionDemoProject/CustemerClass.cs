namespace ReflactionDemoProject
{
    public class CustemerClass
    {
        public int a, b;
        public int Id { get; set; }
        public string Name { get; set; }
        
        public CustemerClass()//parameterless constructor
        {
            Id = 101;
            Name = "Shreya";
        }
        public CustemerClass(int id)//parameterised constructor
        {
            Id = id;
        }
        public void Print()//parameterless method
        {

        }
        public void Test(int a)//parameterised method
        {

        }

    }
}
