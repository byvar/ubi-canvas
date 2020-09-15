using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIChest2Behavior_Template : TemplateAIBehavior {
		public float safeDistance;
		public float minSpeed;
		public float maxSpeed;
		public float swimMinSpeed;
		public float swimMaxSpeed;
		public float waitSpeed;
		public float upsideDownFloorSpeed;
		public float upsideDownCeilingSpeed;
		public float breakableSpeed;
		public float reducedScale;
		public float eyeMinX;
		public float eyeMaxX;
		public float eyeMinY;
		public float eyeMaxY;
		public Vec2d relativeNeutralEyePos;
		public float distanceToEyeFactor;
		public float typicalPlayerHeadY;
		public Path breakFx;
		public int relicIndex;
		public Path relicActor;
		public int sendBreakEventsDirectly;
		public int disableAfterBreakEvents;
		public int snapBreakSequencePlayer;
		public Placeholder breakEvents;
		public float detectDelay;
		public float hideTimeout;
		public int canReverse;
		public float reverseInterval;
		public Generic<AIAction_Template> standAction;
		public Generic<AIAction_Template> runAction;
		public Generic<AIAction_Template> jumpAction;
		public Generic<AIAction_Template> toFlyAction;
		public Generic<AIAction_Template> flyAction;
		public Generic<AIAction_Template> landAction;
		public Generic<AIAction_Template> skidAction;
		public Generic<AIAction_Template> waitAction;
		public Generic<AIAction_Template> tauntAction;
		public Generic<AIAction_Template> diveAction;
		public Generic<AIAction_Template> swimAction;
		public Generic<AIAction_Template> thinkDetectAction;
		public Generic<AIAction_Template> thinkHideAction;
		public Generic<AIAction_Template> breaksAction;
		public Generic<AIAction_Template> brokenAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			safeDistance = s.Serialize<float>(safeDistance, name: "safeDistance");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			swimMinSpeed = s.Serialize<float>(swimMinSpeed, name: "swimMinSpeed");
			swimMaxSpeed = s.Serialize<float>(swimMaxSpeed, name: "swimMaxSpeed");
			waitSpeed = s.Serialize<float>(waitSpeed, name: "waitSpeed");
			upsideDownFloorSpeed = s.Serialize<float>(upsideDownFloorSpeed, name: "upsideDownFloorSpeed");
			upsideDownCeilingSpeed = s.Serialize<float>(upsideDownCeilingSpeed, name: "upsideDownCeilingSpeed");
			breakableSpeed = s.Serialize<float>(breakableSpeed, name: "breakableSpeed");
			reducedScale = s.Serialize<float>(reducedScale, name: "reducedScale");
			eyeMinX = s.Serialize<float>(eyeMinX, name: "eyeMinX");
			eyeMaxX = s.Serialize<float>(eyeMaxX, name: "eyeMaxX");
			eyeMinY = s.Serialize<float>(eyeMinY, name: "eyeMinY");
			eyeMaxY = s.Serialize<float>(eyeMaxY, name: "eyeMaxY");
			relativeNeutralEyePos = s.SerializeObject<Vec2d>(relativeNeutralEyePos, name: "relativeNeutralEyePos");
			distanceToEyeFactor = s.Serialize<float>(distanceToEyeFactor, name: "distanceToEyeFactor");
			typicalPlayerHeadY = s.Serialize<float>(typicalPlayerHeadY, name: "typicalPlayerHeadY");
			breakFx = s.SerializeObject<Path>(breakFx, name: "breakFx");
			relicIndex = s.Serialize<int>(relicIndex, name: "relicIndex");
			relicActor = s.SerializeObject<Path>(relicActor, name: "relicActor");
			sendBreakEventsDirectly = s.Serialize<int>(sendBreakEventsDirectly, name: "sendBreakEventsDirectly");
			disableAfterBreakEvents = s.Serialize<int>(disableAfterBreakEvents, name: "disableAfterBreakEvents");
			snapBreakSequencePlayer = s.Serialize<int>(snapBreakSequencePlayer, name: "snapBreakSequencePlayer");
			breakEvents = s.SerializeObject<Placeholder>(breakEvents, name: "breakEvents");
			detectDelay = s.Serialize<float>(detectDelay, name: "detectDelay");
			hideTimeout = s.Serialize<float>(hideTimeout, name: "hideTimeout");
			canReverse = s.Serialize<int>(canReverse, name: "canReverse");
			reverseInterval = s.Serialize<float>(reverseInterval, name: "reverseInterval");
			standAction = s.SerializeObject<Generic<AIAction_Template>>(standAction, name: "standAction");
			runAction = s.SerializeObject<Generic<AIAction_Template>>(runAction, name: "runAction");
			jumpAction = s.SerializeObject<Generic<AIAction_Template>>(jumpAction, name: "jumpAction");
			toFlyAction = s.SerializeObject<Generic<AIAction_Template>>(toFlyAction, name: "toFlyAction");
			flyAction = s.SerializeObject<Generic<AIAction_Template>>(flyAction, name: "flyAction");
			landAction = s.SerializeObject<Generic<AIAction_Template>>(landAction, name: "landAction");
			skidAction = s.SerializeObject<Generic<AIAction_Template>>(skidAction, name: "skidAction");
			waitAction = s.SerializeObject<Generic<AIAction_Template>>(waitAction, name: "waitAction");
			tauntAction = s.SerializeObject<Generic<AIAction_Template>>(tauntAction, name: "tauntAction");
			diveAction = s.SerializeObject<Generic<AIAction_Template>>(diveAction, name: "diveAction");
			swimAction = s.SerializeObject<Generic<AIAction_Template>>(swimAction, name: "swimAction");
			thinkDetectAction = s.SerializeObject<Generic<AIAction_Template>>(thinkDetectAction, name: "thinkDetectAction");
			thinkHideAction = s.SerializeObject<Generic<AIAction_Template>>(thinkHideAction, name: "thinkHideAction");
			breaksAction = s.SerializeObject<Generic<AIAction_Template>>(breaksAction, name: "breaksAction");
			brokenAction = s.SerializeObject<Generic<AIAction_Template>>(brokenAction, name: "brokenAction");
		}
		public override uint? ClassCRC => 0x3344CE5B;
	}
}

