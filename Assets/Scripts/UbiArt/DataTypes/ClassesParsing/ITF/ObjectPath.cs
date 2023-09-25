using System.Text;

namespace UbiArt.ITF {
	public partial class ObjectPath {
		public override string ToString() => $"ObjectPath({FullPath})";

		public const char PathSeparator = '|';

		public ObjectPath() { }
		public ObjectPath(string path) {
			FullPath = path;
		}

		public string FullPath {
			get {
				StringBuilder b = new();
				if (levels != null) {
					foreach (var l in levels) {
						if (l.parent) {
							b.Append("..");
						} else {
							b.Append(l.name ?? "");
						}
						b.Append(PathSeparator);
					}
				}
				if (id != null) {
					b.Append(id ?? "");
				}
				return b.ToString();
			}
			set {
				if (value == null) {
					absolute = false;
					id = "";
					levels = new CListO<Level>();
				} else {
					var str = value.Trim();

					// Absolute path?
					if (str.Contains(PathSeparator)) {
						absolute = (str.Contains(".isc") && (str.IndexOf(".isc") < str.IndexOf(PathSeparator)));
					} else {
						absolute = false;
					}

					// Has levels?
					if (str.Contains(PathSeparator)) {
						var strs = str.Split(PathSeparator);
						levels = new CListO<Level>();
						for (int i = 0; i < strs.Length - 1; i++) {
							var levelStr = strs[i];
							if (levelStr == "..") {
								levels.Add(new Level() {
									name = "",
									parent = true
								});
							} else {
								levels.Add(new Level() {
									name = levelStr,
									parent = false
								});
							}
						}
						id = strs[strs.Length - 1];
					} else {
						levels = new CListO<Level>();
						id = str;
					}
				}
			}
		}
	}
}

