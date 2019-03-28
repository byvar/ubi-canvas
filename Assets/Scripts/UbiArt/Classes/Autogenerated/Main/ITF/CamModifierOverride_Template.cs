using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class CamModifierOverride_Template : CSerializable {
		[Serialize("modifierBlend"               )] public int modifierBlend;
		[Serialize("modifierInertie"             )] public int modifierInertie;
		[Serialize("constraintDelayToActivate"   )] public int constraintDelayToActivate;
		[Serialize("constraintDelayToDisable"    )] public int constraintDelayToDisable;
		[Serialize("cameraLookAtOffset"          )] public int cameraLookAtOffset;
		[Serialize("cameraLookAtOffsetMaxInMulti")] public int cameraLookAtOffsetMaxInMulti;
		[Serialize("focale"                      )] public int focale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(modifierBlend));
			SerializeField(s, nameof(modifierInertie));
			SerializeField(s, nameof(constraintDelayToActivate));
			SerializeField(s, nameof(constraintDelayToDisable));
			SerializeField(s, nameof(cameraLookAtOffset));
			SerializeField(s, nameof(cameraLookAtOffsetMaxInMulti));
			SerializeField(s, nameof(focale));
		}
	}
}

