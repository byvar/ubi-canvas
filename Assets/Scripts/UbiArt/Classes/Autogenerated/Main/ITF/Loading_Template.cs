using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Loading_Template : CSerializable {
		public CString filename;
		public CString filenameRU;
		public float cameraz;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			filename = s.Serialize<CString>(filename, name: "filename");
			filenameRU = s.Serialize<CString>(filenameRU, name: "filenameRU");
			cameraz = s.Serialize<float>(cameraz, name: "cameraz");
		}
		public override uint? ClassCRC => 0x283EC81C;
	}
}

