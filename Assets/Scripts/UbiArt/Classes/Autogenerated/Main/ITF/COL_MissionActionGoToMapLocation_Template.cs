using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionGoToMapLocation_Template : CSerializable {
		[Description("location to go to")]
		[Serialize("mapLocationId" )] public StringID mapLocationId;
		[Serialize("unlock"        )] public bool unlock;
		[Serialize("save"          )] public bool save;
		[Serialize("transitionType")] public Enum_transitionType transitionType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapLocationId));
			SerializeField(s, nameof(unlock), boolAsByte: true);
			SerializeField(s, nameof(save), boolAsByte: true);
			SerializeField(s, nameof(transitionType));
		}
		public enum Enum_transitionType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x0FA6D390;
	}
}

