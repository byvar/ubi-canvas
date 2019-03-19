using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventAddLum : Event {
		[Serialize("isAccrobatic")] public bool isAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAccrobatic));
		}
		public override uint? ClassCRC => 0xFF53A9D7;
	}
}

