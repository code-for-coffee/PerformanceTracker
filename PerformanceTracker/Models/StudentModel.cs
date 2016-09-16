using System;
using System.Collections.Generic;
using PerformanceTracker.Models;
namespace PerformanceTracker
{
	public class StudentModel : IDefaultModel<StudentModel>
	{
		public StudentModel()
		{
		}
		public string name { get; set; }
		public string avatarUrl { get; set; }
		public string group { get; set; }
		public double gpa { get; set; }

		public IEnumerable<StudentModel> all()
		{
			return new List<StudentModel>();
		}

		public StudentModel find(String id)
		{
			return new StudentModel();
		}

		public StudentModel create(Dictionary<String, object> values)
		{
			return new StudentModel();
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

