using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_185_sub_767DB0 : Unknown_RL_219_sub_A763E0 {
		public SmartLocId name;
		public StringID world;
		public SmartLocId locationID;
		public StringID presence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<SmartLocId>(name, name: "name");
			world = s.SerializeObject<StringID>(world, name: "world");
			locationID = s.SerializeObject<SmartLocId>(locationID, name: "locationID");
			presence = s.SerializeObject<StringID>(presence, name: "presence");
		}
		public override uint? ClassCRC => 0x8E4C8FC7;
	}
}

