using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_174_sub_75FAE0 : Unknown_RL_219_sub_A763E0 {
		public StringID type;
		public int value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.SerializeObject<StringID>(type, name: "type");
			value = s.Serialize<int>(value, name: "value");
		}
		public override uint? ClassCRC => 0x047CADF9;
	}
}

