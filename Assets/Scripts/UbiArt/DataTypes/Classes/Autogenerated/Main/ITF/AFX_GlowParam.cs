namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_GlowParam : CSerializable {
		public bool use;
		public float factor = 1f;
		public float blurSize = 3f;
		public bool bigBlur = true;
		public float threshold;
		public float thresholdSmooth = 1f;	
		public uint pixelSize;
		public uint quality;
		public bool useToneMap;
		public float thresholdScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH || s.Settings.Game == Game.COL || s.Settings.Game == Game.RL) {
				if (s.Settings.Game == Game.COL) {
					use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
				} else {
					use = s.Serialize<bool>(use, name: "use");
				}
				factor = s.Serialize<float>(factor, name: "factor");
				pixelSize = s.Serialize<uint>(pixelSize, name: "pixelSize");
				quality = s.Serialize<uint>(quality, name: "quality");
				useToneMap = s.Serialize<bool>(useToneMap, name: "useToneMap");
				threshold = s.Serialize<float>(threshold, name: "threshold");
				thresholdScale = s.Serialize<float>(thresholdScale, name: "thresholdScale");
			} else {
				use = s.Serialize<bool>(use, name: "use");
				factor = s.Serialize<float>(factor, name: "factor");
				blurSize = s.Serialize<float>(blurSize, name: "blurSize");
				bigBlur = s.Serialize<bool>(bigBlur, name: "bigBlur");
				threshold = s.Serialize<float>(threshold, name: "threshold");
				thresholdSmooth = s.Serialize<float>(thresholdSmooth, name: "thresholdSmooth");
			}
		}
	}
}

