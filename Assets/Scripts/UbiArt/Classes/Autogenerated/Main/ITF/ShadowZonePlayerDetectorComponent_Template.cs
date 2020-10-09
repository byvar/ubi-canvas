using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ShadowZonePlayerDetectorComponent_Template : DetectorComponent_Template {
		public int playerId;
		public bool allowDeadActors;
		public bool firstPlayerOnly;
		public uint allPlayerInMode;
		public bool allowTouchScreenPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerId = s.Serialize<int>(playerId, name: "playerId");
			allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
			firstPlayerOnly = s.Serialize<bool>(firstPlayerOnly, name: "firstPlayerOnly");
			allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
			allowTouchScreenPlayer = s.Serialize<bool>(allowTouchScreenPlayer, name: "allowTouchScreenPlayer");
		}
		public override uint? ClassCRC => 0xE855E934;
	}
}

