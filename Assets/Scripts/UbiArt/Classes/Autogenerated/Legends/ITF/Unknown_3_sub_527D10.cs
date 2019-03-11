using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_3_sub_527D10 : CSerializable {
		[Serialize("input")] public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
		}
		public override uint? ClassCRC => 0x2DEC8742;
	}
}

