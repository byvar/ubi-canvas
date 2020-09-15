using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterSpawnerComponent : TimedSpawnerComponent {
		public StringID tweenId;
		public StringID spawnActorId;
		public Vec3d beforeCamRelativeInitialPos;
		public bool useTutoOnFirstSpawnee;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeFieldAsChoiceList(s, nameof(tweenId), "invalid");
				SerializeFieldAsChoiceList(s, nameof(spawnActorId), "invalid");
			} else {
				tweenId = s.SerializeObject<StringID>(tweenId, name: "tweenId");
				spawnActorId = s.SerializeObject<StringID>(spawnActorId, name: "spawnActorId");
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				beforeCamRelativeInitialPos = s.SerializeObject<Vec3d>(beforeCamRelativeInitialPos, name: "beforeCamRelativeInitialPos");
			}
			useTutoOnFirstSpawnee = s.Serialize<bool>(useTutoOnFirstSpawnee, name: "useTutoOnFirstSpawnee", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xF27AB10B;
	}
}

