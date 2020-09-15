using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_180_sub_760CB0 : CSerializable {
		public StringID inputAnimLeft;
		public StringID inputAnimRight;
		public StringID inputStateLeft;
		public StringID inputStateRight;
		public float animTimeOpen;
		public float animTimeClose;
		public int allowCutAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputAnimLeft = s.SerializeObject<StringID>(inputAnimLeft, name: "inputAnimLeft");
			inputAnimRight = s.SerializeObject<StringID>(inputAnimRight, name: "inputAnimRight");
			inputStateLeft = s.SerializeObject<StringID>(inputStateLeft, name: "inputStateLeft");
			inputStateRight = s.SerializeObject<StringID>(inputStateRight, name: "inputStateRight");
			animTimeOpen = s.Serialize<float>(animTimeOpen, name: "animTimeOpen");
			animTimeClose = s.Serialize<float>(animTimeClose, name: "animTimeClose");
			allowCutAnim = s.Serialize<int>(allowCutAnim, name: "allowCutAnim");
		}
		public override uint? ClassCRC => 0xDE34F7E8;
	}
}

