namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AFX_SinusWaveParam : CSerializable {
		public bool use;
		public float periodX = 500;
		public float periodY = 500;
		public float intensityX = 5;
		public float intensityY = 5;
		public float speed = 0.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			use = s.Serialize<bool>(use, name: "use");
			periodX = s.Serialize<float>(periodX, name: "periodX");
			periodY = s.Serialize<float>(periodY, name: "periodY");
			intensityX = s.Serialize<float>(intensityX, name: "intensityX");
			intensityY = s.Serialize<float>(intensityY, name: "intensityY");
			speed = s.Serialize<float>(speed, name: "speed");
		}
	}
}

