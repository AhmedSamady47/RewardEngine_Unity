using com.glups.Reward;
public class Program
{

	// Main to test

	  static void Main(string[] args)
	  {
		  RewardModel model = new RewardModel();
		  View view = new View();
		  Controller controller = new Controller(model, view);

		  controller.openLevel(1);

		  for (int i = 0; i <= 100; i++)
		  {
			  long random = (long)Math.Round(Math.Floor(MathHelper.NextDouble * 10), MidpointRounding.AwayFromZero);
			  if (random < 5)
			  {
				  controller.addPositive(1);
			  }
			  else
			  {
				  controller.addNegative(1);
			  }
			  controller.traceModel(123456, 87654321);
		  }

	  }
}
