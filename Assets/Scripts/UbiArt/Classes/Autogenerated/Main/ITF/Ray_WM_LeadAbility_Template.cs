using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_LeadAbility_Template : CSerializable {
		[Serialize("startNode"                   )] public BasicString startNode;
		[Serialize("findMoveAngle"               )] public Angle findMoveAngle;
		[Serialize("reverseMoveAngle"            )] public Angle reverseMoveAngle;
		[Serialize("maxSpeed"                    )] public float maxSpeed;
		[Serialize("targetSpeedBlendFactor"      )] public float targetSpeedBlendFactor;
		[Serialize("speedBlendFactor"            )] public float speedBlendFactor;
		[Serialize("sprintMaxSpeed"              )] public float sprintMaxSpeed;
		[Serialize("sprintTargetSpeedBlendFactor")] public float sprintTargetSpeedBlendFactor;
		[Serialize("sprintSpeedBlendFactor"      )] public float sprintSpeedBlendFactor;
		[Serialize("zOffset"                     )] public float zOffset;
		[Serialize("followersAdjustOffsets"      )] public Placeholder followersAdjustOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startNode));
			SerializeField(s, nameof(findMoveAngle));
			SerializeField(s, nameof(reverseMoveAngle));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(targetSpeedBlendFactor));
			SerializeField(s, nameof(speedBlendFactor));
			SerializeField(s, nameof(sprintMaxSpeed));
			SerializeField(s, nameof(sprintTargetSpeedBlendFactor));
			SerializeField(s, nameof(sprintSpeedBlendFactor));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(followersAdjustOffsets));
		}
		public override uint? ClassCRC => 0x71D40CBF;
	}
}

