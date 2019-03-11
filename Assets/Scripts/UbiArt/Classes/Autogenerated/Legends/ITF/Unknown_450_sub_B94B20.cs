using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_450_sub_B94B20 : CSerializable {
		[Serialize("cameraRelative"           )] public bool cameraRelative;
		[Serialize("triggerable"              )] public bool triggerable;
		[Serialize("dynamicFlip"              )] public bool dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public bool dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public bool useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public bool takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		[Serialize("canBeCrushed"             )] public bool canBeCrushed;
		[Serialize("disableOnBecomeInactive"  )] public bool disableOnBecomeInactive;
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

