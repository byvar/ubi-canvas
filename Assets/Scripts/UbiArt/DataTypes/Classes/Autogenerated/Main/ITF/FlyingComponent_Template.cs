using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class FlyingComponent_Template : CSerializable {
		public Placeholder DebugData;
		public Placeholder FlyingComponentDebugData;
		public float MoveVecBlendFactor;
		public float MoveSpeed;
		public float MoveDirMaxAngle;
		public float MoveDirMinAngle;
		public float MoveDirAmplitude;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DebugData = s.SerializeObject<Placeholder>(DebugData, name: "DebugData");
			FlyingComponentDebugData = s.SerializeObject<Placeholder>(FlyingComponentDebugData, name: "FlyingComponentDebugData");
			MoveVecBlendFactor = s.Serialize<float>(MoveVecBlendFactor, name: "MoveVecBlendFactor");
			MoveSpeed = s.Serialize<float>(MoveSpeed, name: "MoveSpeed");
			MoveDirMaxAngle = s.Serialize<float>(MoveDirMaxAngle, name: "MoveDirMaxAngle");
			MoveDirMinAngle = s.Serialize<float>(MoveDirMinAngle, name: "MoveDirMinAngle");
			MoveDirAmplitude = s.Serialize<float>(MoveDirAmplitude, name: "MoveDirAmplitude");
		}
		public override uint? ClassCRC => 0x7E676187;
	}
}

