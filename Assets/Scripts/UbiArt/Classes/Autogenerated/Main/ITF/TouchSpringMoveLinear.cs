using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class TouchSpringMoveLinear : TouchSpringMoveBase {
		public float totalLength;
		public float initPos;
		public float minPosLimit;
		public float maxPosLimit;
		public bool useStartingLength;
		public float startingLength;
		public Angle axisAngle;
		public bool useSnap;
		public float snapDistance;
		public float snapMinCursorSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			totalLength = s.Serialize<float>(totalLength, name: "totalLength");
			initPos = s.Serialize<float>(initPos, name: "initPos");
			minPosLimit = s.Serialize<float>(minPosLimit, name: "minPosLimit");
			maxPosLimit = s.Serialize<float>(maxPosLimit, name: "maxPosLimit");
			useStartingLength = s.Serialize<bool>(useStartingLength, name: "useStartingLength");
			startingLength = s.Serialize<float>(startingLength, name: "startingLength");
			axisAngle = s.SerializeObject<Angle>(axisAngle, name: "axisAngle");
			useSnap = s.Serialize<bool>(useSnap, name: "useSnap");
			snapDistance = s.Serialize<float>(snapDistance, name: "snapDistance");
			snapMinCursorSpeed = s.Serialize<float>(snapMinCursorSpeed, name: "snapMinCursorSpeed");
		}
		public override uint? ClassCRC => 0xC0A14FBF;
	}
}

