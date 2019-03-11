using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_RO_3_sub_6A1290 : CSerializable {
		[Serialize("cheatAllPlayersTogether")] public Placeholder cheatAllPlayersTogether;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cheatAllPlayersTogether));
		}
		public override uint? ClassCRC => 0x00000001;
	}
}

