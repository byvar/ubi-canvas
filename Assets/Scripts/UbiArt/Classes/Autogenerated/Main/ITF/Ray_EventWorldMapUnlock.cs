using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventWorldMapUnlock : Event {
		[Serialize("unlocks"               )] public CList<StringID> unlocks;
		[Serialize("changeCurrentLevelName")] public int changeCurrentLevelName;
		[Serialize("levelName"             )] public StringID levelName;
		[Serialize("saveGameState"         )] public int saveGameState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unlocks));
			SerializeField(s, nameof(changeCurrentLevelName));
			SerializeField(s, nameof(levelName));
			SerializeField(s, nameof(saveGameState));
		}
		public override uint? ClassCRC => 0x732617DC;
	}
}

