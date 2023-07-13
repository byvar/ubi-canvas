namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchGrowComponent : RO2_BezierBranchComponent {
		public float startCursor = 1f;
		public float minCursor = -1f;
		public float maxCursor = -1f;
		public float reinitTime = -1f;
		public float autoStartTime = -1f;
		public float growSpeed = 10f;
		public EaseMode easeMode;
		public bool useSameSpeed = true;
		public float retractSpeed = 10f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.Settings.platform == Settings.Platform.Vita) {
					startCursor = s.Serialize<float>(startCursor, name: "startCursor");
					growSpeed = s.Serialize<float>(growSpeed, name: "growSpeed");
					easeMode = s.Serialize<EaseMode>(easeMode, name: "easeMode");

					useSameSpeed = true;
					retractSpeed = growSpeed;
				} else {
					startCursor = s.Serialize<float>(startCursor, name: "startCursor");
					useSameSpeed = s.Serialize<bool>(useSameSpeed, name: "useSameSpeed", options: CSerializerObject.Options.BoolAsByte);
					growSpeed = s.Serialize<float>(growSpeed, name: "growSpeed");
					retractSpeed = s.Serialize<float>(retractSpeed, name: "retractSpeed");
					easeMode = s.Serialize<EaseMode>(easeMode, name: "easeMode");
				}
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

