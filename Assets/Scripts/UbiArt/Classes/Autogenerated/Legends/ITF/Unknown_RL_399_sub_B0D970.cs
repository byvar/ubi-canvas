using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_399_sub_B0D970 : DetectorComponent_Template {
		[Serialize("playerId"              )] public int playerId;
		[Serialize("allowDeadActors"       )] public int allowDeadActors;
		[Serialize("firstPlayerOnly"       )] public int firstPlayerOnly;
		[Serialize("allPlayerInMode"       )] public uint allPlayerInMode;
		[Serialize("allowTouchScreenPlayer")] public int allowTouchScreenPlayer;
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

