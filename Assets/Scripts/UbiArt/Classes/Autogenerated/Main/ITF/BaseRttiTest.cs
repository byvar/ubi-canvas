using UnityEngine;

namespace UbiArt.ITF {
	public partial class BaseRttiTest : CSerializable {
		[Serialize("Name")] public string Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Name));
		}
		public override uint? ClassCRC => 0x39F2685A;
	}
}

