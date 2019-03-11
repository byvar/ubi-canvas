using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstruction : CSerializable {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
		}
		public override uint? ClassCRC => 0x2AA49880;
	}
}

