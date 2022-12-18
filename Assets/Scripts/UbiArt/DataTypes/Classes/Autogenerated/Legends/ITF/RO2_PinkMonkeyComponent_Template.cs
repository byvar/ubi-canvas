namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PinkMonkeyComponent_Template : ActorComponent_Template {
		public StringID launchBone;
		public float launchZOffset;
		public int launchInRootScene;
		public StringID standAnim;
		public StringID fireAnim;
		public StringID runAnim;
		public char MonkeyType;
		public Vec2d initialSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			launchBone = s.SerializeObject<StringID>(launchBone, name: "launchBone");
			launchZOffset = s.Serialize<float>(launchZOffset, name: "launchZOffset");
			launchInRootScene = s.Serialize<int>(launchInRootScene, name: "launchInRootScene");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			fireAnim = s.SerializeObject<StringID>(fireAnim, name: "fireAnim");
			runAnim = s.SerializeObject<StringID>(runAnim, name: "runAnim");
			MonkeyType = s.Serialize<char>(MonkeyType, name: "MonkeyType");
			initialSpeed = s.SerializeObject<Vec2d>(initialSpeed, name: "initialSpeed");
		}
		public override uint? ClassCRC => 0xD07942D4;
	}
}

