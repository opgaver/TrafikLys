TraficLight trafikLys = new TraficLight();
Console.ReadLine();

class TraficLight
{

    public TraficLightState State { get; private set; }

    private System.Timers.Timer Timer = new System.Timers.Timer();
    private int[] Timing;

    public TraficLight(int[]? timing = null)
    {
        this.Timing = timing ?? new int[] { 5000, 2000, 5000, 2000 };
        this.State = TraficLightState.Red;
        this.Timer.Interval = this.Timing[0];
        this.Timer.Elapsed += (sender, e) => ChangeState();
        this.Timer.Start();
        PrintState();
    }


    public void ChangeState()
    {

        switch (this.State)
        {
            case TraficLightState.Red:
                this.State = TraficLightState.RedYellow;
                this.Timer.Interval = this.Timing[1];
                break;
            case TraficLightState.RedYellow:
                this.State = TraficLightState.Green;
                this.Timer.Interval = this.Timing[2];
                break;
            case TraficLightState.Green:
                this.State = TraficLightState.Yellow;
                this.Timer.Interval = this.Timing[3];
                break;
            case TraficLightState.Yellow:
                this.State = TraficLightState.Red;
                this.Timer.Interval = this.Timing[0];
                break;
            default:
                throw new TrafficLightException("Unknown state");
        }
        PrintState();
    }

    public void Reset()
    {
        this.State = TraficLightState.Red;
    }

    private void PrintState()
    {
        Console.WriteLine(this.State);
    }

}

enum TraficLightState
{
    Red,
    RedYellow,
    Green,
    Yellow
}

public class TrafficLightException : Exception
{
    public TrafficLightException(string message)
        : base(message)
    {
    }
}