using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_233_sub_B86E50 : CSerializable {
		[Serialize("tweenInstructionSetList")] public Placeholder tweenInstructionSetList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenInstructionSetList));
		}
		public override uint? ClassCRC => 0xB9AEB965;
	}
}

