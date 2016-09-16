using System;
using System.Collections.Generic;
using PerformanceTracker.Models;

namespace PerformanceTracker.Models
{
	public class Assignment : IDefaultModel<Assignment>
	{
		public Assignment()
		{
			this.status = statusTypes.icebox.ToString();
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
			this.status = statusTypes.icebox.ToString();
		}
		enum statusTypes
		{
			icebox,
			thawing,
			current,
			testing,
			passed
		}
		public string name { get; set; }
		public string description { get; set; }
		public double maxPossibleScore { get; set; }
		public double score { get; set; }
		public string status { get; set; }

		public IEnumerable<Assignment> all()
		{
			return new List<Assignment>();
		}

		public Assignment find(String id)
		{
			return new Assignment();
		}

		public Assignment create()
		{
			return new Assignment();
		}

		public Boolean update(KeyValuePair<String, Object> values)
		{
			return false;
		}

		public Boolean remove(string id)
		{
			return false;
		}

	}
}

