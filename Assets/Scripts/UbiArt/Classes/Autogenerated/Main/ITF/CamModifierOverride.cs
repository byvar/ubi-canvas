using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class CamModifierOverride : CSerializable {
		[Serialize("constraintLeftIsActive"  )] public bool constraintLeftIsActive;
		[Serialize("constraintRightIsActive" )] public bool constraintRightIsActive;
		[Serialize("constraintTopIsActive"   )] public bool constraintTopIsActive;
		[Serialize("constraintBottomIsActive")] public bool constraintBottomIsActive;
		[Serialize("constraintMatchView"     )] public bool constraintMatchView;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(constraintLeftIsActive));
				SerializeField(s, nameof(constraintRightIsActive));
				SerializeField(s, nameof(constraintTopIsActive));
				SerializeField(s, nameof(constraintBottomIsActive));
				SerializeField(s, nameof(constraintMatchView));
			}
		}
	}
}

