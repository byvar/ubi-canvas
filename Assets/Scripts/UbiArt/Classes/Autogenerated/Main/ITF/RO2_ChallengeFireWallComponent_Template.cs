using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireWallComponent_Template : ActorComponent_Template {
		[Serialize("faction"     )] public uint faction;
		[Serialize("shape"       )] public Generic<PhysShape> shape;
		[Serialize("fadeDuration")] public float fadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(fadeDuration));
		}
		public override uint? ClassCRC => 0x1810F931;
	}
}

