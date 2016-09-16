using System;
using System.Collections.Generic;
using PerformanceTracker.Models;

namespace PerformanceTracker.Models
{
	public interface IDefaultModel<T>
	{
		IEnumerable<T> all();
		T find(string id);
		T create();
		Boolean update(KeyValuePair<String, Object> values);
		Boolean remove(string id);
	}
}

