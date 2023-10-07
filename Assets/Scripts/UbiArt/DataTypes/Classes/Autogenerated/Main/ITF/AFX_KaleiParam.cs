namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_KaleiParam : CSerializable {
		public bool use;
		public float pixelSize = 1f;
		public Vec2d UV1 = new Vec2d(0,1);
		public Vec2d UV2 = new Vec2d(1,1);
		public Vec2d UV3 = new Vec2d(1,0);
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			pixelSize = s.Serialize<float>(pixelSize, name: "pixelSize");
			UV1 = s.SerializeObject<Vec2d>(UV1, name: "UV1");
			UV2 = s.SerializeObject<Vec2d>(UV2, name: "UV2");
			UV3 = s.SerializeObject<Vec2d>(UV3, name: "UV3");
		}
	}
}

