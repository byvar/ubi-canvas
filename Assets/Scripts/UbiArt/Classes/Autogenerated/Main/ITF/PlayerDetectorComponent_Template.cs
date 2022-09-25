using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayerDetectorComponent_Template : ShapeDetectorComponent_Template {
		public bool allowDeadActors;
		public bool firstPlayerOnly;
		public uint allPlayerInMode;
		public float maxDetectionRadius;
		public bool allowTouchScreenPlayer;
		public bool ignoreZ;
		public bool drcPlayerOnly;
		public bool detectPivotOnly;
		public int playerId;
		public int playerToDetect;
		public bool allowAIControlledPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				playerId = s.Serialize<int>(playerId, name: "playerId");
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
				firstPlayerOnly = s.Serialize<bool>(firstPlayerOnly, name: "firstPlayerOnly");
				allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
				maxDetectionRadius = s.Serialize<float>(maxDetectionRadius, name: "maxDetectionRadius");
			} else if (s.Settings.game == Settings.Game.RL) {
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
				firstPlayerOnly = s.Serialize<bool>(firstPlayerOnly, name: "firstPlayerOnly");
				allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
				maxDetectionRadius = s.Serialize<float>(maxDetectionRadius, name: "maxDetectionRadius");
				allowTouchScreenPlayer = s.Serialize<bool>(allowTouchScreenPlayer, name: "allowTouchScreenPlayer");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				drcPlayerOnly = s.Serialize<bool>(drcPlayerOnly, name: "drcPlayerOnly");
			} else if (s.Settings.game == Settings.Game.COL) {
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
				playerToDetect = s.Serialize<int>(playerToDetect, name: "playerToDetect");
				allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
				maxDetectionRadius = s.Serialize<float>(maxDetectionRadius, name: "maxDetectionRadius");
				allowTouchScreenPlayer = s.Serialize<bool>(allowTouchScreenPlayer, name: "allowTouchScreenPlayer");
				allowAIControlledPlayer = s.Serialize<bool>(allowAIControlledPlayer, name: "allowAIControlledPlayer");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				drcPlayerOnly = s.Serialize<bool>(drcPlayerOnly, name: "drcPlayerOnly");
			} else {
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
				firstPlayerOnly = s.Serialize<bool>(firstPlayerOnly, name: "firstPlayerOnly");
				allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
				maxDetectionRadius = s.Serialize<float>(maxDetectionRadius, name: "maxDetectionRadius");
				allowTouchScreenPlayer = s.Serialize<bool>(allowTouchScreenPlayer, name: "allowTouchScreenPlayer");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				drcPlayerOnly = s.Serialize<bool>(drcPlayerOnly, name: "drcPlayerOnly");
				detectPivotOnly = s.Serialize<bool>(detectPivotOnly, name: "detectPivotOnly");
			}
		}
		public override uint? ClassCRC => 0x3A92D482;
	}
}

