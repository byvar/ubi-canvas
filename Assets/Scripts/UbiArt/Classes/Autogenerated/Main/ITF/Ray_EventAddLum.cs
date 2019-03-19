using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventAddLum : Event {
		[Serialize("isAccrobatic")] public int isAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAccrobatic));
		}
		public override uint? ClassCRC => 0xFBFE1D34;
	}
}

