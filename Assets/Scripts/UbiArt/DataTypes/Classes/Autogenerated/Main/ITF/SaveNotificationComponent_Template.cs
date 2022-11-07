namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class SaveNotificationComponent_Template : ActorComponent_Template {
		public float minDisplayingTime;
		public Vec2d relativepos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minDisplayingTime = s.Serialize<float>(minDisplayingTime, name: "minDisplayingTime");
			relativepos = s.SerializeObject<Vec2d>(relativepos, name: "relativepos");
		}
		public override uint? ClassCRC => 0x1D847FCF;
	}
}

