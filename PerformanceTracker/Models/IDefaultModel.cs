using System;
using System.Collections.Generic;
using PerformanceTracker.Models;

namespace PerformanceTracker.Models
{
	public interface IDefaultModel<T>
	{
		IEnumerable<T> all();
		T find(string id);
		T create(Dictionary<String, object> values);
		Boolean update(Dictionary<String, object> values);
		Boolean remove(string id);
	}
}

