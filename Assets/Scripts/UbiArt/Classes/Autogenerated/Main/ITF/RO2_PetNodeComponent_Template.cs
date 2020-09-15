using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetNodeComponent_Template : ActorComponent_Template {
		public float invalidationRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invalidationRadius = s.Serialize<float>(invalidationRadius, name: "invalidationRadius");
		}
		public override uint? ClassCRC => 0xCFFDAC34;
	}
}

