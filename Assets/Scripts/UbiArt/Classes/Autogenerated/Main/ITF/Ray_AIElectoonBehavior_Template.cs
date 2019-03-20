using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIElectoonBehavior_Template : TemplateAIBehavior {
		[Serialize("walk"                                 )] public Placeholder walk;
		[Serialize("minTimeBeforeWalking"                 )] public float minTimeBeforeWalking;
		[Serialize("maxTimeBeforeWalking"                 )] public float maxTimeBeforeWalking;
		[Serialize("minTimeWalking"                       )] public float minTimeWalking;
		[Serialize("maxTimeWalking"                       )] public float maxTimeWalking;
		[Serialize("walkSpeed"                            )] public float walkSpeed;
		[Serialize("minEjectionSpeed"                     )] public float minEjectionSpeed;
		[Serialize("maxEjectionSpeed"                     )] public float maxEjectionSpeed;
		[Serialize("lovePlayerDistance"                   )] public float lovePlayerDistance;
		[Serialize("timeBeforeCanStopWalkingAndStandAgain")] public float timeBeforeCanStopWalkingAndStandAgain;
		[Serialize("mustStay"                             )] public int mustStay;
		[Serialize("maxDeltaYToFollow"                    )] public float maxDeltaYToFollow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walk));
			SerializeField(s, nameof(minTimeBeforeWalking));
			SerializeField(s, nameof(maxTimeBeforeWalking));
			SerializeField(s, nameof(minTimeWalking));
			SerializeField(s, nameof(maxTimeWalking));
			SerializeField(s, nameof(walkSpeed));
			SerializeField(s, nameof(minEjectionSpeed));
			SerializeField(s, nameof(maxEjectionSpeed));
			SerializeField(s, nameof(lovePlayerDistance));
			SerializeField(s, nameof(timeBeforeCanStopWalkingAndStandAgain));
			SerializeField(s, nameof(mustStay));
			SerializeField(s, nameof(maxDeltaYToFollow));
		}
		public override uint? ClassCRC => 0x7A99DE01;
	}
}

