namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleSetupsConfig : CSerializable {
		public float winTargetTime;
		public PathRef battleSetupMapPath;
		public CListO<COL_BattleSetupsConfig.BattleSetup> battleSetups;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			winTargetTime = s.Serialize<float>(winTargetTime, name: "winTargetTime");
			battleSetupMapPath = s.SerializeObject<PathRef>(battleSetupMapPath, name: "battleSetupMapPath");
			battleSetups = s.SerializeObject<CListO<COL_BattleSetupsConfig.BattleSetup>>(battleSetups, name: "battleSetups");
		}

		public class BattleSetup : CSerializable {
			public uint battleWeight;
			public CListO<COL_BattleSetupsConfig.BattleEnemy> enemies;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				battleWeight = s.Serialize<uint>(battleWeight, name: "battleWeight");
				enemies = s.SerializeObject<CListO<COL_BattleSetupsConfig.BattleEnemy>>(enemies, name: "enemies");
			}
		}
		public class BattleEnemy : CSerializable {
			public StringID characterID;
			public int spawnIndex;
			public bool onlyInHardMode;
			protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
				characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
				spawnIndex = s.Serialize<int>(spawnIndex, name: "spawnIndex");
				onlyInHardMode = s.Serialize<bool>(onlyInHardMode, name: "onlyInHardMode", options: CSerializerObject.Options.BoolAsByte);
			}
		}
	}
}

