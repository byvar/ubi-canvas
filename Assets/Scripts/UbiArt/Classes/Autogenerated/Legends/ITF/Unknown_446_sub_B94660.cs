using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_446_sub_B94660 : CSerializable {
		[Serialize("stepDamageList")] public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stepDamageList));
		}
		public override uint? ClassCRC => 0x8F9D3BCF;
	}
}

