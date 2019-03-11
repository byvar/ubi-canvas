using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIGroundRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"               )] public Placeholder fall;
		[Serialize("jumpUp"             )] public Placeholder jumpUp;
		[Serialize("jumpDown"           )] public Placeholder jumpDown;
		[Serialize("roamPause"          )] public Placeholder roamPause;
		[Serialize("slopePause"         )] public Placeholder slopePause;
		[Serialize("obstaclePause"      )] public Placeholder obstaclePause;
		[Serialize("wallPause"          )] public Placeholder wallPause;
		[Serialize("defaultPause"       )] public Placeholder defaultPause;
		[Serialize("slopeDetectionRange")] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"    )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"  )] public Angle maxSlopeAngleDown;
		[Serialize("waypointID"         )] public StringID waypointID;
		[Serialize("startDelay"         )] public float startDelay;
		[Serialize("canPush"            )] public bool canPush;
		[Serialize("pushForce"          )] public float pushForce;
		[Serialize("lowWallHeight"      )] public float lowWallHeight;
		[Serialize("drawDebug"          )] public bool drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(jumpUp));
			SerializeField(s, nameof(jumpDown));
			SerializeField(s, nameof(roamPause));
			SerializeField(s, nameof(slopePause));
			SerializeField(s, nameof(obstaclePause));
			SerializeField(s, nameof(wallPause));
			SerializeField(s, nameof(defaultPause));
			SerializeField(s, nameof(slopeDetectionRange));
			SerializeField(s, nameof(maxSlopeAngleUp));
			SerializeField(s, nameof(maxSlopeAngleDown));
			SerializeField(s, nameof(waypointID));
			SerializeField(s, nameof(startDelay));
			SerializeField(s, nameof(canPush));
			SerializeField(s, nameof(pushForce));
			SerializeField(s, nameof(lowWallHeight));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(drawDebug));
			}
		}
		public override uint? ClassCRC => 0xE69D7FA9;
	}
}

