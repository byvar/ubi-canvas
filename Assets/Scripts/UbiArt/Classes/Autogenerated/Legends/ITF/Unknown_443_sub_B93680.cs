using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_443_sub_B93680 : CSerializable {
		[Serialize("piecesDataList")] public Placeholder piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(piecesDataList));
		}
		public override uint? ClassCRC => 0xA4369574;
	}
}

