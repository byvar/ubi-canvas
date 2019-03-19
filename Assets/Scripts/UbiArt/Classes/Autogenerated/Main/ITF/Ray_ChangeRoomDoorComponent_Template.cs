using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangeRoomDoorComponent_Template : CSerializable {
		[Serialize("shape"      )] public Placeholder shape;
		[Serialize("shapeOffset")] public Vector2 shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(shapeOffset));
		}
		public override uint? ClassCRC => 0x5B1595FB;
	}
}

