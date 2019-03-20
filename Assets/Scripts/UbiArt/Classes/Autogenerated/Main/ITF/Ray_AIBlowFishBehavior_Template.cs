using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBlowFishBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"                   )] public Placeholder idle;
		[Serialize("detect"                 )] public Placeholder detect;
		[Serialize("inflatedIdle"           )] public Placeholder inflatedIdle;
		[Serialize("inflate"                )] public Placeholder inflate;
		[Serialize("deflate"                )] public Placeholder deflate;
		[Serialize("detectionRange"         )] public float detectionRange;
		[Serialize("detectionCloseRange"    )] public float detectionCloseRange;
		[Serialize("inflateDuration"        )] public float inflateDuration;
		[Serialize("inflatedScaleMultiplier")] public float inflatedScaleMultiplier;
		[Serialize("deflateDuration"        )] public float deflateDuration;
		[Serialize("minIdleDuration"        )] public float minIdleDuration;
		[Serialize("minInflatedDuration"    )] public float minInflatedDuration;
		[Serialize("repulsionForce"         )] public float repulsionForce;
		[Serialize("attractionForce"        )] public float attractionForce;
		[Serialize("friction"               )] public float friction;
		[Serialize("memorizedHitTime"       )] public float memorizedHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(detect));
			SerializeField(s, nameof(inflatedIdle));
			SerializeField(s, nameof(inflate));
			SerializeField(s, nameof(deflate));
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
		}
		public override uint? ClassCRC => 0xB86B7B26;
	}
}

