using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MovableObject_Template : CSerializable {
		[Serialize("anchorOffset"          )] public Vec2d anchorOffset;
		[Serialize("noFxDelay"             )] public float noFxDelay;
		[Serialize("impactFxSpeedThreshold")] public float impactFxSpeedThreshold;
		[Serialize("moveFxSpeedThreshold"  )] public float moveFxSpeedThreshold;
		[Serialize("impactFxID"            )] public StringID impactFxID;
		[Serialize("startMovingFxID"       )] public StringID startMovingFxID;
		[Serialize("stopMovingFxID"        )] public StringID stopMovingFxID;
		[Serialize("avoidanceCheckDistance")] public float avoidanceCheckDistance;
		[Serialize("avoidanceCheckRadius"  )] public float avoidanceCheckRadius;
		[Serialize("avoidanceSpeed"        )] public float avoidanceSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anchorOffset));
			SerializeField(s, nameof(noFxDelay));
			SerializeField(s, nameof(impactFxSpeedThreshold));
			SerializeField(s, nameof(moveFxSpeedThreshold));
			SerializeField(s, nameof(impactFxID));
			SerializeField(s, nameof(startMovingFxID));
			SerializeField(s, nameof(stopMovingFxID));
			SerializeField(s, nameof(avoidanceCheckDistance));
			SerializeField(s, nameof(avoidanceCheckRadius));
			SerializeField(s, nameof(avoidanceSpeed));
		}
		public override uint? ClassCRC => 0x8F18F05D;
	}
}

