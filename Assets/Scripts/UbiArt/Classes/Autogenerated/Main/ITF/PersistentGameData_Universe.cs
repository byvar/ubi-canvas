using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PersistentGameData_Universe : CSerializable {
		[Serialize("Levels"                         )] public CMap<StringID, PersistentGameData_Level> Levels;
		[Serialize("Rewards"                        )] public GameStatsManager.SaveSession Rewards;
		[Serialize("CArray<Generic<StringID>>__0"   )] public CArray<Generic<StringID>> CArray_Generic_StringID__0;
		[Serialize("GameStatsManager.SaveSession__1")] public GameStatsManager.SaveSession GameStatsManager_SaveSession__1;
		[Serialize("CArray<ObjectPath>__2"          )] public CArray<ObjectPath> CArray_ObjectPath__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_Generic_StringID__0));
				SerializeField(s, nameof(GameStatsManager_SaveSession__1));
				SerializeField(s, nameof(CArray_ObjectPath__2));
			} else {
				SerializeField(s, nameof(Levels));
				SerializeField(s, nameof(Rewards));
			}
		}
		public override uint? ClassCRC => 0x8864664E;
	}
}

