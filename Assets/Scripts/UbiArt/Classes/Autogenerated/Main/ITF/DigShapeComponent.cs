using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigShapeComponent : ActorComponent {
		[Serialize("Action")] public Action Action;
		[Serialize("Radius")] public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Action));
				SerializeField(s, nameof(Radius));
			}
		}
		public enum Action {
			[Serialize("Action_Dig" )] Dig = 0,
			[Serialize("Action_Fill")] Fill = 1,
		}
		public override uint? ClassCRC => 0xD6181D14;
	}
}

