using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PersistentGameData_Universe : CSerializable {
		[Serialize("Levels"               )] public CMap<StringID, Generic<PersistentGameData_Level>> Levels;
		[Serialize("Rewards"              )] public GameStatsManager.SaveSession Rewards;
		[Serialize("CArray<ObjectPath>__2")] public CArray<ObjectPath> CArray_ObjectPath__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(Levels));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Levels));
				SerializeField(s, nameof(Rewards));
				SerializeField(s, nameof(CArray_ObjectPath__2));
			} else {
				SerializeField(s, nameof(Levels));
				SerializeField(s, nameof(Rewards));
			}
		}
		public override uint? ClassCRC => 0x8864664E;
	}
}

