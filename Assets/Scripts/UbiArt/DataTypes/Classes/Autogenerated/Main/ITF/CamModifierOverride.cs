using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class CamModifierOverride : CSerializable {
		public bool constraintLeftIsActive;
		public bool constraintRightIsActive;
		public bool constraintTopIsActive;
		public bool constraintBottomIsActive;
		public bool constraintMatchView;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive");
				constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive");
				constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive");
				constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive");
				constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView");
			}
		}
	}
}

