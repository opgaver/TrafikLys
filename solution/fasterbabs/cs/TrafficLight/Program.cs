namespace TrafficLight_Fasterbabs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            void Run()
            {
                TrafficLight TLight = new TrafficLight();

                Console.ReadLine();
            }
            
        }
    }
}
