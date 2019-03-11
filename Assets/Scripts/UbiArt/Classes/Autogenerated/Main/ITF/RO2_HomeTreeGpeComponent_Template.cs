using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_HomeTreeGpeComponent_Template : ActorComponent_Template {
		[Serialize("appearMode"           )] public AppearMode appearMode;
		[Serialize("fadeDuration"         )] public float fadeDuration;
		[Serialize("appearAnim"           )] public StringID appearAnim;
		[Serialize("idleAnim"             )] public StringID idleAnim;
		[Serialize("scaleActor"           )] public bool scaleActor;
		[Serialize("trunkAttachCurveLimit")] public float trunkAttachCurveLimit;
		[Serialize("trunkAttachCurveWidth")] public float trunkAttachCurveWidth;
		[Serialize("appearMode"           )] public Enum_appearMode appearMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(appearMode));
				SerializeField(s, nameof(fadeDuration));
				SerializeField(s, nameof(appearAnim));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(scaleActor));
				SerializeField(s, nameof(trunkAttachCurveLimit));
				SerializeField(s, nameof(trunkAttachCurveWidth));
			} else {
				SerializeField(s, nameof(appearMode));
				SerializeField(s, nameof(fadeDuration));
				SerializeField(s, nameof(appearAnim));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(scaleActor));
				SerializeField(s, nameof(trunkAttachCurveLimit));
				SerializeField(s, nameof(trunkAttachCurveWidth));
			}
		}
		public enum AppearMode {
			[Serialize("AppearMode_None"        )] None = 0,
			[Serialize("AppearMode_ScaleAndFade")] ScaleAndFade = 1,
			[Serialize("AppearMode_Anim"        )] Anim = 2,
			[Serialize("AppearMode_Grow"        )] Grow = 3,
		}
		public enum Enum_appearMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x22B261CD;
	}
}

