using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PersistentGameData_Universe : CSerializable {
		[Serialize("Levels"             )] public CMapGeneric<StringID, PersistentGameData_Level> Levels;
		[Serialize("Rewards"            )] public GameStatsManager.SaveSession Rewards;
		[Serialize("sequenceAlreadySeen")] public CArray<ObjectPath> sequenceAlreadySeen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(Levels));
			} else if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(Levels));
				SerializeField(s, nameof(Rewards));
				SerializeField(s, nameof(sequenceAlreadySeen));
			} else {
				SerializeField(s, nameof(Levels));
				SerializeField(s, nameof(Rewards));
			}
		}
		public override uint? ClassCRC => 0x8864664E;
	}
}

