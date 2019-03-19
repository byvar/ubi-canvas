using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCMissionContent : CSerializable {
		[Serialize("template")] public Path template;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(template));
		}
		public override uint? ClassCRC => 0xEEF05A03;
	}
}

