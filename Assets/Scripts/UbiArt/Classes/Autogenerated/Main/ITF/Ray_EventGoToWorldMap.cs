using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventGoToWorldMap : Event {
		[Serialize("saveGameState"              )] public int saveGameState;
		[Serialize("markCurrentLevelAsCompleted")] public int markCurrentLevelAsCompleted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(saveGameState));
			SerializeField(s, nameof(markCurrentLevelAsCompleted));
		}
		public override uint? ClassCRC => 0xC6C5376B;
	}
}

