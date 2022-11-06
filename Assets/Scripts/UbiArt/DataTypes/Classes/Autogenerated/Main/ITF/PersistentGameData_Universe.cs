using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class PersistentGameData_Universe : CSerializable {
		public CMapGeneric<StringID, PersistentGameData_Level> Levels;
		public GameStatsManager.SaveSession Rewards;
		public CArrayO<ObjectPath> sequenceAlreadySeen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				Levels = s.SerializeObject<CMapGeneric<StringID, PersistentGameData_Level>>(Levels, name: "Levels");
			} else if (s.Settings.game == Settings.Game.VH || s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				Levels = s.SerializeObject<CMapGeneric<StringID, PersistentGameData_Level>>(Levels, name: "Levels");
				Rewards = s.SerializeObject<GameStatsManager.SaveSession>(Rewards, name: "Rewards");
				sequenceAlreadySeen = s.SerializeObject<CArrayO<ObjectPath>>(sequenceAlreadySeen, name: "sequenceAlreadySeen");
			} else {
				Levels = s.SerializeObject<CMapGeneric<StringID, PersistentGameData_Level>>(Levels, name: "Levels");
				Rewards = s.SerializeObject<GameStatsManager.SaveSession>(Rewards, name: "Rewards");
			}
		}
		public override uint? ClassCRC => 0x8864664E;
	}
}
