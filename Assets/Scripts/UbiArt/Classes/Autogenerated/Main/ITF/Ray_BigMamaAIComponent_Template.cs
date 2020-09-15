using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BigMamaAIComponent_Template : Ray_AIComponent_Template {
		public uint eyesHitPoints;
		public uint eyesPerHit;
		public Path eyeSpawn;
		public StringID eyeSpawnBone;
		public uint allowedFaction;
		public float ejectHeight1;
		public float ejectHeight2;
		public float ejectSpeed;
		public CList<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eyesHitPoints = s.Serialize<uint>(eyesHitPoints, name: "eyesHitPoints");
			eyesPerHit = s.Serialize<uint>(eyesPerHit, name: "eyesPerHit");
			eyeSpawn = s.SerializeObject<Path>(eyeSpawn, name: "eyeSpawn");
			eyeSpawnBone = s.SerializeObject<StringID>(eyeSpawnBone, name: "eyeSpawnBone");
			allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
			ejectHeight1 = s.Serialize<float>(ejectHeight1, name: "ejectHeight1");
			ejectHeight2 = s.Serialize<float>(ejectHeight2, name: "ejectHeight2");
			ejectSpeed = s.Serialize<float>(ejectSpeed, name: "ejectSpeed");
			musics = s.SerializeObject<CList<EventPlayMusic>>(musics, name: "musics");
		}
		public override uint? ClassCRC => 0xAB055306;
	}
}

