using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIGroundFollowBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		[Serialize("detect"        )] public Placeholder detect;
		[Serialize("giveUp"        )] public Placeholder giveUp;
		[Serialize("giveUpDistance")] public float giveUpDistance;
		[Serialize("minIdleTime"   )] public float minIdleTime;
		[Serialize("minWalkTime"   )] public float minWalkTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detect));
			SerializeField(s, nameof(giveUp));
			SerializeField(s, nameof(giveUpDistance));
			SerializeField(s, nameof(minIdleTime));
			SerializeField(s, nameof(minWalkTime));
		}
		public override uint? ClassCRC => 0x4347354B;
	}
}

