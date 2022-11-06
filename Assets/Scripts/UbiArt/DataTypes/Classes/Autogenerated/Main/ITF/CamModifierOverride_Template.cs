using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class CamModifierOverride_Template : CSerializable {
		public int modifierBlend;
		public int modifierInertie;
		public int constraintDelayToActivate;
		public int constraintDelayToDisable;
		public int cameraLookAtOffset;
		public int cameraLookAtOffsetMaxInMulti;
		public int focale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			modifierBlend = s.Serialize<int>(modifierBlend, name: "modifierBlend");
			modifierInertie = s.Serialize<int>(modifierInertie, name: "modifierInertie");
			constraintDelayToActivate = s.Serialize<int>(constraintDelayToActivate, name: "constraintDelayToActivate");
			constraintDelayToDisable = s.Serialize<int>(constraintDelayToDisable, name: "constraintDelayToDisable");
			cameraLookAtOffset = s.Serialize<int>(cameraLookAtOffset, name: "cameraLookAtOffset");
			cameraLookAtOffsetMaxInMulti = s.Serialize<int>(cameraLookAtOffsetMaxInMulti, name: "cameraLookAtOffsetMaxInMulti");
			focale = s.Serialize<int>(focale, name: "focale");
		}
	}
}

