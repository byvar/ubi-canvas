using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_33_sub_527D50 : CSerializable {
		[Serialize("input"    )] public Placeholder input;
		[Serialize("frequency")] public float frequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(frequency));
		}
		public override uint? ClassCRC => 0xE5DD8D51;
	}
}

