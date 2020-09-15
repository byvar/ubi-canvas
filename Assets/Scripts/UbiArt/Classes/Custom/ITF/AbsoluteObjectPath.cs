using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class AbsoluteObjectPath : CSerializable {
		public PackedObjectPath packedObjectPath;
		public uint levelCRC;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			packedObjectPath = s.SerializeObject<PackedObjectPath>(packedObjectPath, name: "packedObjectPath");
			levelCRC = s.Serialize<uint>(levelCRC, name: "levelCRC");
		}
	}
}
