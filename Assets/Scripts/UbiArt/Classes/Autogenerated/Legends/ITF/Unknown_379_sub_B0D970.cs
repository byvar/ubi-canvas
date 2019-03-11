using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_379_sub_B0D970 : CSerializable {
		[Serialize("playerId"              )] public bool playerId;
		[Serialize("allowDeadActors"       )] public bool allowDeadActors;
		[Serialize("firstPlayerOnly"       )] public bool firstPlayerOnly;
		[Serialize("allPlayerInMode"       )] public uint allPlayerInMode;
		[Serialize("allowTouchScreenPlayer")] public bool allowTouchScreenPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerId));
			SerializeField(s, nameof(allowDeadActors));
			SerializeField(s, nameof(firstPlayerOnly));
			SerializeField(s, nameof(allPlayerInMode));
			SerializeField(s, nameof(allowTouchScreenPlayer));
		}
		public override uint? ClassCRC => 0x193EE9ED;
	}
}

