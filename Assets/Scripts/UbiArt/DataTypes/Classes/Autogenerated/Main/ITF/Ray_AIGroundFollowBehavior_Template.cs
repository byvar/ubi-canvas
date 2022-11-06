using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIGroundFollowBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		public Placeholder detect;
		public Placeholder giveUp;
		public float giveUpDistance;
		public float minIdleTime;
		public float minWalkTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detect = s.SerializeObject<Placeholder>(detect, name: "detect");
			giveUp = s.SerializeObject<Placeholder>(giveUp, name: "giveUp");
			giveUpDistance = s.Serialize<float>(giveUpDistance, name: "giveUpDistance");
			minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
			minWalkTime = s.Serialize<float>(minWalkTime, name: "minWalkTime");
		}
		public override uint? ClassCRC => 0x4347354B;
	}
}

