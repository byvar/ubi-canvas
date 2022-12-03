using System;
using System.Linq;
using System.Reflection;

namespace UbiArt {
	public static class Merger {
		public static TTarget Merge<TTarget>(object copyFrom, bool throwExceptions = false) where TTarget : new() {
			var flags = BindingFlags.Instance | BindingFlags.Public |
						BindingFlags.NonPublic;
			var targetDic = typeof(TTarget).GetFields(flags)
										   .ToDictionary(f => f.Name);
			var ret = new TTarget();
			foreach (var f in copyFrom.GetType().GetFields(flags)) {
				if (targetDic.ContainsKey(f.Name))
					targetDic[f.Name].SetValue(ret, f.GetValue(copyFrom));
				else if(throwExceptions)
					throw new InvalidOperationException(string.Format(
						"The field “{0}” has no corresponding field in the type “{1}”.",
						f.Name, typeof(TTarget).FullName));
			}
			return ret;
		}
	}
}
