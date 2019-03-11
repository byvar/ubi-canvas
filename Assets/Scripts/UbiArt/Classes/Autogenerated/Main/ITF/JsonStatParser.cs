using UnityEngine;

namespace UbiArt.ITF {
	public partial class JsonStatParser : IStatParser {
		[Serialize("Pretty"    )] public bool Pretty;
		[Serialize("AddNewLine")] public bool AddNewLine;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Pretty));
			SerializeField(s, nameof(AddNewLine));
		}
		public override uint? ClassCRC => 0x45A22E0B;
	}
}

