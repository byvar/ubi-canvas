using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_185_sub_767DB0 : Unknown_RL_219_sub_A763E0 {
		[Serialize("name"      )] public SmartLocId name;
		[Serialize("world"     )] public StringID world;
		[Serialize("locationID")] public SmartLocId locationID;
		[Serialize("presence"  )] public StringID presence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(world));
			SerializeField(s, nameof(locationID));
			SerializeField(s, nameof(presence));
		}
		public override uint? ClassCRC => 0x8E4C8FC7;
	}
}

