using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BreakablePropsComponent_Template : ActorComponent_Template {
		public bool noAnimForEmpty;
		public StringID defaultAnim;
		public StringID explodeAnim;
		public StringID emptyAnim;
		public StringID squashAnim;
		public StringID shakeAnim;
		public StringID breathlessAnim;
		public float shakeShapeRadius;
		public float shakeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			noAnimForEmpty = s.Serialize<bool>(noAnimForEmpty, name: "noAnimForEmpty");
			defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
			explodeAnim = s.SerializeObject<StringID>(explodeAnim, name: "explodeAnim");
			emptyAnim = s.SerializeObject<StringID>(emptyAnim, name: "emptyAnim");
			squashAnim = s.SerializeObject<StringID>(squashAnim, name: "squashAnim");
			shakeAnim = s.SerializeObject<StringID>(shakeAnim, name: "shakeAnim");
			breathlessAnim = s.SerializeObject<StringID>(breathlessAnim, name: "breathlessAnim");
			shakeShapeRadius = s.Serialize<float>(shakeShapeRadius, name: "shakeShapeRadius");
			shakeTime = s.Serialize<float>(shakeTime, name: "shakeTime");
		}
		public override uint? ClassCRC => 0x5A415956;
	}
}

