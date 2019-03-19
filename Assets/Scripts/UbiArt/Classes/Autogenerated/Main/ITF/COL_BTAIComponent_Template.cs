using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTAIComponent_Template : CSerializable {
		[Serialize("registerToAIManager")] public int registerToAIManager;
		[Serialize("faction"            )] public uint faction;
		[Serialize("defaultOrientation" )] public Enum_defaultOrientation defaultOrientation;
		[Serialize("groundCheckDistance")] public float groundCheckDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(registerToAIManager));
			SerializeField(s, nameof(faction));
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(defaultOrientation));
				SerializeField(s, nameof(groundCheckDistance));
			}
		}
		public enum Enum_defaultOrientation {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x9DC40808;
	}
}

