using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CarnivorousLianaComponent_Template : ActorComponent_Template {
		[Serialize("defaultFxName"             )] public StringID defaultFxName;
		[Serialize("minLength"                 )] public float minLength;
		[Serialize("maxLength"                 )] public float maxLength;
		[Serialize("extendSpeed"               )] public float extendSpeed;
		[Serialize("colapseSpeed"              )] public float colapseSpeed;
		[Serialize("angularSpeedMax"           )] public float angularSpeedMax;
		[Serialize("angularRotationForSpeedMax")] public float angularRotationForSpeedMax;
		[Serialize("shakeDelayMin"             )] public float shakeDelayMin;
		[Serialize("shakeDelayMax"             )] public float shakeDelayMax;
		[Serialize("attackFinalDistanceCursor" )] public float attackFinalDistanceCursor;
		[Serialize("noUserExtendDelay"         )] public float noUserExtendDelay;
		[Serialize("timeToReachColapseSpeed"   )] public float timeToReachColapseSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultFxName));
			SerializeField(s, nameof(minLength));
			SerializeField(s, nameof(maxLength));
			SerializeField(s, nameof(extendSpeed));
			SerializeField(s, nameof(colapseSpeed));
			SerializeField(s, nameof(angularSpeedMax));
			SerializeField(s, nameof(angularRotationForSpeedMax));
			SerializeField(s, nameof(shakeDelayMin));
			SerializeField(s, nameof(shakeDelayMax));
			SerializeField(s, nameof(attackFinalDistanceCursor));
			SerializeField(s, nameof(noUserExtendDelay));
			SerializeField(s, nameof(timeToReachColapseSpeed));
		}
		public override uint? ClassCRC => 0xD0923462;
	}
}

