namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TextAnimScaleComponent_Template : ActorComponent_Template {
		public Vec2d baseSize;
		public Vec2d baseSizeMax;
		public Vec2d margeSize;
		public StringID animInputX;
		public StringID animInputY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			baseSize = s.SerializeObject<Vec2d>(baseSize, name: "baseSize");
			baseSizeMax = s.SerializeObject<Vec2d>(baseSizeMax, name: "baseSizeMax");
			margeSize = s.SerializeObject<Vec2d>(margeSize, name: "margeSize");
			animInputX = s.SerializeObject<StringID>(animInputX, name: "animInputX");
			animInputY = s.SerializeObject<StringID>(animInputY, name: "animInputY");
		}
		public override uint? ClassCRC => 0xFDE11D09;
	}
}

