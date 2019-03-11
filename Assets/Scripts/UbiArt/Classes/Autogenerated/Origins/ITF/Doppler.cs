using UnityEngine;

namespace UbiArt.ITF {
	public partial class Doppler : CSerializable {
		[Serialize("factor")] public float factor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factor));
		}
		public override uint? ClassCRC => 0xF0C59556;
	}
}

