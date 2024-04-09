using System;
using System.Timers;

public class TrafficLight
{
	public LightStates State { get; private set; }

	private int[] Intervals = {5, 2, 5, 2};

	private System.Timers.Timer t1;

	public TrafficLight()
	{
		t1 = new System.Timers.Timer();
		this.State = LightStates.Red;
		Feedback();

		t1.Elapsed += ChangeState;

        StartTimer(Intervals[(int)State]);
    }

	private void ChangeState(object sender, ElapsedEventArgs e)
	{
		int currentState = ((int)this.State);
		currentState++;
		if (currentState >= 4) 
		{
			currentState = 0;
		}

		this.State = (LightStates)currentState;

		Feedback();
        StartTimer(Intervals[currentState]);

    }

	public void Feedback()
	{		
		Console.WriteLine(this.State.ToString());
	}

    private void StartTimer(int seconds)
    {
        t1.Interval = seconds * 1000;
        t1.Start();
    }

    private void EndTimer()
	{
		t1.Stop();		
	}
}

public enum LightStates
{
	Red,
	RedYellow,
    Green,
    Yellow	
}
