using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CrankComponent : ActorComponent {
		[Serialize("controlOffset")] public Vector2 controlOffset;
		[Serialize("textPos"      )] public Vector2 textPos;
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

