using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetStandComponent_Template : ActorComponent_Template {
		[Serialize("bones"              )] public CArray<StringID> bones;
		[Serialize("arrivalAnimDuration")] public float arrivalAnimDuration;
		[Serialize("sequenceDuration"   )] public float sequenceDuration;
		[Serialize("sequenceSpawnDelta" )] public float sequenceSpawnDelta;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bones));
				SerializeField(s, nameof(arrivalAnimDuration));
				SerializeField(s, nameof(sequenceDuration));
				SerializeField(s, nameof(sequenceSpawnDelta));
			} else {
				SerializeField(s, nameof(bones));
				SerializeField(s, nameof(bones));
				SerializeField(s, nameof(arrivalAnimDuration));
				SerializeField(s, nameof(sequenceDuration));
				SerializeField(s, nameof(sequenceSpawnDelta));
			}
		}
		public override uint? ClassCRC => 0xC299E84F;
	}
}

