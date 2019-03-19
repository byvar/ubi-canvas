using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class BezierTreeFollowComponent : CSerializable {
		[Serialize("isLooping"       )] public bool isLooping;
		[Serialize("moveSpeed"       )] public float moveSpeed;
		[Serialize("maxAngle"        )] public Angle maxAngle;
		[Serialize("sinFactor"       )] public float sinFactor;
		[Serialize("useSinAngle"     )] public bool useSinAngle;
		[Serialize("followCurveAngle")] public bool followCurveAngle;
		[Serialize("updateFlip"      )] public bool updateFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isLooping), boolAsByte: true);
			SerializeField(s, nameof(moveSpeed));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(sinFactor));
			SerializeField(s, nameof(useSinAngle), boolAsByte: true);
			SerializeField(s, nameof(followCurveAngle), boolAsByte: true);
			SerializeField(s, nameof(updateFlip), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x83B6061E;
	}
}

