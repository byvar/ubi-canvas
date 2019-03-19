using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCComponent_Template : CSerializable {
		[Serialize("supportSkin")] public int supportSkin;
		[Serialize("skinFamily" )] public StringID skinFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(supportSkin));
			SerializeField(s, nameof(skinFamily));
		}
		public override uint? ClassCRC => 0x601770B5;
	}
}

