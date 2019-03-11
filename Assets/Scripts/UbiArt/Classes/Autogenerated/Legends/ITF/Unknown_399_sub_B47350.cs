using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_399_sub_B47350 : CSerializable {
		[Serialize("Speed"  )] public float Speed;
		[Serialize("Gravity")] public float Gravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Speed));
			SerializeField(s, nameof(Gravity));
		}
		public override uint? ClassCRC => 0xE535E8BD;
	}
}

