using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CrankComponent : ActorComponent {
		[Serialize("controlOffset")] public Vec2d controlOffset;
		[Serialize("textPos"      )] public Vec2d textPos;
		[Serialize("shape"        )] public EditableShape shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(controlOffset));
				SerializeField(s, nameof(textPos));
				SerializeField(s, nameof(shape));
			}
		}
		public override uint? ClassCRC => 0x100FB3FF;
	}
}

