namespace OtusHW28
{
    public class Fish : Animal,  IMyCloneable2<Fish>
    {
        public Fish(bool isFreshwaterfish, string name) : base(name)
        {
            IsFreshwaterfish = isFreshwaterfish;
        }

        public Fish(Fish original) : base(original)
        {

        }


        public bool IsFreshwaterfish { get;   set; }


        public new Fish CloneV2()
        {
           return new Fish(this);
        }
    }
}