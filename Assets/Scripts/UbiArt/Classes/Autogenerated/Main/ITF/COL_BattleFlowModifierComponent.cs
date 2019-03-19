using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleFlowModifierComponent : CSerializable {
		[Serialize("IntroCinematicID"    )] public StringID IntroCinematicID;
		[Serialize("OutroWinCinematicID" )] public StringID OutroWinCinematicID;
		[Serialize("OutroLossCinematicID")] public StringID OutroLossCinematicID;
		[Serialize("SynchronousIntro"    )] public int SynchronousIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IntroCinematicID));
			SerializeField(s, nameof(OutroWinCinematicID));
			SerializeField(s, nameof(OutroLossCinematicID));
			SerializeField(s, nameof(SynchronousIntro));
		}
		public override uint? ClassCRC => 0x22DEFD90;
	}
}

