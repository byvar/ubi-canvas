using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class World : CSerializable {
		[Serialize("OBJECTID")] public ObjectId OBJECTID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OBJECTID));
		}
		public override uint? ClassCRC => 0xC5218963;
	}
}

