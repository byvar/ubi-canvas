using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsIAPPredictionCondition : GameGlobalsCondition {
		[Serialize("minThreshold")] public float minThreshold;
		[Serialize("maxThreshold")] public float maxThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minThreshold));
			SerializeField(s, nameof(maxThreshold));
		}
		public override uint? ClassCRC => 0xB1C4F5EB;
	}
}

