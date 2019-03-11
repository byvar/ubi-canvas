using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_281_sub_9DEC30 : CSerializable {
		[Serialize("near" )] public float near;
		[Serialize("far"  )] public float far;
		[Serialize("color")] public Color color;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(near));
				SerializeField(s, nameof(far));
				SerializeField(s, nameof(color));
			}
		}
		public override uint? ClassCRC => 0x6734D562;
	}
}

