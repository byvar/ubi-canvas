using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_174_sub_75FAE0 : Unknown_RL_219_sub_A763E0 {
		[Serialize("type" )] public StringID type;
		[Serialize("value")] public int value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(value));
		}
		public override uint? ClassCRC => 0x047CADF9;
	}
}

