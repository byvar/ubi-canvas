namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class SynchronizedAnimComponent_Template : ActorComponent_Template {
		public StringID inactiveAnim;
		public StringID activeAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inactiveAnim = s.SerializeObject<StringID>(inactiveAnim, name: "inactiveAnim");
			activeAnim = s.SerializeObject<StringID>(activeAnim, name: "activeAnim");
		}
		public override uint? ClassCRC => 0x6BEF11CB;
	}
}

