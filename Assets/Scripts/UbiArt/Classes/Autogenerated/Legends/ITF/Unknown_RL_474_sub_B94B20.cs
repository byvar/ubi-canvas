using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_474_sub_B94B20 : RO2_EnemyBTAIComponent_Template {
		[Serialize("cameraRelative"           )] public int cameraRelative;
		[Serialize("triggerable"              )] public int triggerable;
		[Serialize("dynamicFlip"              )] public int dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public int dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public int useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public int takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		[Serialize("canBeCrushed"             )] public int canBeCrushed;
		[Serialize("disableOnBecomeInactive"  )] public int disableOnBecomeInactive;
		[Serialize("visualScaleMultiplier"    )] public float visualScaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cameraRelative));
			SerializeField(s, nameof(triggerable));
			SerializeField(s, nameof(dynamicFlip));
			SerializeField(s, nameof(dynamicFlipStartLeft));
			SerializeField(s, nameof(useFixedAngle));
			SerializeField(s, nameof(fixedAngle));
			SerializeField(s, nameof(takeMoveOrientation));
			SerializeField(s, nameof(takeMoveOrientationOffset));
			SerializeField(s, nameof(canBeCrushed));
			SerializeField(s, nameof(disableOnBecomeInactive));
			SerializeField(s, nameof(visualScaleMultiplier));
		}
		public override uint? ClassCRC => 0x795ED68C;
	}
}

