using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class FileStatHandler : StatWriter {
		public Path Path;
		public Generic<IStatParser> Parser;
		public bool Overwrite;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path = s.SerializeObject<Path>(Path, name: "Path");
			Parser = s.SerializeObject<Generic<IStatParser>>(Parser, name: "Parser");
			Overwrite = s.Serialize<bool>(Overwrite, name: "Overwrite");
		}
		public override uint? ClassCRC => 0xF3D80487;
	}
}

