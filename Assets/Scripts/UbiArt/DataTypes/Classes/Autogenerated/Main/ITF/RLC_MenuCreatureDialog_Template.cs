namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_MenuCreatureDialog_Template : UIMenuBasic_Template {
		public Spline SlowDTCurve;
		public Path Gem3DPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SlowDTCurve = s.SerializeObject<Spline>(SlowDTCurve, name: "SlowDTCurve");
			Gem3DPath = s.SerializeObject<Path>(Gem3DPath, name: "Gem3DPath");
		}
		public override uint? ClassCRC => 0x3F805329;
	}
}

