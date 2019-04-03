using UnityEngine;

namespace UbiArt {
	[Games(GameFlags.All)]
	public partial class ArchiveMemory : ICSerializable {
		[Serialize("AMData")] public byte[] AMData;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<byte[]>(ref AMData, name: "AMData");
		}
	}
}

