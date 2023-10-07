namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_RadialParam : CSerializable {
		public bool use;
		public Vec2d centerOffset;
		public float strength = 1f;
		public float size = 10f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			centerOffset = s.SerializeObject<Vec2d>(centerOffset, name: "centerOffset");
			strength = s.Serialize<float>(strength, name: "strength");
			size = s.Serialize<float>(size, name: "size");
		}
	}
}

