using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteractiveComponent_Template : CSerializable {
		[Serialize("interactButtonYOffset"          )] public float interactButtonYOffset;
		[Serialize("interactButtonZOffsetFromAurora")] public float interactButtonZOffsetFromAurora;
		[Serialize("authorizedPCStates"             )] public Placeholder authorizedPCStates;
		[Serialize("onInteractFeedbackID"           )] public StringID onInteractFeedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(interactButtonYOffset));
			SerializeField(s, nameof(interactButtonZOffsetFromAurora));
			SerializeField(s, nameof(authorizedPCStates));
			SerializeField(s, nameof(onInteractFeedbackID));
		}
		public override uint? ClassCRC => 0xB8752E22;
	}
}

