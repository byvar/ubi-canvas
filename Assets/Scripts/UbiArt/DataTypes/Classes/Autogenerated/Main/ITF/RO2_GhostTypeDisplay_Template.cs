using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GhostTypeDisplay_Template : CSerializable {
		public GraphicActorInfo friendlyActorInfo;
		public GraphicActorInfo darkActorInfo;
		public float rotationSpeed;
		public Vec2d posOffset;
		public float rotatePosDist;
		public float rotatePosDistBlendFactor;
		public float deltaMove;
		public float deltaMoveSpeed;
		public float targetTransitionDuration;
		public uint testNumber;
		public uint initStartType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			friendlyActorInfo = s.SerializeObject<GraphicActorInfo>(friendlyActorInfo, name: "friendlyActorInfo");
			darkActorInfo = s.SerializeObject<GraphicActorInfo>(darkActorInfo, name: "darkActorInfo");
			rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
			rotatePosDist = s.Serialize<float>(rotatePosDist, name: "rotatePosDist");
			rotatePosDistBlendFactor = s.Serialize<float>(rotatePosDistBlendFactor, name: "rotatePosDistBlendFactor");
			deltaMove = s.Serialize<float>(deltaMove, name: "deltaMove");
			deltaMoveSpeed = s.Serialize<float>(deltaMoveSpeed, name: "deltaMoveSpeed");
			targetTransitionDuration = s.Serialize<float>(targetTransitionDuration, name: "targetTransitionDuration");
			testNumber = s.Serialize<uint>(testNumber, name: "testNumber");
			initStartType = s.Serialize<uint>(initStartType, name: "initStartType");
		}
		public override uint? ClassCRC => 0xA1832B53;
	}
}

