namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionBlowing_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public bool blowingUp = true;
		public bool modeAuto;
		public float blowingTime = 2f;
		public float coolDown = 2f;
		public StringID animStand;
		public StringID animAnticip;
		public StringID animLoop;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			blowingUp = s.Serialize<bool>(blowingUp, name: "blowingUp");
			modeAuto = s.Serialize<bool>(modeAuto, name: "modeAuto");
			blowingTime = s.Serialize<float>(blowingTime, name: "blowingTime");
			coolDown = s.Serialize<float>(coolDown, name: "coolDown");
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animAnticip = s.SerializeObject<StringID>(animAnticip, name: "animAnticip");
			animLoop = s.SerializeObject<StringID>(animLoop, name: "animLoop");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0x0E306971;
	}
}

