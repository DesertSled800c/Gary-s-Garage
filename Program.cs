namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram R2500 = new Ram();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            R2500.Drive();
            R2500.Turn();
            R2500.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
        }
    }
}