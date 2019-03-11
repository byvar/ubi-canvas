using UnityEngine;

namespace UbiArt.ITF {
	public partial class ControlPitch : CSerializable {
		[Serialize("input")] public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
		}
		public override uint? ClassCRC => 0x9BBD8C4E;
	}
}

