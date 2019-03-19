using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HangSpotComponent : ActorComponent {
		[Serialize("keepOrientation")] public bool keepOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(keepOrientation));
		}
		public override uint? ClassCRC => 0x5941DEB5;
	}
}

