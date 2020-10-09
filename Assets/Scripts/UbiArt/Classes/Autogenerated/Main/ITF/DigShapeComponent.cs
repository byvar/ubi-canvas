using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class DigShapeComponent : ActorComponent {
		public Action action;
		public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				action = s.Serialize<Action>(action, name: "Action");
				Radius = s.Serialize<float>(Radius, name: "Radius");
			}
		}
		public enum Action {
			[Serialize("Action_Dig" )] Dig = 0,
			[Serialize("Action_Fill")] Fill = 1,
		}
		public override uint? ClassCRC => 0xD6181D14;
	}
}

