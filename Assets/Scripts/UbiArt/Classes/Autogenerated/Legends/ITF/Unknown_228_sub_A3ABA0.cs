using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_228_sub_A3ABA0 : CSerializable {
		[Serialize("influenced")] public bool influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(influenced));
		}
		public override uint? ClassCRC => 0xB6919914;
	}
}

