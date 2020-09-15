using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchGrowComponent : BezierBranchComponent {
		public float startCursor;
		public float minCursor;
		public float maxCursor;
		public float reinitTime;
		public float autoStartTime;
		public float growSpeed;
		public EaseMode easeMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				startCursor = s.Serialize<float>(startCursor, name: "startCursor");
				growSpeed = s.Serialize<float>(growSpeed, name: "growSpeed");
				easeMode = s.Serialize<EaseMode>(easeMode, name: "easeMode");
			} else {
				startCursor = s.Serialize<float>(startCursor, name: "startCursor");
				minCursor = s.Serialize<float>(minCursor, name: "minCursor");
				maxCursor = s.Serialize<float>(maxCursor, name: "maxCursor");
				reinitTime = s.Serialize<float>(reinitTime, name: "reinitTime");
				autoStartTime = s.Serialize<float>(autoStartTime, name: "autoStartTime");
				growSpeed = s.Serialize<float>(growSpeed, name: "growSpeed");
				easeMode = s.Serialize<EaseMode>(easeMode, name: "easeMode");
			}
		}
		public enum EaseMode {
			[Serialize("EaseMode_None"     )] None = 0,
			[Serialize("EaseMode_EaseIn"   )] EaseIn = 1,
			[Serialize("EaseMode_EaseOut"  )] EaseOut = 2,
			[Serialize("EaseMode_EaseInOut")] EaseInOut = 3,
		}
		public override uint? ClassCRC => 0x1BCECA5E;
	}
}

