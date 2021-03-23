namespace OtusHW28
{
    public class GoldFish : Fish, IMyCloneable2<GoldFish>
    {
        public GoldFish(int awishCount, string name) : base(true ,name)
        {
            AwishCount = awishCount;
        }

        public GoldFish(GoldFish original) : base(original)
        {
            AwishCount = original.AwishCount;
        }
        public int AwishCount { get; set; }
        public new GoldFish CloneV2()
        {
           return new GoldFish(this);
        }
    }
}