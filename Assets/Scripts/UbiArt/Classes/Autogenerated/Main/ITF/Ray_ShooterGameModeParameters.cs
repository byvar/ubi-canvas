using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterGameModeParameters : CSerializable {
		[Serialize("playersDataList")] public CArray<PlayerData> playersDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playersDataList));
		}
		public override uint? ClassCRC => 0x63E0A1F7;

		[Games(GameFlags.RO)]
		public partial class PlayerData : CSerializable {
			[Serialize("playerID"  )] public StringID playerID;
			[Serialize("luaFile"   )] public Path luaFile;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(playerID));
				SerializeField(s, nameof(luaFile));
			}
		}
	}
}

