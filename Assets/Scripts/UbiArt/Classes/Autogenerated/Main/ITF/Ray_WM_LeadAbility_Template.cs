using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_LeadAbility_Template : CSerializable {
		public BasicString startNode;
		public Angle findMoveAngle;
		public Angle reverseMoveAngle;
		public float maxSpeed;
		public float targetSpeedBlendFactor;
		public float speedBlendFactor;
		public float sprintMaxSpeed;
		public float sprintTargetSpeedBlendFactor;
		public float sprintSpeedBlendFactor;
		public float zOffset;
		public Placeholder followersAdjustOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startNode = s.SerializeObject<BasicString>(startNode, name: "startNode");
			findMoveAngle = s.SerializeObject<Angle>(findMoveAngle, name: "findMoveAngle");
			reverseMoveAngle = s.SerializeObject<Angle>(reverseMoveAngle, name: "reverseMoveAngle");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			targetSpeedBlendFactor = s.Serialize<float>(targetSpeedBlendFactor, name: "targetSpeedBlendFactor");
			speedBlendFactor = s.Serialize<float>(speedBlendFactor, name: "speedBlendFactor");
			sprintMaxSpeed = s.Serialize<float>(sprintMaxSpeed, name: "sprintMaxSpeed");
			sprintTargetSpeedBlendFactor = s.Serialize<float>(sprintTargetSpeedBlendFactor, name: "sprintTargetSpeedBlendFactor");
			sprintSpeedBlendFactor = s.Serialize<float>(sprintSpeedBlendFactor, name: "sprintSpeedBlendFactor");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			followersAdjustOffsets = s.SerializeObject<Placeholder>(followersAdjustOffsets, name: "followersAdjustOffsets");
		}
		public override uint? ClassCRC => 0x71D40CBF;
	}
}

