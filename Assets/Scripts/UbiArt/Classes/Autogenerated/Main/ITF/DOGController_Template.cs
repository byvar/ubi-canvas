using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DOGController_Template : ActorComponent_Template {
		public bool bool__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public Path Path__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Path__4 = s.SerializeObject<Path>(Path__4, name: "Path__4");
		}
		public override uint? ClassCRC => 0x9805C852;
	}
}

