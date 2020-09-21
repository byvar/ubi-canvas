using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class SignFeedbackManager_Template : TemplateObj {
		public CArrayO<Path> CArray_Path__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_Path__0 = s.SerializeObject<CArrayO<Path>>(CArray_Path__0, name: "CArray_Path__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x4EA0F61C;
	}
}

