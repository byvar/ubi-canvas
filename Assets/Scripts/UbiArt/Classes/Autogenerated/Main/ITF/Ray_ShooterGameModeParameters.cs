using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterGameModeParameters : CSerializable {
		public CArrayO<PlayerData> playersDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playersDataList = s.SerializeObject<CArrayO<PlayerData>>(playersDataList, name: "playersDataList");
		}
		public override uint? ClassCRC => 0x63E0A1F7;

		[Games(GameFlags.RO)]
		public partial class PlayerData : CSerializable {
			public StringID playerID;
			public Path luaFile;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				playerID = s.SerializeObject<StringID>(playerID, name: "playerID");
				luaFile = s.SerializeObject<Path>(luaFile, name: "luaFile");
			}
		}
	}
}

