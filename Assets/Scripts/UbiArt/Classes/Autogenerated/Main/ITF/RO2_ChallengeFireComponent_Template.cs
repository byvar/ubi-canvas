using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireComponent_Template : ActorComponent_Template {
		[Serialize("faction")] public uint faction;
		[Serialize("shape"  )] public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(shape));
		}
		public override uint? ClassCRC => 0x93E43FDB;
	}
}

