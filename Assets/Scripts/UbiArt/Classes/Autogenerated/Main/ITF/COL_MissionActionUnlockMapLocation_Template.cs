using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionUnlockMapLocation_Template : CSerializable {
		[Description("location to unlock")]
		[Serialize("mapLocationId")] public StringID mapLocationId;
		[Serialize("unlock"       )] public bool unlock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapLocationId));
			SerializeField(s, nameof(unlock), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xB944FD6D;
	}
}

