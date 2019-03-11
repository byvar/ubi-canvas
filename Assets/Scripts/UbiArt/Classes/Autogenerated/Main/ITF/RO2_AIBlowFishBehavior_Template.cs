using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIBlowFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		[Serialize("idle"                    )] public Generic<AIAction_Template> idle;
		[Serialize("detect"                  )] public Generic<AIAction_Template> detect;
		[Serialize("inflatedIdle"            )] public Generic<AIAction_Template> inflatedIdle;
		[Serialize("inflate"                 )] public Generic<AIAction_Template> inflate;
		[Serialize("deflate"                 )] public Generic<AIAction_Template> deflate;
		[Serialize("hold"                    )] public Generic<AIAction_Template> hold;
		[Serialize("detectionRange"          )] public float detectionRange;
		[Serialize("detectionCloseRange"     )] public float detectionCloseRange;
		[Serialize("inflateDuration"         )] public float inflateDuration;
		[Serialize("inflatedScaleMultiplier" )] public float inflatedScaleMultiplier;
		[Serialize("deflateDuration"         )] public float deflateDuration;
		[Serialize("minIdleDuration"         )] public float minIdleDuration;
		[Serialize("minInflatedDuration"     )] public float minInflatedDuration;
		[Serialize("repulsionForce"          )] public float repulsionForce;
		[Serialize("attractionForce"         )] public float attractionForce;
		[Serialize("friction"                )] public float friction;
		[Serialize("memorizedHitTime"        )] public float memorizedHitTime;
		[Serialize("minHoldTime"             )] public float minHoldTime;
		[Serialize("lumsByReward"            )] public uint lumsByReward;
		[Serialize("countMaxReward"          )] public uint countMaxReward;
		[Serialize("timeBetweenRewardInSwipe")] public float timeBetweenRewardInSwipe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(detect));
			SerializeField(s, nameof(inflatedIdle));
			SerializeField(s, nameof(inflate));
			SerializeField(s, nameof(deflate));
			SerializeField(s, nameof(hold));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(detectionCloseRange));
			SerializeField(s, nameof(inflateDuration));
			SerializeField(s, nameof(inflatedScaleMultiplier));
			SerializeField(s, nameof(deflateDuration));
			SerializeField(s, nameof(minIdleDuration));
			SerializeField(s, nameof(minInflatedDuration));
			SerializeField(s, nameof(repulsionForce));
			SerializeField(s, nameof(attractionForce));
			SerializeField(s, nameof(friction));
			SerializeField(s, nameof(memorizedHitTime));
			SerializeField(s, nameof(minHoldTime));
			SerializeField(s, nameof(lumsByReward));
			SerializeField(s, nameof(countMaxReward));
			SerializeField(s, nameof(timeBetweenRewardInSwipe));
		}
		public override uint? ClassCRC => 0x798C5FA2;
	}
}

