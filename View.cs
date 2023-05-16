// Test class modeling the view

public class View
{

	internal virtual void updateRank(int rank)
	{
		Console.WriteLine("View: Notify rank change: " + rank);
	}

	internal virtual void updateReward(int reward)
	{
		Console.WriteLine("View: Notify reward change: " + reward);
	}

	internal virtual void updatePositiveScore(int s, int rs)
	{
		Console.WriteLine("View: Notify new P score: " + s + ", " + rs);
	}
	internal virtual void updateNegativeScore(int s, int rs)
	{
		Console.WriteLine("View: Notify new N score: " + s + ", " + rs);
	}
}
