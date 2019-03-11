using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchSpringMoveBase : CSerializable {
		[Serialize("elastic")] public bool elastic;
		[Serialize("reverse")] public bool reverse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elastic));
			SerializeField(s, nameof(reverse));
		}
		public override uint? ClassCRC => 0xE0D1D3C5;
	}
}

