namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ZeusFingerComponent_Template : ActorComponent_Template {
		public StringID idleAnim;
		public StringID appearAnim;
		public StringID reflexAnim;
		public StringID chargeAnim;
		public StringID shootAnim;
		public StringID disappearAnim;
		public StringID emptyAnim;
		public float shootDuration;
		public bool useShootDuration;
		public float chargeDuration;
		public float disappearDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			reflexAnim = s.SerializeObject<StringID>(reflexAnim, name: "reflexAnim");
			chargeAnim = s.SerializeObject<StringID>(chargeAnim, name: "chargeAnim");
			shootAnim = s.SerializeObject<StringID>(shootAnim, name: "shootAnim");
			disappearAnim = s.SerializeObject<StringID>(disappearAnim, name: "disappearAnim");
			emptyAnim = s.SerializeObject<StringID>(emptyAnim, name: "emptyAnim");
			shootDuration = s.Serialize<float>(shootDuration, name: "shootDuration");
			useShootDuration = s.Serialize<bool>(useShootDuration, name: "useShootDuration");
			chargeDuration = s.Serialize<float>(chargeDuration, name: "chargeDuration");
			disappearDuration = s.Serialize<float>(disappearDuration, name: "disappearDuration");
		}
		public override uint? ClassCRC => 0x718EE3A8;
	}
}

