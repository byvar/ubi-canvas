using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionUnlockMapLocation_Template : CSerializable {
		[Description("location to unlock")]
		public StringID mapLocationId;
		public bool unlock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapLocationId = s.SerializeObject<StringID>(mapLocationId, name: "mapLocationId");
			unlock = s.Serialize<bool>(unlock, name: "unlock", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xB944FD6D;
	}
}

