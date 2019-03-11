using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_452_sub_B956C0 : CSerializable {
		[Serialize("anim"                     )] public StringID anim;
		[Serialize("dynamicFlip"              )] public bool dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public bool dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public bool useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public bool takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(dynamicFlip));
			SerializeField(s, nameof(dynamicFlipStartLeft));
			SerializeField(s, nameof(useFixedAngle));
			SerializeField(s, nameof(fixedAngle));
			SerializeField(s, nameof(takeMoveOrientation));
			SerializeField(s, nameof(takeMoveOrientationOffset));
		}
		public override uint? ClassCRC => 0xE4F3B318;
	}
}

