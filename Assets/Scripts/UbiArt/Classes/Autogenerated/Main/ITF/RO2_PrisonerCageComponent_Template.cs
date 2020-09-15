using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PrisonerCageComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"                )] public StringID animIdle;
		[Serialize("animExplode"             )] public StringID animExplode;
		[Serialize("tapSoundFXName"          )] public StringID tapSoundFXName;
		[Serialize("grabSoundFXName"         )] public StringID grabSoundFXName;
		[Serialize("landFX"                  )] public StringID landFX;
		[Serialize("speedMultiplier"         )] public float speedMultiplier;
		[Serialize("forceSinus"              )] public Vec2d forceSinus;
		[Serialize("freqSinus"               )] public float freqSinus;
		[Serialize("isSpiky"                 )] public bool isSpiky;
		[Serialize("isGrabable"              )] public bool isGrabable;
		[Serialize("snapBones"               )] public CList<StringID> snapBones;
		[Serialize("slingShotDetectionRadius")] public float slingShotDetectionRadius;
		[Serialize("enablePhysic"            )] public bool enablePhysic;
		[Serialize("useAutoRaymanZone"       )] public bool useAutoRaymanZone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animExplode));
			SerializeField(s, nameof(tapSoundFXName));
			SerializeField(s, nameof(grabSoundFXName));
			SerializeField(s, nameof(landFX));
			SerializeField(s, nameof(speedMultiplier));
			SerializeField(s, nameof(forceSinus));
			SerializeField(s, nameof(freqSinus));
			SerializeField(s, nameof(isSpiky));
			SerializeField(s, nameof(isGrabable));
			SerializeField(s, nameof(snapBones));
			SerializeField(s, nameof(slingShotDetectionRadius));
			SerializeField(s, nameof(enablePhysic));
			SerializeField(s, nameof(useAutoRaymanZone));
		}
		public override uint? ClassCRC => 0x7698E7B6;
	}
}

