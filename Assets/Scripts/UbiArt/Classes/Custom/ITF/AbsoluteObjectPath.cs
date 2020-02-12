using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class AbsoluteObjectPath : CSerializable {
		[Serialize("packedObjectPath")] public PackedObjectPath packedObjectPath;
		[Serialize("levelCRC"        )] public uint levelCRC;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(packedObjectPath));
			SerializeField(s, nameof(levelCRC));
		}
	}
}