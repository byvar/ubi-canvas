using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsManagerComponent_Template : ActorComponent_Template {
		public Path breakablePropsPath;
		public StringID transitionAnim;
		public StringID standAnim;
		public StringID standDrcAnim;
		public StringID deathAnim;
		public StringID deathDrcAnim;
		public StringID hitAnim;
		public StringID hitDrcAnim;
		public StringID shakeAnim;
		public StringID shakeDrcAnim;
		public bool noAnimForEmpty;
		public float shakeShapeRadius;
		public float shakeTime;
		public float hitShapeRadius;
		public Vec2d hitShapeOffset;
		public StringID squashAnim;
		public StringID squashDrcAnim;
		public StringID standBrokenAnim;
		public StringID standBrokenDrcAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			breakablePropsPath = s.SerializeObject<Path>(breakablePropsPath, name: "breakablePropsPath");
			transitionAnim = s.SerializeObject<StringID>(transitionAnim, name: "transitionAnim");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			standDrcAnim = s.SerializeObject<StringID>(standDrcAnim, name: "standDrcAnim");
			deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
			deathDrcAnim = s.SerializeObject<StringID>(deathDrcAnim, name: "deathDrcAnim");
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			hitDrcAnim = s.SerializeObject<StringID>(hitDrcAnim, name: "hitDrcAnim");
			shakeAnim = s.SerializeObject<StringID>(shakeAnim, name: "shakeAnim");
			shakeDrcAnim = s.SerializeObject<StringID>(shakeDrcAnim, name: "shakeDrcAnim");
			noAnimForEmpty = s.Serialize<bool>(noAnimForEmpty, name: "noAnimForEmpty");
			shakeShapeRadius = s.Serialize<float>(shakeShapeRadius, name: "shakeShapeRadius");
			shakeTime = s.Serialize<float>(shakeTime, name: "shakeTime");
			hitShapeRadius = s.Serialize<float>(hitShapeRadius, name: "hitShapeRadius");
			hitShapeOffset = s.SerializeObject<Vec2d>(hitShapeOffset, name: "hitShapeOffset");
			squashAnim = s.SerializeObject<StringID>(squashAnim, name: "squashAnim");
			squashDrcAnim = s.SerializeObject<StringID>(squashDrcAnim, name: "squashDrcAnim");
			standBrokenAnim = s.SerializeObject<StringID>(standBrokenAnim, name: "standBrokenAnim");
			standBrokenDrcAnim = s.SerializeObject<StringID>(standBrokenDrcAnim, name: "standBrokenDrcAnim");
		}
		public override uint? ClassCRC => 0x1494BBE0;
	}
}

