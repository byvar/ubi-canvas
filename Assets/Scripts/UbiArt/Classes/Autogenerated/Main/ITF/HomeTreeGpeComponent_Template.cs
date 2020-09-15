using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeGpeComponent_Template : ActorComponent_Template {
		public AppearMode appearMode;
		public float fadeDuration;
		public StringID appearAnim;
		public StringID idleAnim;
		public bool scaleActor;
		public float trunkAttachCurveLimit;
		public float trunkAttachCurveWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			appearMode = s.Serialize<AppearMode>(appearMode, name: "appearMode");
			fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			scaleActor = s.Serialize<bool>(scaleActor, name: "scaleActor");
			trunkAttachCurveLimit = s.Serialize<float>(trunkAttachCurveLimit, name: "trunkAttachCurveLimit");
			trunkAttachCurveWidth = s.Serialize<float>(trunkAttachCurveWidth, name: "trunkAttachCurveWidth");
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

