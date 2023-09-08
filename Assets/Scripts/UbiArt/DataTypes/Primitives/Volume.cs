namespace UbiArt {
	public class Volume : ICSerializable {
		public float volumeFactor { // Used by RAKI: Origins version
			get => System.MathF.Pow(10f, volumeDB / 20f);
			set => volumeDB = 20f * System.MathF.Log10(value);
		}
		public float volumeDB; // Used by RAKI: Legends version

		public void Serialize(CSerializerObject s, string name) {
			/*Debug.LogError(s.Position + ": Figure out Volume format");
			throw new Exception(s.Position + ": Figure out Volume format");*/
			if (s.Settings.EngineVersion < EngineVersion.RL) {
				volumeFactor = s.Serialize<float>(volumeFactor);
			} else {
				volumeDB = s.Serialize<float>(volumeDB);
			}
		}

		public Volume() { }
		public Volume(float volumeDB) { this.volumeDB = volumeDB; }

		public override string ToString() {
			return $"Volume({volumeDB}dB, {volumeFactor*100f}%)";
		}
	}
}
