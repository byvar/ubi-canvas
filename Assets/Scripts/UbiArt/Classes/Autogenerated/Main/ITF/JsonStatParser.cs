using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class JsonStatParser : IStatParser {
		public bool Pretty;
		public bool AddNewLine;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Pretty = s.Serialize<bool>(Pretty, name: "Pretty");
			AddNewLine = s.Serialize<bool>(AddNewLine, name: "AddNewLine");
		}
		public override uint? ClassCRC => 0x45A22E0B;
	}
}

