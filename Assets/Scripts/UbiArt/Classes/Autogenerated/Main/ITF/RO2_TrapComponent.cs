using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrapComponent : ActorComponent {
		[Serialize("isTrapped")] public bool isTrapped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isTrapped));
		}
		public override uint? ClassCRC => 0xBC91C26F;
	}
}

