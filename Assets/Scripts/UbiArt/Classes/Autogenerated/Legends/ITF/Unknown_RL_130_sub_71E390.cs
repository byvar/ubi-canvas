using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_130_sub_71E390 : CSerializable {
		[Serialize("m_randomCount")] public Placeholder m_randomCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(m_randomCount));
		}
		public override uint? ClassCRC => 0x753F1CC8;
	}
}

