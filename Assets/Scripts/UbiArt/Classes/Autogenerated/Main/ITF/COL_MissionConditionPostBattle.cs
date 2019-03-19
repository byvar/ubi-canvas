using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionPostBattle : CSerializable {
		[Serialize("COL_GameScreen_Exploration")] public Placeholder COL_GameScreen_Exploration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(COL_GameScreen_Exploration));
		}
		public override uint? ClassCRC => 0x1E7456E4;
	}
}

