namespace TaskLogic
{
    public interface Transport
    {
        int UsefulWork { get; set; }
        int SpentWork { get; set; }
        string Model { get; set; }
        double Efficiency(int usefulwork, int spentwork);
        void Display();
    }
}
