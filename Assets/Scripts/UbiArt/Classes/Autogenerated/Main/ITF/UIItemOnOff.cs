using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIItemOnOff : UIItemBasic {
		[Serialize("selectTextStyle"     )] public uint selectTextStyle;
		[Serialize("selectAnimMeshVertex")] public CList<StringID> selectAnimMeshVertex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(selectTextStyle));
			SerializeField(s, nameof(selectAnimMeshVertex));
		}
		public override uint? ClassCRC => 0x38632292;
	}
}

