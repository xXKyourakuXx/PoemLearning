namespace PoemLearning
{
    using System;
    using System.Collections.Generic;
	using System.Drawing;

    public class GameScreenController
    {
		private GameModel model;
		private IList<Image> currentSet;

		public GameScreenController()
		{
			this.model = new GameModel();
			this.currentSet = new List<Image>(this.model.ImageSet);
		}

		public Image GetRandomImage()
		{
			int min = 0;
			int max = this.currentSet.Count;

			if (max == 0)
				throw new Exception("Nincs kép hozzáadva, így nincs miből véletlenszerűen generálni... " +
					"Adj hozzá a könyvtárhoz az adminisztrátor alkalmazásban pár képet.");
			
			int random = new Random().Next(min, max);

			Image result = this.currentSet[random];

			this.currentSet.Remove(result);

			if (this.currentSet.Count == 0)
				this.currentSet = new List<Image>(this.model.ImageSet);

			return result;
		}
	}
}
