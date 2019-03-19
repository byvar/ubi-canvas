using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class BaseObject : CSerializable {
		[Serialize("OBJECTID")] public ObjectId OBJECTID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OBJECTID));
		}
		public override uint? ClassCRC => 0xBFC64EFB;
	}
}

