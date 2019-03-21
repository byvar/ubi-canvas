using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_BezierBranchGrowComponent : RO2_BezierBranchComponent {
		[Serialize("startCursor"  )] public float startCursor;
		[Serialize("minCursor"    )] public float minCursor;
		[Serialize("maxCursor"    )] public float maxCursor;
		[Serialize("reinitTime"   )] public float reinitTime;
		[Serialize("autoStartTime")] public float autoStartTime;
		[Serialize("growSpeed"    )] public float growSpeed;
		[Serialize("easeMode"     )] public EaseMode easeMode;
		[Serialize("useSameSpeed" )] public bool useSameSpeed;
		[Serialize("retractSpeed" )] public float retractSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(startCursor));
				SerializeField(s, nameof(useSameSpeed), boolAsByte: true);
				SerializeField(s, nameof(growSpeed));
				SerializeField(s, nameof(retractSpeed));
				SerializeField(s, nameof(easeMode));
			} else {
				SerializeField(s, nameof(startCursor));
				SerializeField(s, nameof(minCursor));
				SerializeField(s, nameof(maxCursor));
				SerializeField(s, nameof(reinitTime));
				SerializeField(s, nameof(autoStartTime));
				SerializeField(s, nameof(growSpeed));
				SerializeField(s, nameof(easeMode));
			}
		}
		public enum EaseMode {
			[Serialize("EaseMode_None"     )] None = 0,
			[Serialize("EaseMode_EaseIn"   )] EaseIn = 1,
			[Serialize("EaseMode_EaseOut"  )] EaseOut = 2,
			[Serialize("EaseMode_EaseInOut")] EaseInOut = 3,
		}
		public override uint? ClassCRC => 0x19972229;
	}
}

