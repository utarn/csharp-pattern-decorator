namespace pattern_decorator
{
    public class CloudStream : Stream
    {
        public void Write(string data) {
            System.Console.WriteLine("Storing " + data);
        }
    }
}