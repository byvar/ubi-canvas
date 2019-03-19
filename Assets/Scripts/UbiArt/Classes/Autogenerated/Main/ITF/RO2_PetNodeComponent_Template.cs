using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetNodeComponent_Template : ActorComponent_Template {
		[Serialize("invalidationRadius")] public float invalidationRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invalidationRadius));
		}
		public override uint? ClassCRC => 0xCFFDAC34;
	}
}

