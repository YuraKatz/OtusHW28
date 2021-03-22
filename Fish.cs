namespace OtusHW28
{
    public class Fish : Animal
    {
        public Fish(bool isFreshwaterfish, string name) : base(name)
        {
            IsFreshwaterfish = isFreshwaterfish;
        }



        public bool IsFreshwaterfish { get; set; }

       
    }
}