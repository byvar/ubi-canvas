using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DoorTeleportComponent_Template : CSerializable {
		[Serialize("exitPointId")] public StringID exitPointId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(exitPointId));
		}
		public override uint? ClassCRC => 0x6655D7D2;
	}
}

