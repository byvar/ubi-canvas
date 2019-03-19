using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicPart_Template : CSerializable {
		[Serialize("name")] public StringID name;
		[Serialize("path")] public Path path;
		[Serialize("nbMeasures")] public uint nbMeasures;
		[Serialize("beatsPerBar")] public uint beatsPerBar;
		[Serialize("prefetch")] public int prefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(nbMeasures));
			SerializeField(s, nameof(beatsPerBar));
			SerializeField(s, nameof(prefetch));
		}
	}
}
