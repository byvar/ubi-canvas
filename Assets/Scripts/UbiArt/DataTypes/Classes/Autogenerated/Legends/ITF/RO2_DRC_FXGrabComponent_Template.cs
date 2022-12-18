namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRC_FXGrabComponent_Template : ActorComponent_Template {
		public StringID fxName;
		public int autoUpdatePos;
		public Vec2d scaleFXGrab;
		public Vec2d offsetFXGrab;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
			autoUpdatePos = s.Serialize<int>(autoUpdatePos, name: "autoUpdatePos");
			scaleFXGrab = s.SerializeObject<Vec2d>(scaleFXGrab, name: "scaleFXGrab");
			offsetFXGrab = s.SerializeObject<Vec2d>(offsetFXGrab, name: "offsetFXGrab");
		}
		public override uint? ClassCRC => 0xAF05B0CD;
	}
}

