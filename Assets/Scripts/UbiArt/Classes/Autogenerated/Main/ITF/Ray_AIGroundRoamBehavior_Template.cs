using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGroundRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"                             )] public Generic<AIAction_Template> fall;
		[Serialize("jumpUp"                           )] public Generic<AIJumpAction_Template> jumpUp;
		[Serialize("jumpDown"                         )] public Generic<AIJumpAction_Template> jumpDown;
		[Serialize("roamPause"                        )] public Generic<AIAction_Template> roamPause;
		[Serialize("slopePause"                       )] public Generic<AIAction_Template> slopePause;
		[Serialize("obstaclePause"                    )] public Generic<AIAction_Template> obstaclePause;
		[Serialize("wallPause"                        )] public Generic<AIAction_Template> wallPause;
		[Serialize("defaultPause"                     )] public Generic<AIAction_Template> defaultPause;
		[Serialize("slopeDetectionRange"              )] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"                  )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"                )] public Angle maxSlopeAngleDown;
		[Serialize("waypointID"                       )] public StringID waypointID;
		[Serialize("startDelay"                       )] public float startDelay;
		[Serialize("canPush"                          )] public int canPush;
		[Serialize("pushForce"                        )] public float pushForce;
		[Serialize("lowWallHeight"                    )] public float lowWallHeight;
		[Serialize("drawDebug"                        )] public int drawDebug;
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
			if (Settings.s.game == Settings.Game.RO && s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(drawDebug));
			}
		}
		public override uint? ClassCRC => 0xE69D7FA9;
	}
}

