namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BigMamaComponent_Template : ActorComponent_Template {
		public uint eyesHitPoints;
		public uint eyesPerHit;
		public Path eyeSpawn;
		public StringID eyeSpawnBone;
		public uint allowedFaction;
		public float ejectHeight1;
		public float ejectHeight2;
		public float ejectSpeed;
		public CListO<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				eyesHitPoints = s.Serialize<uint>(eyesHitPoints, name: "eyesHitPoints");
				eyesPerHit = s.Serialize<uint>(eyesPerHit, name: "eyesPerHit");
				eyeSpawn = s.SerializeObject<Path>(eyeSpawn, name: "eyeSpawn");
				eyeSpawnBone = s.SerializeObject<StringID>(eyeSpawnBone, name: "eyeSpawnBone");
				allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
				ejectHeight1 = s.Serialize<float>(ejectHeight1, name: "ejectHeight1");
				ejectHeight2 = s.Serialize<float>(ejectHeight2, name: "ejectHeight2");
				ejectSpeed = s.Serialize<float>(ejectSpeed, name: "ejectSpeed");
				musics = s.SerializeObject<CListO<EventPlayMusic>>(musics, name: "musics");
			} else {
				eyesHitPoints = s.Serialize<uint>(eyesHitPoints, name: "eyesHitPoints");
				eyesPerHit = s.Serialize<uint>(eyesPerHit, name: "eyesPerHit");
				eyeSpawn = s.SerializeObject<Path>(eyeSpawn, name: "eyeSpawn");
				eyeSpawnBone = s.SerializeObject<StringID>(eyeSpawnBone, name: "eyeSpawnBone");
				allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
				ejectHeight1 = s.Serialize<float>(ejectHeight1, name: "ejectHeight1");
				ejectHeight2 = s.Serialize<float>(ejectHeight2, name: "ejectHeight2");
				ejectSpeed = s.Serialize<float>(ejectSpeed, name: "ejectSpeed");
			}
		}
		public override uint? ClassCRC => 0xF35B89B5;
	}
}

