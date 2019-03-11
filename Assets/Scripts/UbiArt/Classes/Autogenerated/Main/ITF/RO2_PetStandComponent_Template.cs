using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetStandComponent_Template : ActorComponent_Template {
		[Serialize("bones"              )] public CArray<StringID> bones;
		[Serialize("arrivalAnimDuration")] public float arrivalAnimDuration;
		[Serialize("sequenceDuration"   )] public float sequenceDuration;
		[Serialize("sequenceSpawnDelta" )] public float sequenceSpawnDelta;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bones));
			SerializeField(s, nameof(arrivalAnimDuration));
			SerializeField(s, nameof(sequenceDuration));
			SerializeField(s, nameof(sequenceSpawnDelta));
		}
		public override uint? ClassCRC => 0xC299E84F;
	}
}

