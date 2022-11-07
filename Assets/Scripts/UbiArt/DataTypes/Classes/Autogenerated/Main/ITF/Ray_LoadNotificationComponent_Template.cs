namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LoadNotificationComponent_Template : ActorComponent_Template {
		public Vec2d animSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
		}
		public override uint? ClassCRC => 0xD01F204E;
	}
}

