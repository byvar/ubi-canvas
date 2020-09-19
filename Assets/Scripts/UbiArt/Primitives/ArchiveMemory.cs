using UnityEngine;

namespace UbiArt {
	[Games(GameFlags.All)]
	public partial class ArchiveMemory : ICSerializable {
		public byte[] AMData;

		public void Serialize(CSerializerObject s, string name) {
			AMData = s.Serialize<byte[]>(AMData, name: "AMData");
		}
	}
}

