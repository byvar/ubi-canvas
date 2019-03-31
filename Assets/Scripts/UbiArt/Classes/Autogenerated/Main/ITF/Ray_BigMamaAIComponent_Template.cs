using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BigMamaAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("eyesHitPoints" )] public uint eyesHitPoints;
		[Serialize("eyesPerHit"    )] public uint eyesPerHit;
		[Serialize("eyeSpawn"      )] public Path eyeSpawn;
		[Serialize("eyeSpawnBone"  )] public StringID eyeSpawnBone;
		[Serialize("allowedFaction")] public uint allowedFaction;
		[Serialize("ejectHeight1"  )] public float ejectHeight1;
		[Serialize("ejectHeight2"  )] public float ejectHeight2;
		[Serialize("ejectSpeed"    )] public float ejectSpeed;
		[Serialize("musics"        )] public CList<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eyesHitPoints));
			SerializeField(s, nameof(eyesPerHit));
			SerializeField(s, nameof(eyeSpawn));
			SerializeField(s, nameof(eyeSpawnBone));
			SerializeField(s, nameof(allowedFaction));
			SerializeField(s, nameof(ejectHeight1));
			SerializeField(s, nameof(ejectHeight2));
			SerializeField(s, nameof(ejectSpeed));
			SerializeField(s, nameof(musics));
		}
		public override uint? ClassCRC => 0xAB055306;
	}
}

