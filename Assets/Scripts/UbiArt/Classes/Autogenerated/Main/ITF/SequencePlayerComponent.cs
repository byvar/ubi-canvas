using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class SequencePlayerComponent : ActorComponent {
		public uint bankState;
		public bool allowPrefetch;
		public bool useCustomAABB;
		public EditableShape customAABB;
		public bool overrideActorAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				bankState = s.Serialize<uint>(bankState, name: "bankState");
			} else {
				bankState = s.Serialize<uint>(bankState, name: "bankState");
				allowPrefetch = s.Serialize<bool>(allowPrefetch, name: "allowPrefetch");
				useCustomAABB = s.Serialize<bool>(useCustomAABB, name: "useCustomAABB");
				customAABB = s.SerializeObject<EditableShape>(customAABB, name: "customAABB");
				overrideActorAABB = s.Serialize<bool>(overrideActorAABB, name: "overrideActorAABB");
			}
		}
		public override uint? ClassCRC => 0x35A4CFCF;
	}
}

