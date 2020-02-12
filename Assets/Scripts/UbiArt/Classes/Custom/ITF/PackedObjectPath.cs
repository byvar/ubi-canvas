using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class PackedObjectPath : CSerializable {
		[Serialize("id"      )] public ObjectId id;
		[Serialize("pathCode")] public uint pathCode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(pathCode));
		}
	}
}