namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_LevelPaintingSpawnerComponent_Template : ActorComponent_Template {
		public Path levelPainting;
		public CListO<Path> teensyRecap10;
		public CListO<Path> teensyRecap3;
		public Path levelPaintingH;
		public CListO<Path> teensyRecap10H;
		public CListO<Path> teensyRecap3H;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelPainting = s.SerializeObject<Path>(levelPainting, name: "levelPainting");
			teensyRecap10 = s.SerializeObject<CListO<Path>>(teensyRecap10, name: "teensyRecap10");
			teensyRecap3 = s.SerializeObject<CListO<Path>>(teensyRecap3, name: "teensyRecap3");
			if (s.Settings.Platform != GamePlatform.Vita) {
				levelPaintingH = s.SerializeObject<Path>(levelPaintingH, name: "levelPaintingH");
				teensyRecap10H = s.SerializeObject<CListO<Path>>(teensyRecap10H, name: "teensyRecap10H");
				teensyRecap3H = s.SerializeObject<CListO<Path>>(teensyRecap3H, name: "teensyRecap3H");
			}
		}
		public override uint? ClassCRC => 0x368D19B7;
	}
}

