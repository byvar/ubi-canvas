using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeGpeComponent_Template : ActorComponent_Template {
		[Serialize("appearMode"           )] public AppearMode appearMode;
		[Serialize("fadeDuration"         )] public float fadeDuration;
		[Serialize("appearAnim"           )] public StringID appearAnim;
		[Serialize("idleAnim"             )] public StringID idleAnim;
		[Serialize("scaleActor"           )] public bool scaleActor;
		[Serialize("trunkAttachCurveLimit")] public float trunkAttachCurveLimit;
		[Serialize("trunkAttachCurveWidth")] public float trunkAttachCurveWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(appearMode));
			SerializeField(s, nameof(fadeDuration));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(scaleActor));
			SerializeField(s, nameof(trunkAttachCurveLimit));
			SerializeField(s, nameof(trunkAttachCurveWidth));
		}
		public enum AppearMode {
			[Serialize("AppearMode_None"        )] None = 0,
			[Serialize("AppearMode_ScaleAndFade")] ScaleAndFade = 1,
			[Serialize("AppearMode_Anim"        )] Anim = 2,
			[Serialize("AppearMode_Grow"        )] Grow = 3,
		}
		public override uint? ClassCRC => 0x30DD0907;
	}
}

