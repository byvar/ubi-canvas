using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsIAPScoreCondition : online.GameGlobalsCondition {
		[Serialize("score")] public uint score;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(score));
		}
		public override uint? ClassCRC => 0x0A924DE7;
	}
}

