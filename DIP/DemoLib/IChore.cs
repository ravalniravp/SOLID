namespace DemoLib
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; set; }
        bool IsCompleted { get; set; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}