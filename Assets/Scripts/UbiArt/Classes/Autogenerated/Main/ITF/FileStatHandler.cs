using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class FileStatHandler : StatWriter {
		[Serialize("Path"     )] public Path Path;
		[Serialize("Parser"   )] public Generic<IStatParser> Parser;
		[Serialize("Overwrite")] public bool Overwrite;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path));
			SerializeField(s, nameof(Parser));
			SerializeField(s, nameof(Overwrite));
		}
		public override uint? ClassCRC => 0xF3D80487;
	}
}

