using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RL)]
	public partial class RO2_DigShapeComponent : ActorComponent {
		public Enum_Action Action;
		public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Action = s.Serialize<Enum_Action>(Action, name: "Action");
				Radius = s.Serialize<float>(Radius, name: "Radius");
			}
		}
		public enum Enum_Action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x062BFA66;
	}
}

