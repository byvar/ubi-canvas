namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpikyFlowerComponent_Template : ActorComponent_Template {
		public Path hurtTriggerBounce;
		public Path noHurtTriggerBounce;
		public float closedTime = 1f;
		public uint hurtLevel;
		public BOUNCETYPE bounceType = BOUNCETYPE.ENEMY;
		public bool bounceIsRadial;
		public bool useActorPosForBounce = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hurtTriggerBounce = s.SerializeObject<Path>(hurtTriggerBounce, name: "hurtTriggerBounce");
			noHurtTriggerBounce = s.SerializeObject<Path>(noHurtTriggerBounce, name: "noHurtTriggerBounce");
			closedTime = s.Serialize<float>(closedTime, name: "closedTime");
			hurtLevel = s.Serialize<uint>(hurtLevel, name: "hurtLevel");
			bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
			bounceIsRadial = s.Serialize<bool>(bounceIsRadial, name: "bounceIsRadial");
			useActorPosForBounce = s.Serialize<bool>(useActorPosForBounce, name: "useActorPosForBounce");
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public override uint? ClassCRC => 0xE338FAB2;
	}
}

