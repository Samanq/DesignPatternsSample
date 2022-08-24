namespace FactoryMethod
{
    public interface IFood
    {
        public double Price { get; }
        public void Prepare();
        public void Serve();
    }
}
