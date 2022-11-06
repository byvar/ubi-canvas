using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ScoreBoardComponent_Template : CSerializable {
		public StringID baseName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			baseName = s.SerializeObject<StringID>(baseName, name: "baseName");
		}
		public override uint? ClassCRC => 0x9F283B40;
	}
}

