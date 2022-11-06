using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsIAPScoreCondition : online.GameGlobalsCondition {
		public uint score;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			score = s.Serialize<uint>(score, name: "score");
		}
		public override uint? ClassCRC => 0x0A924DE7;
	}
}

