using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventGoToWorldMap : CSerializable {
		[Serialize("saveGameState"              )] public bool saveGameState;
		[Serialize("markCurrentLevelAsCompleted")] public bool markCurrentLevelAsCompleted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(saveGameState));
			SerializeField(s, nameof(markCurrentLevelAsCompleted));
		}
		public override uint? ClassCRC => 0xC6C5376B;
	}
}

