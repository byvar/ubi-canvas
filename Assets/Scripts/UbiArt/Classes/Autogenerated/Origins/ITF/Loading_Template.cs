using UnityEngine;

namespace UbiArt.ITF {
	public partial class Loading_Template : CSerializable {
		[Serialize("filename"  )] public CString filename;
		[Serialize("filenameRU")] public CString filenameRU;
		[Serialize("cameraz"   )] public float cameraz;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(filename));
			SerializeField(s, nameof(filenameRU));
			SerializeField(s, nameof(cameraz));
		}
		public override uint? ClassCRC => 0x283EC81C;
	}
}

