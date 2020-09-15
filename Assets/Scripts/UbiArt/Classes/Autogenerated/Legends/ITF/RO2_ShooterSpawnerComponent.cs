using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterSpawnerComponent : TimedSpawnerComponent {
		[Serialize("tweenId"                    )] public StringID tweenId;
		[Serialize("spawnActorId"               )] public StringID spawnActorId;
		[Serialize("beforeCamRelativeInitialPos")] public Vec3d beforeCamRelativeInitialPos;
		[Serialize("useTutoOnFirstSpawnee"      )] public bool useTutoOnFirstSpawnee;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeFieldAsChoiceList(s, nameof(tweenId), "invalid");
				SerializeFieldAsChoiceList(s, nameof(spawnActorId), "invalid");
			} else {
				SerializeField(s, nameof(tweenId));
				SerializeField(s, nameof(spawnActorId));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
			SerializeField(s, nameof(useTutoOnFirstSpawnee), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xF27AB10B;
	}
}

