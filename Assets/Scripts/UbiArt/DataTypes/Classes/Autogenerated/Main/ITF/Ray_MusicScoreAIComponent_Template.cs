namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MusicScoreAIComponent_Template : GraphicComponent_Template {
		public Path texture;
		public float tileLength;
		public float widthStart;
		public float widthBase;
		public float amplitudeSin;
		public float frequencySin;
		public float openingSpeed;
		public int drawUvFromRoot;
		public float intervalNotePNG;
		public StringID openSound;
		public StringID closeSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texture = s.SerializeObject<Path>(texture, name: "texture");
			tileLength = s.Serialize<float>(tileLength, name: "tileLength");
			widthStart = s.Serialize<float>(widthStart, name: "widthStart");
			widthBase = s.Serialize<float>(widthBase, name: "widthBase");
			amplitudeSin = s.Serialize<float>(amplitudeSin, name: "amplitudeSin");
			frequencySin = s.Serialize<float>(frequencySin, name: "frequencySin");
			openingSpeed = s.Serialize<float>(openingSpeed, name: "openingSpeed");
			drawUvFromRoot = s.Serialize<int>(drawUvFromRoot, name: "drawUvFromRoot");
			intervalNotePNG = s.Serialize<float>(intervalNotePNG, name: "intervalNotePNG");
			openSound = s.SerializeObject<StringID>(openSound, name: "openSound");
			closeSound = s.SerializeObject<StringID>(closeSound, name: "closeSound");
		}
		public override uint? ClassCRC => 0xC922A1EE;
	}
}

