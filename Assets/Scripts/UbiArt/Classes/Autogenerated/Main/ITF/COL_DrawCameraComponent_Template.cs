using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DrawCameraComponent_Template : CSerializable {
		[Serialize("focale")] public Angle focale;
		[Serialize("depth" )] public float depth;
		[Serialize("offset")] public Vector3 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(focale));
			SerializeField(s, nameof(depth));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x7E65B07D;
	}
}

