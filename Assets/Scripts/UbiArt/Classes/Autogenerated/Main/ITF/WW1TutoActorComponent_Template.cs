using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WW1TutoActorComponent_Template : ActorComponent_Template {
		[Serialize("Path__0" )] public Path Path__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("float__2")] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
		}
		public override uint? ClassCRC => 0xA589DFF6;
	}
}

