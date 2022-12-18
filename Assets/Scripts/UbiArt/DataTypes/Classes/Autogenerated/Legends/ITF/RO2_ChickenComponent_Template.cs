namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ChickenComponent_Template : CSerializable {
		public StringID waitAnim;
		public StringID staticAnim;
		public StringID runAnim;
		public StringID fallAnim;
		public StringID flyAnim;
		public StringID transformAnim;
		public StringID sailorAnim;
		public StringID wait2Anim;
		public StringID walkAnim;
		public StringID jumpAnimStart;
		public StringID jumpAnimCycle;
		public StringID jumpAnimStartToCycle;
		public StringID jumpAnimLanding;
		public StringID detectionAnim;
		public float speed;
		public float walkSpeed;
		public Placeholder detectionAABB;
		public float escapeSpeed;
		public float escapeSpeed2;
		public float escapeLength;
		public float escapeHight;
		public float playerDistFromLand;
		public int useRandomDetection;
		public float bezierControl;
		public float afterEscapeDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitAnim = s.SerializeObject<StringID>(waitAnim, name: "waitAnim");
			staticAnim = s.SerializeObject<StringID>(staticAnim, name: "staticAnim");
			runAnim = s.SerializeObject<StringID>(runAnim, name: "runAnim");
			fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
			flyAnim = s.SerializeObject<StringID>(flyAnim, name: "flyAnim");
			transformAnim = s.SerializeObject<StringID>(transformAnim, name: "transformAnim");
			sailorAnim = s.SerializeObject<StringID>(sailorAnim, name: "sailorAnim");
			wait2Anim = s.SerializeObject<StringID>(wait2Anim, name: "wait2Anim");
			walkAnim = s.SerializeObject<StringID>(walkAnim, name: "walkAnim");
			jumpAnimStart = s.SerializeObject<StringID>(jumpAnimStart, name: "jumpAnimStart");
			jumpAnimCycle = s.SerializeObject<StringID>(jumpAnimCycle, name: "jumpAnimCycle");
			jumpAnimStartToCycle = s.SerializeObject<StringID>(jumpAnimStartToCycle, name: "jumpAnimStartToCycle");
			jumpAnimLanding = s.SerializeObject<StringID>(jumpAnimLanding, name: "jumpAnimLanding");
			detectionAnim = s.SerializeObject<StringID>(detectionAnim, name: "detectionAnim");
			speed = s.Serialize<float>(speed, name: "speed");
			walkSpeed = s.Serialize<float>(walkSpeed, name: "walkSpeed");
			detectionAABB = s.SerializeObject<Placeholder>(detectionAABB, name: "detectionAABB");
			escapeSpeed = s.Serialize<float>(escapeSpeed, name: "escapeSpeed");
			escapeSpeed2 = s.Serialize<float>(escapeSpeed2, name: "escapeSpeed2");
			escapeLength = s.Serialize<float>(escapeLength, name: "escapeLength");
			escapeHight = s.Serialize<float>(escapeHight, name: "escapeHight");
			playerDistFromLand = s.Serialize<float>(playerDistFromLand, name: "playerDistFromLand");
			useRandomDetection = s.Serialize<int>(useRandomDetection, name: "useRandomDetection");
			bezierControl = s.Serialize<float>(bezierControl, name: "bezierControl");
			afterEscapeDelay = s.Serialize<float>(afterEscapeDelay, name: "afterEscapeDelay");
		}
		public override uint? ClassCRC => 0x3E8AB050;
	}
}

