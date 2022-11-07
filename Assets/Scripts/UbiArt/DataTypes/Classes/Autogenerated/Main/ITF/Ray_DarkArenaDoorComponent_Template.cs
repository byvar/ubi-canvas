namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkArenaDoorComponent_Template : Ray_DarktoonTrapHoleComponent_Template {
		public StringID hitAnim;
		public StringID idleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
		}
		public override uint? ClassCRC => 0x1B483F47;
	}
}

