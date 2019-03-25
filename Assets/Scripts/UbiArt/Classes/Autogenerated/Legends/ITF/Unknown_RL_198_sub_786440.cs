using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_198_sub_786440 : ActorComponent {
		[Serialize("shape"                )] public EditableShape shape;
		[Serialize("detectDangerousGround")] public bool detectDangerousGround;
		[Serialize("broken"               )] public int broken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(detectDangerousGround), boolAsByte: true);
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(broken));
			}
		}
		public override uint? ClassCRC => 0x0A7203EA;
	}
}

