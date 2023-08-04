namespace UbiArt {
	public class Volume : ICSerializable {
		public float volume;

		public void Serialize(CSerializerObject s, string name) {
			/*Debug.LogError(s.Position + ": Figure out Volume format");
			throw new Exception(s.Position + ": Figure out Volume format");*/
			volume = s.Serialize<float>(volume);
		}

		public Volume() { }
		public Volume(float volume) { this.volume = volume; }

		public override string ToString() {
			return $"Volume({volume})";
		}
	}
}
