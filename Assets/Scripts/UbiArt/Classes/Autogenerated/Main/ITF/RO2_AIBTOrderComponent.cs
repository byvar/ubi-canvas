using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBTOrderComponent : ActorComponent {
		[Serialize("enabled")] public bool enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enabled));
		}
		public override uint? ClassCRC => 0x3B9C29D8;
	}
}

