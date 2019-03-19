using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_245_sub_B86E50 : CSerializable {
		[Serialize("tweenInstructionSetList")] public Placeholder tweenInstructionSetList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenInstructionSetList));
		}
		public override uint? ClassCRC => 0xB9AEB965;
	}
}

