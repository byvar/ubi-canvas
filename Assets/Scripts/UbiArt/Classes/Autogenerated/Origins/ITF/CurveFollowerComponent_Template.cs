using UnityEngine;

namespace UbiArt.ITF {
	public partial class CurveFollowerComponent_Template : CSerializable {
		[Serialize("speed")] public float speed;
		[Serialize("loop" )] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(loop));
		}
		public override uint? ClassCRC => 0xFBAD0887;
	}
}

