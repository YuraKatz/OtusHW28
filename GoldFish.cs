namespace OtusHW28
{
    public class GoldFish : Fish
    {
        public GoldFish(int awishCount, string name) : base(true ,name)
        {
            AwishCount = awishCount;
        }

        public int AwishCount { get; set; }
    }
}