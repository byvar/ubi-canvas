using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_8_sub_389600 : SoundCommand {
		public StringID name;
		public int activate;
		public BusMix busParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			activate = s.Serialize<int>(activate, name: "activate");
			busParams = s.SerializeObject<BusMix>(busParams, name: "busParams");
		}
		public override uint? ClassCRC => 0xA61DB3DB;
	}
}

