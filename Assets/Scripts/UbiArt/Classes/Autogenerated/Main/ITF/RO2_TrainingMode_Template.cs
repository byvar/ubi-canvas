using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrainingMode_Template : RO2_ChallengeCommon_Template {
		[Serialize("useListOrder"        )] public bool useListOrder;
		[Serialize("timerPath"           )] public Path timerPath;
		[Serialize("challengeDuration"   )] public float challengeDuration;
		[Serialize("endBrickSuccessDelay")] public float endBrickSuccessDelay;
		[Serialize("endBrickFailureDelay")] public float endBrickFailureDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useListOrder));
			SerializeField(s, nameof(timerPath));
			SerializeField(s, nameof(challengeDuration));
			SerializeField(s, nameof(endBrickSuccessDelay));
			SerializeField(s, nameof(endBrickFailureDelay));
		}
		public override uint? ClassCRC => 0x92699D61;
	}
}

