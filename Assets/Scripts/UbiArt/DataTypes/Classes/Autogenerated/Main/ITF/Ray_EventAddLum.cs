using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventAddLum : Event {
		public int isAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isAccrobatic = s.Serialize<int>(isAccrobatic, name: "isAccrobatic");
		}
		public override uint? ClassCRC => 0xFBFE1D34;
	}
}

