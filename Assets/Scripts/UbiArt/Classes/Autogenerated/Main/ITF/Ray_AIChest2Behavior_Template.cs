using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIChest2Behavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("safeDistance"           )] public float safeDistance;
		[Serialize("minSpeed"               )] public float minSpeed;
		[Serialize("maxSpeed"               )] public float maxSpeed;
		[Serialize("swimMinSpeed"           )] public float swimMinSpeed;
		[Serialize("swimMaxSpeed"           )] public float swimMaxSpeed;
		[Serialize("waitSpeed"              )] public float waitSpeed;
		[Serialize("upsideDownFloorSpeed"   )] public float upsideDownFloorSpeed;
		[Serialize("upsideDownCeilingSpeed" )] public float upsideDownCeilingSpeed;
		[Serialize("breakableSpeed"         )] public float breakableSpeed;
		[Serialize("reducedScale"           )] public float reducedScale;
		[Serialize("eyeMinX"                )] public float eyeMinX;
		[Serialize("eyeMaxX"                )] public float eyeMaxX;
		[Serialize("eyeMinY"                )] public float eyeMinY;
		[Serialize("eyeMaxY"                )] public float eyeMaxY;
		[Serialize("relativeNeutralEyePos"  )] public Vector2 relativeNeutralEyePos;
		[Serialize("distanceToEyeFactor"    )] public float distanceToEyeFactor;
		[Serialize("typicalPlayerHeadY"     )] public float typicalPlayerHeadY;
		[Serialize("breakFx"                )] public Path breakFx;
		[Serialize("relicIndex"             )] public int relicIndex;
		[Serialize("relicActor"             )] public Path relicActor;
		[Serialize("sendBreakEventsDirectly")] public int sendBreakEventsDirectly;
		[Serialize("disableAfterBreakEvents")] public int disableAfterBreakEvents;
		[Serialize("snapBreakSequencePlayer")] public int snapBreakSequencePlayer;
		[Serialize("breakEvents"            )] public Placeholder breakEvents;
		[Serialize("detectDelay"            )] public float detectDelay;
		[Serialize("hideTimeout"            )] public float hideTimeout;
		[Serialize("canReverse"             )] public int canReverse;
		[Serialize("reverseInterval"        )] public float reverseInterval;
		[Serialize("standAction"            )] public Placeholder standAction;
		[Serialize("runAction"              )] public Placeholder runAction;
		[Serialize("jumpAction"             )] public Placeholder jumpAction;
		[Serialize("toFlyAction"            )] public Placeholder toFlyAction;
		[Serialize("flyAction"              )] public Placeholder flyAction;
		[Serialize("landAction"             )] public Placeholder landAction;
		[Serialize("skidAction"             )] public Placeholder skidAction;
		[Serialize("waitAction"             )] public Placeholder waitAction;
		[Serialize("tauntAction"            )] public Placeholder tauntAction;
		[Serialize("diveAction"             )] public Placeholder diveAction;
		[Serialize("swimAction"             )] public Placeholder swimAction;
		[Serialize("thinkDetectAction"      )] public Placeholder thinkDetectAction;
		[Serialize("thinkHideAction"        )] public Placeholder thinkHideAction;
		[Serialize("breaksAction"           )] public Placeholder breaksAction;
		[Serialize("brokenAction"           )] public Placeholder brokenAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(safeDistance));
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(swimMinSpeed));
			SerializeField(s, nameof(swimMaxSpeed));
			SerializeField(s, nameof(waitSpeed));
			SerializeField(s, nameof(upsideDownFloorSpeed));
			SerializeField(s, nameof(upsideDownCeilingSpeed));
			SerializeField(s, nameof(breakableSpeed));
			SerializeField(s, nameof(reducedScale));
			SerializeField(s, nameof(eyeMinX));
			SerializeField(s, nameof(eyeMaxX));
			SerializeField(s, nameof(eyeMinY));
			SerializeField(s, nameof(eyeMaxY));
			SerializeField(s, nameof(relativeNeutralEyePos));
			SerializeField(s, nameof(distanceToEyeFactor));
			SerializeField(s, nameof(typicalPlayerHeadY));
			SerializeField(s, nameof(breakFx));
			SerializeField(s, nameof(relicIndex));
			SerializeField(s, nameof(relicActor));
			SerializeField(s, nameof(sendBreakEventsDirectly));
			SerializeField(s, nameof(disableAfterBreakEvents));
			SerializeField(s, nameof(snapBreakSequencePlayer));
			SerializeField(s, nameof(breakEvents));
			SerializeField(s, nameof(detectDelay));
			SerializeField(s, nameof(hideTimeout));
			SerializeField(s, nameof(canReverse));
			SerializeField(s, nameof(reverseInterval));
			SerializeField(s, nameof(standAction));
			SerializeField(s, nameof(runAction));
			SerializeField(s, nameof(jumpAction));
			SerializeField(s, nameof(toFlyAction));
			SerializeField(s, nameof(flyAction));
			SerializeField(s, nameof(landAction));
			SerializeField(s, nameof(skidAction));
			SerializeField(s, nameof(waitAction));
			SerializeField(s, nameof(tauntAction));
			SerializeField(s, nameof(diveAction));
			SerializeField(s, nameof(swimAction));
			SerializeField(s, nameof(thinkDetectAction));
			SerializeField(s, nameof(thinkHideAction));
			SerializeField(s, nameof(breaksAction));
			SerializeField(s, nameof(brokenAction));
		}
		public override uint? ClassCRC => 0x3344CE5B;
	}
}

