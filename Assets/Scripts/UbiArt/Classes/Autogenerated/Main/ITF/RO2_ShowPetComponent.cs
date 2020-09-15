using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ShowPetComponent : GraphicComponent {
		public uint VisualID;
		public Enum_Animation Animation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				VisualID = s.Serialize<uint>(VisualID, name: "VisualID");
				Animation = s.Serialize<Enum_Animation>(Animation, name: "Animation");
			}
		}
		public enum Enum_Animation {
			[Serialize("Stand")] Stand = 0,
			[Serialize("Happy")] Happy = 1,
		}
		public override uint? ClassCRC => 0xB5EDC5A2;
	}
}

