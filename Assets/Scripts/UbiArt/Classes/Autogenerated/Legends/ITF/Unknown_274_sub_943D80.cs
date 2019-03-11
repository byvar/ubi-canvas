using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_274_sub_943D80 : CSerializable {
		[Serialize("leafs")] public Placeholder leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leafs));
		}
		public override uint? ClassCRC => 0x92E8BB21;
	}
}

