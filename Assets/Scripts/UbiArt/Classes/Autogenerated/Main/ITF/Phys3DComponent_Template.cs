using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Phys3DComponent_Template : ActorComponent_Template {
		[Serialize("gravity" )] public float gravity;
		[Serialize("friction")] public float friction;
		[Serialize("mass"    )] public float mass;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(friction));
			SerializeField(s, nameof(mass));
		}
		public override uint? ClassCRC => 0xA65D5F48;
	}
}

