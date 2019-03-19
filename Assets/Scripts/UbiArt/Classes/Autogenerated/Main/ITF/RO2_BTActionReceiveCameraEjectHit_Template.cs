using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionReceiveCameraEjectHit_Template : RO2_BTActionReceiveHit_Template {
		[Serialize("minStartSpeed"    )] public Vector3 minStartSpeed;
		[Serialize("maxStartSpeed"    )] public Vector3 maxStartSpeed;
		[Serialize("zMinSpeed"        )] public float zMinSpeed;
		[Serialize("zAcceleration"    )] public float zAcceleration;
		[Serialize("gravityMultiplier")] public float gravityMultiplier;
		[Serialize("ejectDuration"    )] public float ejectDuration;
		[Serialize("zForced"          )] public int zForced;
		[Serialize("rotationSpeed"    )] public float rotationSpeed;
		[Serialize("fixedEjectDir"    )] public Vector2 fixedEjectDir;
		[Serialize("fadeDuration"     )] public float fadeDuration;
		[Serialize("delayBeforeFade"  )] public float delayBeforeFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minStartSpeed));
			SerializeField(s, nameof(maxStartSpeed));
			SerializeField(s, nameof(zMinSpeed));
			SerializeField(s, nameof(zAcceleration));
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(ejectDuration));
			SerializeField(s, nameof(zForced));
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(fixedEjectDir));
			SerializeField(s, nameof(fadeDuration));
			SerializeField(s, nameof(delayBeforeFade));
		}
		public override uint? ClassCRC => 0xFFFEE8A4;
	}
}

