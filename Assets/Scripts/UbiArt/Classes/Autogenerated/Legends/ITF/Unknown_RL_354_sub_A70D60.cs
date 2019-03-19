using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_354_sub_A70D60 : CSerializable {
		[Serialize("Action")] public Enum_Action Action;
		[Serialize("Radius")] public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Action));
				SerializeField(s, nameof(Radius));
			}
		}
		public enum Enum_Action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x062BFA66;
	}
}

