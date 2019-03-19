using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_476_sub_B956C0 : CSerializable {
		[Serialize("anim"                     )] public StringID anim;
		[Serialize("dynamicFlip"              )] public int dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public int dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public int useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public int takeMoveOrientation;
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

