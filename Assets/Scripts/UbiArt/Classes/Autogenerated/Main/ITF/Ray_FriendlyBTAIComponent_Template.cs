using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyBTAIComponent_Template : BTAIComponent_Template {
		[Serialize("retaliationDuration"   )] public float retaliationDuration;
		[Serialize("squashDeathPenetration")] public float squashDeathPenetration;
		[Serialize("darktoonSpawn"         )] public Path darktoonSpawn;
		[Serialize("disappearOnRescue"     )] public int disappearOnRescue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(retaliationDuration));
			SerializeField(s, nameof(squashDeathPenetration));
			SerializeField(s, nameof(darktoonSpawn));
			SerializeField(s, nameof(disappearOnRescue));
		}
		public override uint? ClassCRC => 0x670E541F;
	}
}

