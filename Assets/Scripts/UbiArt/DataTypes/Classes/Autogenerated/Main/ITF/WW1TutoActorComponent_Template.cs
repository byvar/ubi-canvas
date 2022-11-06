using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WW1TutoActorComponent_Template : ActorComponent_Template {
		public Path Path__0;
		public float float__1;
		public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
		}
		public override uint? ClassCRC => 0xA589DFF6;
	}
}

