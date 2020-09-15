using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventGoToWorldMap : Event {
		public int saveGameState;
		public int markCurrentLevelAsCompleted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			saveGameState = s.Serialize<int>(saveGameState, name: "saveGameState");
			markCurrentLevelAsCompleted = s.Serialize<int>(markCurrentLevelAsCompleted, name: "markCurrentLevelAsCompleted");
		}
		public override uint? ClassCRC => 0xC6C5376B;
	}
}

