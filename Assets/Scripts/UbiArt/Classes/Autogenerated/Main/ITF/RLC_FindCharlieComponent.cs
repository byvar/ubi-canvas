using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_FindCharlieComponent : ActorComponent {
		public int ForcedVariant;
		public bool isTutorial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ForcedVariant = s.Serialize<int>(ForcedVariant, name: "ForcedVariant");
			isTutorial = s.Serialize<bool>(isTutorial, name: "isTutorial");
		}
		public override uint? ClassCRC => 0xBA21C73A;
	}
}

