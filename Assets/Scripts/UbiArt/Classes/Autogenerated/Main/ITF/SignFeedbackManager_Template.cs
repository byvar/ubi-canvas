using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class SignFeedbackManager_Template : TemplateObj {
		[Serialize("CArray<Path>__0")] public CArray<Path> CArray_Path__0;
		[Serialize("float__1"       )] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_Path__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x4EA0F61C;
	}
}

