using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TimeAttackHUDTimerComponent_Template : ActorComponent_Template {
		[Serialize("scale"                )] public float scale;
		[Serialize("screenMarginX"        )] public float screenMarginX;
		[Serialize("screenMarginY"        )] public float screenMarginY;
		[Serialize("boneTimer"            )] public StringID boneTimer;
		[Serialize("boneCup"              )] public StringID boneCup;
		[Serialize("boneElectoons"        )] public StringID boneElectoons;
		[Serialize("boneChrono"           )] public StringID boneChrono;
		[Serialize("textActorFile"        )] public Path textActorFile;
		[Serialize("timerTextSize"        )] public float timerTextSize;
		[Serialize("timerTextCriticalSize")] public float timerTextCriticalSize;
		[Serialize("prizeTextSize"        )] public float prizeTextSize;
		[Serialize("colorNormal"          )] public Color colorNormal;
		[Serialize("colorTimeCritical"    )] public Color colorTimeCritical;
		[Serialize("criticalTimeMargin"   )] public int criticalTimeMargin;
		[Serialize("criticalTimeIntervals")] public float criticalTimeIntervals;
		[Serialize("appearAnim"           )] public StringID appearAnim;
		[Serialize("standAnim"            )] public StringID standAnim;
		[Serialize("criticalFX"           )] public StringID criticalFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(screenMarginX));
			SerializeField(s, nameof(screenMarginY));
			SerializeField(s, nameof(boneTimer));
			SerializeField(s, nameof(boneCup));
			SerializeField(s, nameof(boneElectoons));
			SerializeField(s, nameof(boneChrono));
			SerializeField(s, nameof(textActorFile));
			SerializeField(s, nameof(timerTextSize));
			SerializeField(s, nameof(timerTextCriticalSize));
			SerializeField(s, nameof(prizeTextSize));
			SerializeField(s, nameof(colorNormal));
			SerializeField(s, nameof(colorTimeCritical));
			SerializeField(s, nameof(criticalTimeMargin));
			SerializeField(s, nameof(criticalTimeIntervals));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(criticalFX));
		}
		public override uint? ClassCRC => 0x129923C6;
	}
}

