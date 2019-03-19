using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_274_sub_8D3F50 : CSerializable {
		[Serialize("CallProtocolMethodOperation: ")] public Placeholder CallProtocolMethodOperation_ ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CallProtocolMethodOperation_ ));
		}
		public override uint? ClassCRC => 0x00000013;
	}
}

