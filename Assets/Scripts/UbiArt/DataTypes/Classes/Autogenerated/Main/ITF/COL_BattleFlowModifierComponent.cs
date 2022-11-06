using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleFlowModifierComponent : CSerializable {
		public StringID IntroCinematicID;
		public StringID OutroWinCinematicID;
		public StringID OutroLossCinematicID;
		public int SynchronousIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IntroCinematicID = s.SerializeObject<StringID>(IntroCinematicID, name: "IntroCinematicID");
			OutroWinCinematicID = s.SerializeObject<StringID>(OutroWinCinematicID, name: "OutroWinCinematicID");
			OutroLossCinematicID = s.SerializeObject<StringID>(OutroLossCinematicID, name: "OutroLossCinematicID");
			SynchronousIntro = s.Serialize<int>(SynchronousIntro, name: "SynchronousIntro");
		}
		public override uint? ClassCRC => 0xF4D8C124;
	}
}

