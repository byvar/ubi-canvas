using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightPuzzlePieceActivation : Event {
		public int Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Activate = s.Serialize<int>(Activate, name: "Activate");
		}
		public override uint? ClassCRC => 0xCF157F79;
	}
}

