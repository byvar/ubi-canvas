using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TimeAttackHUDTimerComponent_Template : ActorComponent_Template {
		public float scale;
		public float screenMarginX;
		public float screenMarginY;
		public StringID boneTimer;
		public StringID boneCup;
		public StringID boneElectoons;
		public StringID boneChrono;
		public Path textActorFile;
		public float timerTextSize;
		public float timerTextCriticalSize;
		public float prizeTextSize;
		public Color colorNormal;
		public Color colorTimeCritical;
		public int criticalTimeMargin;
		public float criticalTimeIntervals;
		public StringID appearAnim;
		public StringID standAnim;
		public StringID criticalFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scale = s.Serialize<float>(scale, name: "scale");
			screenMarginX = s.Serialize<float>(screenMarginX, name: "screenMarginX");
			screenMarginY = s.Serialize<float>(screenMarginY, name: "screenMarginY");
			boneTimer = s.SerializeObject<StringID>(boneTimer, name: "boneTimer");
			boneCup = s.SerializeObject<StringID>(boneCup, name: "boneCup");
			boneElectoons = s.SerializeObject<StringID>(boneElectoons, name: "boneElectoons");
			boneChrono = s.SerializeObject<StringID>(boneChrono, name: "boneChrono");
			textActorFile = s.SerializeObject<Path>(textActorFile, name: "textActorFile");
			timerTextSize = s.Serialize<float>(timerTextSize, name: "timerTextSize");
			timerTextCriticalSize = s.Serialize<float>(timerTextCriticalSize, name: "timerTextCriticalSize");
			prizeTextSize = s.Serialize<float>(prizeTextSize, name: "prizeTextSize");
			colorNormal = s.SerializeObject<Color>(colorNormal, name: "colorNormal");
			colorTimeCritical = s.SerializeObject<Color>(colorTimeCritical, name: "colorTimeCritical");
			criticalTimeMargin = s.Serialize<int>(criticalTimeMargin, name: "criticalTimeMargin");
			criticalTimeIntervals = s.Serialize<float>(criticalTimeIntervals, name: "criticalTimeIntervals");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			criticalFX = s.SerializeObject<StringID>(criticalFX, name: "criticalFX");
		}
		public override uint? ClassCRC => 0xA3BB64DA;
	}
}

