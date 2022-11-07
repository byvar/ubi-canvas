namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionPerformPedestal_Template : BTAction_Template {
		public StringID animPedestal;
		public StringID animJump;
		public StringID supportBone;
		public StringID walkTargetFactActor;
		public StringID walkTargetFactPos;
		public float areaRadius;
		public float distanceCheck;
		public float feetDistanceCheck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPedestal = s.SerializeObject<StringID>(animPedestal, name: "animPedestal");
			animJump = s.SerializeObject<StringID>(animJump, name: "animJump");
			supportBone = s.SerializeObject<StringID>(supportBone, name: "supportBone");
			walkTargetFactActor = s.SerializeObject<StringID>(walkTargetFactActor, name: "walkTargetFactActor");
			walkTargetFactPos = s.SerializeObject<StringID>(walkTargetFactPos, name: "walkTargetFactPos");
			areaRadius = s.Serialize<float>(areaRadius, name: "areaRadius");
			distanceCheck = s.Serialize<float>(distanceCheck, name: "distanceCheck");
			feetDistanceCheck = s.Serialize<float>(feetDistanceCheck, name: "feetDistanceCheck");
		}
		public override uint? ClassCRC => 0xFFF82AD2;
	}
}

