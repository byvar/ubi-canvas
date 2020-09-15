using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetStandComponent_Template : ActorComponent_Template {
		public CArray<StringID> bones;
		public float arrivalAnimDuration;
		public float sequenceDuration;
		public float sequenceSpawnDelta;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				bones = s.SerializeObject<CArray<StringID>>(bones, name: "bones");
				arrivalAnimDuration = s.Serialize<float>(arrivalAnimDuration, name: "arrivalAnimDuration");
				sequenceDuration = s.Serialize<float>(sequenceDuration, name: "sequenceDuration");
				sequenceSpawnDelta = s.Serialize<float>(sequenceSpawnDelta, name: "sequenceSpawnDelta");
			} else {
				bones = s.SerializeObject<CArray<StringID>>(bones, name: "bones");
				bones = s.SerializeObject<CArray<StringID>>(bones, name: "bones");
				arrivalAnimDuration = s.Serialize<float>(arrivalAnimDuration, name: "arrivalAnimDuration");
				sequenceDuration = s.Serialize<float>(sequenceDuration, name: "sequenceDuration");
				sequenceSpawnDelta = s.Serialize<float>(sequenceSpawnDelta, name: "sequenceSpawnDelta");
			}
		}
		public override uint? ClassCRC => 0xC299E84F;
	}
}

