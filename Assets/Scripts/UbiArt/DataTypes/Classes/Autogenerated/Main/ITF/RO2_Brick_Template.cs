namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_Brick_Template : CSerializable {
		public StringID name;
		public string name2;
		public Path path;
		public uint spawnCooldown;
		public uint difficulty;
		public eMM murphymode;
		public ArchiveMemory archive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				path = s.SerializeObject<Path>(path, name: "path");
				spawnCooldown = s.Serialize<uint>(spawnCooldown, name: "spawnCooldown");
				difficulty = s.Serialize<uint>(difficulty, name: "difficulty");
				murphymode = s.Serialize<eMM>(murphymode, name: "murphymode");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					archive = s.SerializeObject<ArchiveMemory>(archive, name: "archive");
				}
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				name2 = s.Serialize<string>(name2, name: "name");
				path = s.SerializeObject<Path>(path, name: "path");
				spawnCooldown = s.Serialize<uint>(spawnCooldown, name: "spawnCooldown");
				difficulty = s.Serialize<uint>(difficulty, name: "difficulty");
				murphymode = s.Serialize<eMM>(murphymode, name: "murphymode");
			}
		}
		public enum eMM {
			[Serialize("eMM_Both"        )] Both = 0,
			[Serialize("eMM_TouchOnly"   )] TouchOnly = 1,
			[Serialize("eMM_NonTouchOnly")] NonTouchOnly = 2,
		}
		public override uint? ClassCRC => 0xDDE750FB;
	}
}

