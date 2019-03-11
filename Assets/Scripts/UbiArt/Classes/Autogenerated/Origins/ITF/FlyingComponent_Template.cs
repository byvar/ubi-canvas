using UnityEngine;

namespace UbiArt.ITF {
	public partial class FlyingComponent_Template : CSerializable {
		[Serialize("DebugData"               )] public Placeholder DebugData;
		[Serialize("FlyingComponentDebugData")] public Placeholder FlyingComponentDebugData;
		[Serialize("MoveVecBlendFactor"      )] public float MoveVecBlendFactor;
		[Serialize("MoveSpeed"               )] public float MoveSpeed;
		[Serialize("MoveDirMaxAngle"         )] public float MoveDirMaxAngle;
		[Serialize("MoveDirMinAngle"         )] public float MoveDirMinAngle;
		[Serialize("MoveDirAmplitude"        )] public float MoveDirAmplitude;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DebugData));
			SerializeField(s, nameof(FlyingComponentDebugData));
			SerializeField(s, nameof(MoveVecBlendFactor));
			SerializeField(s, nameof(MoveSpeed));
			SerializeField(s, nameof(MoveDirMaxAngle));
			SerializeField(s, nameof(MoveDirMinAngle));
			SerializeField(s, nameof(MoveDirAmplitude));
		}
		public override uint? ClassCRC => 0x7E676187;
	}
}

