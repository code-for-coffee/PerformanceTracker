using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FireSharp.Response;
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
	    private FirebaseManager _firebaseManager = new FirebaseManager();
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

		public async Task<Assignment> create(Dictionary<String, object> values)
		{
		    var assignment = new Assignment();
		    if (values != null)
		    {
		        if (values.ContainsKey("name"))
		            assignment.name = values["name"].ToString();
		        if (values.ContainsKey("description"))
		            assignment.description = values["description"].ToString();
		        if (values.ContainsKey("maxPossibleScore"))
		            assignment.maxPossibleScore = double.Parse(values["maxPossibleScore"].ToString());
		        if (values.ContainsKey("score"))
		            assignment.score = double.Parse(values["score"].ToString());
		        if (values.ContainsKey("status"))
		            assignment.status = values["status"].ToString();
		        SetResponse response = await _firebaseManager.db().SetAsync("assignments/set", assignment);
		        Assignment result = response.ResultAs<Assignment>();
		    }
			return assignment;
		}

		public Boolean update(Dictionary<String, Object> values)
		{
			return false;
		}

		public Boolean remove(string id)
		{
			return false;
		}

	}
}

