using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BigMamaComponent_Template : ActorComponent_Template {
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
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(eyesHitPoints));
				SerializeField(s, nameof(eyesPerHit));
				SerializeField(s, nameof(eyeSpawn));
				SerializeField(s, nameof(eyeSpawnBone));
				SerializeField(s, nameof(allowedFaction));
				SerializeField(s, nameof(ejectHeight1));
				SerializeField(s, nameof(ejectHeight2));
				SerializeField(s, nameof(ejectSpeed));
				SerializeField(s, nameof(musics));
			} else {
				SerializeField(s, nameof(eyesHitPoints));
				SerializeField(s, nameof(eyesPerHit));
				SerializeField(s, nameof(eyeSpawn));
				SerializeField(s, nameof(eyeSpawnBone));
				SerializeField(s, nameof(allowedFaction));
				SerializeField(s, nameof(ejectHeight1));
				SerializeField(s, nameof(ejectHeight2));
				SerializeField(s, nameof(ejectSpeed));
			}
		}
		public override uint? ClassCRC => 0xF35B89B5;
	}
}

