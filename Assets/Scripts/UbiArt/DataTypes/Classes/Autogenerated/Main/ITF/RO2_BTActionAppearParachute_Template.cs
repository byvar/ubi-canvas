namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearParachute_Template : BTAction_Template {
		public StringID anim;
		public StringID animLanding;
		public StringID animDropParachute;
		public StringID animCarryingStart;
		public StringID animCarryingStop;
		public StringID animFreeFall;
		public StringID animBaseJump;
		public StringID animBasejumpToParachute;
		public float speed = 1f;
		public float speedBasejump = 2f;
		public float distParachute = 3f;
		public float parachuteForce = 0.5f;
		public float lateralForce;
		public float intensity = 1f;
		public float frequency = 0.5f;
		public float windMultiplier = 1f;
		public float freefallWindMultiplier = 0.4f;
		public Angle angleRotateMin;
		public Angle angleRotateMax;
		public Path actorParachutePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			animLanding = s.SerializeObject<StringID>(animLanding, name: "animLanding");
			animDropParachute = s.SerializeObject<StringID>(animDropParachute, name: "animDropParachute");
			animCarryingStart = s.SerializeObject<StringID>(animCarryingStart, name: "animCarryingStart");
			animCarryingStop = s.SerializeObject<StringID>(animCarryingStop, name: "animCarryingStop");
			animFreeFall = s.SerializeObject<StringID>(animFreeFall, name: "animFreeFall");
			animBaseJump = s.SerializeObject<StringID>(animBaseJump, name: "animBaseJump");
			animBasejumpToParachute = s.SerializeObject<StringID>(animBasejumpToParachute, name: "animBasejumpToParachute");
			speed = s.Serialize<float>(speed, name: "speed");
			speedBasejump = s.Serialize<float>(speedBasejump, name: "speedBasejump");
			distParachute = s.Serialize<float>(distParachute, name: "distParachute");
			parachuteForce = s.Serialize<float>(parachuteForce, name: "parachuteForce");
			lateralForce = s.Serialize<float>(lateralForce, name: "lateralForce");
			intensity = s.Serialize<float>(intensity, name: "intensity");
			frequency = s.Serialize<float>(frequency, name: "frequency");
			windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
			freefallWindMultiplier = s.Serialize<float>(freefallWindMultiplier, name: "freefallWindMultiplier");
			angleRotateMin = s.SerializeObject<Angle>(angleRotateMin, name: "angleRotateMin");
			angleRotateMax = s.SerializeObject<Angle>(angleRotateMax, name: "angleRotateMax");
			actorParachutePath = s.SerializeObject<Path>(actorParachutePath, name: "actorParachutePath");
		}
		public override uint? ClassCRC => 0x9ED56474;
	}
}

