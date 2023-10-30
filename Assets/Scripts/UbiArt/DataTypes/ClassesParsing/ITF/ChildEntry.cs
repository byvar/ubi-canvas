using System.Linq;

namespace UbiArt.ITF {
	public partial class ChildEntry {
		public bool TryGetTagValue<T>(StringID tag, out T t) {
			t = default;
			if (TagValues == null || !TagValues.Any()) return false;

			var tagvalue = TagValues.FirstOrDefault(t => t.Tag == tag);
			if(tagvalue == null) return false;

			var value = tagvalue.Value;
			if (value == null) {
				if (typeof(T) == typeof(string)) {
					return true;
				} else {
					return false;
				}
			} else {
				if (typeof(T) == typeof(string)) {
					t = (T)(object)value;
					return true;
				} else if(typeof(T) == typeof(uint)) {
					if (uint.TryParse(value, out var res)) {
						t = (T)(object)res;
						return true;
					} else return false;
				} else if (typeof(T) == typeof(int)) {
					if (int.TryParse(value, out var res)) {
						t = (T)(object)res;
						return true;
					} else return false;
				} else if (typeof(T) == typeof(long)) {
					if (long.TryParse(value, out var res)) {
						t = (T)(object)res;
						return true;
					} else return false;
				} else if (typeof(T) == typeof(float)) {
					if (float.TryParse(value, out var res)) {
						t = (T)(object)res;
						return true;
					} else return false;
				} else if (typeof(T) == typeof(bool)) {
					switch (value.ToLowerInvariant()) {
						case "true":
							t = (T)(object)true;
							return true;
						case "false":
							t = (T)(object)false;
							return true;
						default:
							return false;
					}
				}
			}
			return false;
		}
		public bool HasTag(StringID tag) {
			if (TagValues == null || !TagValues.Any()) return false;

			return TagValues.Any(t => t.Tag == tag);
		}
		public void AddTag(StringID tag, string value) {
			if(TagValues == null) TagValues = new CListO<TagValue>();
			TagValues.Add(new TagValue() {
				Tag = tag,
				Value = value
			});
		}
	}
}
