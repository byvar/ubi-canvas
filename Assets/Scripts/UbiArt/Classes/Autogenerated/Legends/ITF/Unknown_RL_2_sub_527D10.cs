using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_2_sub_527D10 : CSerializable {
		[Serialize("input")] public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
		}
		public override uint? ClassCRC => 0x42FD73DC;
	}
}

