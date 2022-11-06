using System.Linq;

namespace UbiArt.ITF {
	public partial class Scene {
		// Returns whether actor was added to scene successfully
		public bool AddActor(Actor a, string name) {
			if (ACTORS != null && a != null && !ACTORS.Any(ac => ac.obj != null && ac.obj == a)) {
				if (a.USERFRIENDLY == null || a.USERFRIENDLY.Length == 0) {
					a.USERFRIENDLY = name;
					int i = 0;
					while(ACTORS.Any(ac => !ac.IsNull && ac.obj.USERFRIENDLY == a.USERFRIENDLY)) {
						a.USERFRIENDLY = $"{name}@{i}";
						i++;
					}
				}
				ACTORS.Add(new Generic<Actor>(a));

				return true;
			}
			return false;
		}
	}
}
