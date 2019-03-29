using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_8_sub_389600 : SoundCommand {
		[Serialize("name"     )] public StringID name;
		[Serialize("activate" )] public int activate;
		[Serialize("busParams")] public BusMix busParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(activate));
			SerializeField(s, nameof(busParams));
		}
		public override uint? ClassCRC => 0xA61DB3DB;
	}
}

