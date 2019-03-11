using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ScoreBoardComponent_Template : CSerializable {
		[Serialize("baseName")] public StringID baseName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(baseName));
		}
		public override uint? ClassCRC => 0x9F283B40;
	}
}

