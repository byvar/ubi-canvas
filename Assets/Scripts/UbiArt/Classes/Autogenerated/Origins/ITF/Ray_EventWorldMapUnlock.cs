using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventWorldMapUnlock : Event {
		[Serialize("unlocks"               )] public Placeholder unlocks;
		[Serialize("changeCurrentLevelName")] public bool changeCurrentLevelName;
		[Serialize("levelName"             )] public StringID levelName;
		[Serialize("saveGameState"         )] public bool saveGameState;
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

