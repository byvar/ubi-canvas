namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WatchAndDetect_Template : ActorComponent_Template {
		public Path Path__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
		}
		public override uint? ClassCRC => 0x57ABD9C1;
	}
}

