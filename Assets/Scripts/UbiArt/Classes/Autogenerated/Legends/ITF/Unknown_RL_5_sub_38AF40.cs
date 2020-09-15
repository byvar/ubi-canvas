using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_5_sub_38AF40 : SoundCommand {
		public CList<StringID> buslist;
		public float frequency;
		public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buslist = s.SerializeObject<CList<StringID>>(buslist, name: "buslist");
			frequency = s.Serialize<float>(frequency, name: "frequency");
			type = s.Serialize<Enum_type>(type, name: "type");
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xB65D7B19;
	}
}

