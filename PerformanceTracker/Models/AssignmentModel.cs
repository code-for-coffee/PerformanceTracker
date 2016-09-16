using System;
namespace PerformanceTracker.Models
{
	public class Assignment
	{
		public Assignment()
		{
		}
		public Assignment(
			string name,
			string desc,
			double maxScore,
			double score)
		{
			this.name = name;
			this.description = desc;
			this.maxPossibleScore = maxScore;
			this.score = score;
		}

		public string name { get; set; }
		public string description { get; set; }
		public double maxPossibleScore { get; set; }
		public double score { get; set; }

	}
}

