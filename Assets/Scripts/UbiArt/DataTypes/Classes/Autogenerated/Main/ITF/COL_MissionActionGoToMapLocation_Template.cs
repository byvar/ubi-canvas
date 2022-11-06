using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionGoToMapLocation_Template : CSerializable {
		[Description("location to go to")]
		public StringID mapLocationId;
		public bool unlock;
		public bool save;
		public Enum_transitionType transitionType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapLocationId = s.SerializeObject<StringID>(mapLocationId, name: "mapLocationId");
			unlock = s.Serialize<bool>(unlock, name: "unlock", options: CSerializerObject.Options.BoolAsByte);
			save = s.Serialize<bool>(save, name: "save", options: CSerializerObject.Options.BoolAsByte);
			transitionType = s.Serialize<Enum_transitionType>(transitionType, name: "transitionType");
		}
		public enum Enum_transitionType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x9F88ACC6;
	}
}

