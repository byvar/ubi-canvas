using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGroundRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		public Generic<AIAction_Template> fall;
		public Generic<AIJumpAction_Template> jumpUp;
		public Generic<AIJumpAction_Template> jumpDown;
		public Generic<AIAction_Template> roamPause;
		public Generic<AIAction_Template> slopePause;
		public Generic<AIAction_Template> obstaclePause;
		public Generic<AIAction_Template> wallPause;
		public Generic<AIAction_Template> defaultPause;
		public float slopeDetectionRange;
		public Angle maxSlopeAngleUp;
		public Angle maxSlopeAngleDown;
		public StringID waypointID;
		public float startDelay;
		public int canPush;
		public float pushForce;
		public float lowWallHeight;
		public int drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fall = s.SerializeObject<Generic<AIAction_Template>>(fall, name: "fall");
			jumpUp = s.SerializeObject<Generic<AIJumpAction_Template>>(jumpUp, name: "jumpUp");
			jumpDown = s.SerializeObject<Generic<AIJumpAction_Template>>(jumpDown, name: "jumpDown");
			roamPause = s.SerializeObject<Generic<AIAction_Template>>(roamPause, name: "roamPause");
			slopePause = s.SerializeObject<Generic<AIAction_Template>>(slopePause, name: "slopePause");
			obstaclePause = s.SerializeObject<Generic<AIAction_Template>>(obstaclePause, name: "obstaclePause");
			wallPause = s.SerializeObject<Generic<AIAction_Template>>(wallPause, name: "wallPause");
			defaultPause = s.SerializeObject<Generic<AIAction_Template>>(defaultPause, name: "defaultPause");
			slopeDetectionRange = s.Serialize<float>(slopeDetectionRange, name: "slopeDetectionRange");
			maxSlopeAngleUp = s.SerializeObject<Angle>(maxSlopeAngleUp, name: "maxSlopeAngleUp");
			maxSlopeAngleDown = s.SerializeObject<Angle>(maxSlopeAngleDown, name: "maxSlopeAngleDown");
			waypointID = s.SerializeObject<StringID>(waypointID, name: "waypointID");
			startDelay = s.Serialize<float>(startDelay, name: "startDelay");
			canPush = s.Serialize<int>(canPush, name: "canPush");
			pushForce = s.Serialize<float>(pushForce, name: "pushForce");
			lowWallHeight = s.Serialize<float>(lowWallHeight, name: "lowWallHeight");
			if (s.Settings.game == Settings.Game.RO && s.HasFlags(SerializeFlags.Flags_xC0)) {
				drawDebug = s.Serialize<int>(drawDebug, name: "drawDebug");
			}
		}
		public override uint? ClassCRC => 0xE69D7FA9;
	}
}

