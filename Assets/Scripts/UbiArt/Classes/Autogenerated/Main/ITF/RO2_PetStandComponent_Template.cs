using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PetStandComponent_Template : ActorComponent_Template {
		public CArrayO<StringID> bones;
		public float arrivalAnimDuration;
		public float sequenceDuration;
		public float sequenceSpawnDelta;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				bones = s.SerializeObject<CArrayO<StringID>>(bones, name: "bones");
				arrivalAnimDuration = s.Serialize<float>(arrivalAnimDuration, name: "arrivalAnimDuration");
				sequenceDuration = s.Serialize<float>(sequenceDuration, name: "sequenceDuration");
				sequenceSpawnDelta = s.Serialize<float>(sequenceSpawnDelta, name: "sequenceSpawnDelta");
			} else {
				bones = s.SerializeObject<CArrayO<StringID>>(bones, name: "bones");
				bones = s.SerializeObject<CArrayO<StringID>>(bones, name: "bones");
				arrivalAnimDuration = s.Serialize<float>(arrivalAnimDuration, name: "arrivalAnimDuration");
				sequenceDuration = s.Serialize<float>(sequenceDuration, name: "sequenceDuration");
				sequenceSpawnDelta = s.Serialize<float>(sequenceSpawnDelta, name: "sequenceSpawnDelta");
			}
		}
		public override uint? ClassCRC => 0xC299E84F;
	}
}

