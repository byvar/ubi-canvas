using System;
using System.Text;

namespace UbiCanvas.Helpers {
    public static class TypeExtensions {
		public static string GetFormattedName(this Type t) {
			if (!t.IsGenericType || t.Name.IndexOf('`') == -1)
				return t.Name;

			StringBuilder sb = new StringBuilder();
			sb.Append(t.Name.Substring(0, t.Name.IndexOf('`')));
			sb.Append('<');
			bool appendComma = false;
			foreach (Type arg in t.GetGenericArguments()) {
				if (appendComma) sb.Append(',');
				sb.Append(GetFormattedName(arg));
				appendComma = true;
			}
			sb.Append('>');
			return sb.ToString();
		}
	}
}