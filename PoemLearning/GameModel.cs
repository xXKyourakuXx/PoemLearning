namespace PoemLearning
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text.RegularExpressions;

    ///<summary>
    ///		At object creation, this class loads all image files from the "img" directory and stores them in "imageSet".
    ///		If loading process doesn't succeed, the datamember will be null, must check when used.
    //</summary>
    public class GameModel
	{
		private IList<Image> imageSet;

		public IList<Image> ImageSet { get { return this.imageSet; } }

		public GameModel()
		{
			this.imageSet = new List<Image>();

			foreach (string s in this.LoadImages())
				this.imageSet.Add(Image.FromFile(s));
		}

        private List<string> LoadImages()
		{
			List<string> imageFiles = new List<string>();

			string path = Path.Combine(Environment.CurrentDirectory, "img");
			
			if (Directory.Exists(path))
			{
				var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

				foreach (string filename in files)
					if (Regex.IsMatch(filename, @"\.jpg$|\.png$|\.gif$"))
						imageFiles.Add(filename);
			}

			return imageFiles;
		}
	}
}
