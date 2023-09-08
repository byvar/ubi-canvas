namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PickupManager_Template : TemplateObj {
		public Path scoreLumPath;
		public Path heartRainPath;
		public Path heartNfcPath;
		public float heartRainCooldown;
		public Path DRCItemHeartPath;
		public float DRCItemHeartWaitDurationMin;
		public float DRCItemHeartWaitDurationMax;
		public uint DRCItemHeartMinDeathCount;
		public uint DRCItemHeartMaxDeathCount;
		public uint DRCItemHeartMaxByCheckpoint;
		public Path prisonerCounterPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				prisonerCounterPath = s.SerializeObject<Path>(prisonerCounterPath, name: "prisonerCounterPath");
				scoreLumPath = s.SerializeObject<Path>(scoreLumPath, name: "scoreLumPath");
				heartRainPath = s.SerializeObject<Path>(heartRainPath, name: "heartRainPath");
				heartNfcPath = s.SerializeObject<Path>(heartNfcPath, name: "heartNfcPath");
				heartRainCooldown = s.Serialize<float>(heartRainCooldown, name: "heartRainCooldown");
				DRCItemHeartPath = s.SerializeObject<Path>(DRCItemHeartPath, name: "DRCItemHeartPath");
				DRCItemHeartWaitDurationMin = s.Serialize<float>(DRCItemHeartWaitDurationMin, name: "DRCItemHeartWaitDurationMin");
				DRCItemHeartWaitDurationMax = s.Serialize<float>(DRCItemHeartWaitDurationMax, name: "DRCItemHeartWaitDurationMax");
				DRCItemHeartMinDeathCount = s.Serialize<uint>(DRCItemHeartMinDeathCount, name: "DRCItemHeartMinDeathCount");
				DRCItemHeartMaxDeathCount = s.Serialize<uint>(DRCItemHeartMaxDeathCount, name: "DRCItemHeartMaxDeathCount");
				DRCItemHeartMaxByCheckpoint = s.Serialize<uint>(DRCItemHeartMaxByCheckpoint, name: "DRCItemHeartMaxByCheckpoint");
			} else {
				scoreLumPath = s.SerializeObject<Path>(scoreLumPath, name: "scoreLumPath");
				heartRainPath = s.SerializeObject<Path>(heartRainPath, name: "heartRainPath");
				heartNfcPath = s.SerializeObject<Path>(heartNfcPath, name: "heartNfcPath");
				heartRainCooldown = s.Serialize<float>(heartRainCooldown, name: "heartRainCooldown");
				DRCItemHeartPath = s.SerializeObject<Path>(DRCItemHeartPath, name: "DRCItemHeartPath");
				DRCItemHeartWaitDurationMin = s.Serialize<float>(DRCItemHeartWaitDurationMin, name: "DRCItemHeartWaitDurationMin");
				DRCItemHeartWaitDurationMax = s.Serialize<float>(DRCItemHeartWaitDurationMax, name: "DRCItemHeartWaitDurationMax");
				DRCItemHeartMinDeathCount = s.Serialize<uint>(DRCItemHeartMinDeathCount, name: "DRCItemHeartMinDeathCount");
				DRCItemHeartMaxDeathCount = s.Serialize<uint>(DRCItemHeartMaxDeathCount, name: "DRCItemHeartMaxDeathCount");
				DRCItemHeartMaxByCheckpoint = s.Serialize<uint>(DRCItemHeartMaxByCheckpoint, name: "DRCItemHeartMaxByCheckpoint");
			}
		}
		public override uint? ClassCRC => 0xD2C166E6;
	}
}

