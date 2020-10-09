using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchGrowComponent : RO2_BezierBranchComponent {
		public float startCursor;
		public float minCursor;
		public float maxCursor;
		public float reinitTime;
		public float autoStartTime;
		public float growSpeed;
		public EaseMode easeMode;
		public bool useSameSpeed;
		public float retractSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				startCursor = s.Serialize<float>(startCursor, name: "startCursor");
				useSameSpeed = s.Serialize<bool>(useSameSpeed, name: "useSameSpeed", options: CSerializerObject.Options.BoolAsByte);
				growSpeed = s.Serialize<float>(growSpeed, name: "growSpeed");
				retractSpeed = s.Serialize<float>(retractSpeed, name: "retractSpeed");
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
		public override uint? ClassCRC => 0x19972229;
	}
}

