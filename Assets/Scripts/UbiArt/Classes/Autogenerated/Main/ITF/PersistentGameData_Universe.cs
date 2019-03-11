using UnityEngine;

namespace UbiArt.ITF {
	public partial class PersistentGameData_Universe : CSerializable {
		[Serialize("Levels" )] public CMap<StringID, PersistentGameData_Level> Levels;
		[Serialize("Rewards")] public GameStatsManager.SaveSession Rewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Levels));
			SerializeField(s, nameof(Rewards));
		}
		public override uint? ClassCRC => 0x8864664E;
	}
}

