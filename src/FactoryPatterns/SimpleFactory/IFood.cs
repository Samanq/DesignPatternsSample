namespace SimpleFactory
{
    public interface IFood
    {
        public int Calories { get; }
        public void Prepare();
        public void Serve();
    }
}
