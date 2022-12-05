namespace UbiArt {
	public class PathConversionRule {
		public string Find { get; set; }
		public string Replace { get; set; }

		public PathConversionRule(string find, string replace) {
			Find = find;
			Replace = replace;
		}

		public void Apply(Path path) {
			var fullPath = path.FullPath;
			if (fullPath.Contains(Find)) {
				var newPath = fullPath.Replace(Find, Replace);
				path.FullPath = newPath;
			}
		}
	}
}
