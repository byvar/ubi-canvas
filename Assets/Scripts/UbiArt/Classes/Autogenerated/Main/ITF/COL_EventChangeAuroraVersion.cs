using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventChangeAuroraVersion : Event {
		[Description("Aurora's version")]
		public Enum_version version;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<Enum_version>(version, name: "version");
		}
		public enum Enum_version {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xC678168C;
	}
}

