using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIElectoonBehavior_Template : TemplateAIBehavior {
		public Placeholder walk;
		public float minTimeBeforeWalking;
		public float maxTimeBeforeWalking;
		public float minTimeWalking;
		public float maxTimeWalking;
		public float walkSpeed;
		public float minEjectionSpeed;
		public float maxEjectionSpeed;
		public float lovePlayerDistance;
		public float timeBeforeCanStopWalkingAndStandAgain;
		public int mustStay;
		public float maxDeltaYToFollow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walk = s.SerializeObject<Placeholder>(walk, name: "walk");
			minTimeBeforeWalking = s.Serialize<float>(minTimeBeforeWalking, name: "minTimeBeforeWalking");
			maxTimeBeforeWalking = s.Serialize<float>(maxTimeBeforeWalking, name: "maxTimeBeforeWalking");
			minTimeWalking = s.Serialize<float>(minTimeWalking, name: "minTimeWalking");
			maxTimeWalking = s.Serialize<float>(maxTimeWalking, name: "maxTimeWalking");
			walkSpeed = s.Serialize<float>(walkSpeed, name: "walkSpeed");
			minEjectionSpeed = s.Serialize<float>(minEjectionSpeed, name: "minEjectionSpeed");
			maxEjectionSpeed = s.Serialize<float>(maxEjectionSpeed, name: "maxEjectionSpeed");
			lovePlayerDistance = s.Serialize<float>(lovePlayerDistance, name: "lovePlayerDistance");
			timeBeforeCanStopWalkingAndStandAgain = s.Serialize<float>(timeBeforeCanStopWalkingAndStandAgain, name: "timeBeforeCanStopWalkingAndStandAgain");
			mustStay = s.Serialize<int>(mustStay, name: "mustStay");
			maxDeltaYToFollow = s.Serialize<float>(maxDeltaYToFollow, name: "maxDeltaYToFollow");
		}
		public override uint? ClassCRC => 0x7A99DE01;
	}
}

