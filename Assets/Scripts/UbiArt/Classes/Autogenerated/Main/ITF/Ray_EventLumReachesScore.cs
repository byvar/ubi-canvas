using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventLumReachesScore : Event {
		public int isAccrobatic;
		public uint valueToAdd;
		public uint playerIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isAccrobatic = s.Serialize<int>(isAccrobatic, name: "isAccrobatic");
			valueToAdd = s.Serialize<uint>(valueToAdd, name: "valueToAdd");
			playerIndex = s.Serialize<uint>(playerIndex, name: "playerIndex");
		}
		public override uint? ClassCRC => 0x70289424;
	}
}

