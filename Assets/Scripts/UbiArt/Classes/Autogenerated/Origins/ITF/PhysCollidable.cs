using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysCollidable : CSerializable {
		[Serialize("OBJECTID")] public ObjectId OBJECTID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OBJECTID));
		}
		public override uint? ClassCRC => 0x69317427;
	}
}

