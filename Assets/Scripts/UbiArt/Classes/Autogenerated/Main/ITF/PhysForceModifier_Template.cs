using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysForceModifier_Template : CSerializable {
		[Serialize("isRadial"           )] public bool isRadial;
		[Serialize("force"              )] public Vector2 force;
		[Serialize("forceVariationRange")] public float forceVariationRange;
		[Serialize("gradientPercentage" )] public float gradientPercentage;
		[Serialize("isInverted"         )] public bool isInverted;
		[Serialize("centerForce"        )] public float centerForce;
		[Serialize("centerForceMaxSpeed")] public float centerForceMaxSpeed;
		[Serialize("speedMultiplierX"   )] public float speedMultiplierX;
		[Serialize("speedMultiplierY"   )] public float speedMultiplierY;
		[Serialize("posOffset"          )] public Vector2 posOffset;
		[Serialize("angleOffset"        )] public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(isRadial));
				SerializeField(s, nameof(force));
				SerializeField(s, nameof(gradientPercentage));
				SerializeField(s, nameof(isInverted));
				SerializeField(s, nameof(centerForce));
				SerializeField(s, nameof(centerForceMaxSpeed));
				SerializeField(s, nameof(speedMultiplierX));
				SerializeField(s, nameof(speedMultiplierY));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(angleOffset));
			} else {
				SerializeField(s, nameof(isRadial));
				SerializeField(s, nameof(force));
				SerializeField(s, nameof(forceVariationRange));
				SerializeField(s, nameof(gradientPercentage));
				SerializeField(s, nameof(isInverted));
				SerializeField(s, nameof(centerForce));
				SerializeField(s, nameof(centerForceMaxSpeed));
				SerializeField(s, nameof(speedMultiplierX));
				SerializeField(s, nameof(speedMultiplierY));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(angleOffset));
			}
		}
		public override uint? ClassCRC => 0x5E8F2A1D;
	}
}

