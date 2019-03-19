using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGroundRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"                             )] public Placeholder fall;
		[Serialize("jumpUp"                           )] public Placeholder jumpUp;
		[Serialize("jumpDown"                         )] public Placeholder jumpDown;
		[Serialize("roamPause"                        )] public Placeholder roamPause;
		[Serialize("slopePause"                       )] public Placeholder slopePause;
		[Serialize("obstaclePause"                    )] public Placeholder obstaclePause;
		[Serialize("wallPause"                        )] public Placeholder wallPause;
		[Serialize("defaultPause"                     )] public Placeholder defaultPause;
		[Serialize("slopeDetectionRange"              )] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"                  )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"                )] public Angle maxSlopeAngleDown;
		[Serialize("waypointID"                       )] public StringID waypointID;
		[Serialize("startDelay"                       )] public float startDelay;
		[Serialize("canPush"                          )] public int canPush;
		[Serialize("pushForce"                        )] public float pushForce;
		[Serialize("lowWallHeight"                    )] public float lowWallHeight;
		[Serialize("drawDebug"                        )] public int drawDebug;
		[Serialize("Generic<AIAction_Template>__0"    )] public Generic<AIAction_Template> Generic_AIAction_Template__0;
		[Serialize("Generic<AIJumpAction_Template>__1")] public Generic<AIJumpAction_Template> Generic_AIJumpAction_Template__1;
		[Serialize("Generic<AIJumpAction_Template>__2")] public Generic<AIJumpAction_Template> Generic_AIJumpAction_Template__2;
		[Serialize("Generic<AIAction_Template>__3"    )] public Generic<AIAction_Template> Generic_AIAction_Template__3;
		[Serialize("Generic<AIAction_Template>__4"    )] public Generic<AIAction_Template> Generic_AIAction_Template__4;
		[Serialize("Generic<AIAction_Template>__5"    )] public Generic<AIAction_Template> Generic_AIAction_Template__5;
		[Serialize("Generic<AIAction_Template>__6"    )] public Generic<AIAction_Template> Generic_AIAction_Template__6;
		[Serialize("Generic<AIAction_Template>__7"    )] public Generic<AIAction_Template> Generic_AIAction_Template__7;
		[Serialize("float__8"                         )] public float float__8;
		[Serialize("Angle__9"                         )] public Angle Angle__9;
		[Serialize("Angle__10"                        )] public Angle Angle__10;
		[Serialize("StringID__11"                     )] public StringID StringID__11;
		[Serialize("float__12"                        )] public float float__12;
		[Serialize("int__13"                          )] public int int__13;
		[Serialize("float__14"                        )] public float float__14;
		[Serialize("float__15"                        )] public float float__15;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else {
				SerializeField(s, nameof(Generic_AIAction_Template__0));
				SerializeField(s, nameof(Generic_AIJumpAction_Template__1));
				SerializeField(s, nameof(Generic_AIJumpAction_Template__2));
				SerializeField(s, nameof(Generic_AIAction_Template__3));
				SerializeField(s, nameof(Generic_AIAction_Template__4));
				SerializeField(s, nameof(Generic_AIAction_Template__5));
				SerializeField(s, nameof(Generic_AIAction_Template__6));
				SerializeField(s, nameof(Generic_AIAction_Template__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(Angle__9));
				SerializeField(s, nameof(Angle__10));
				SerializeField(s, nameof(StringID__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(int__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
			}
		}
		public override uint? ClassCRC => 0xE69D7FA9;
	}
}

