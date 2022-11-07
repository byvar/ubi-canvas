namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_12955_sub_591530 : CSerializable {
		public Path file;
		public float volume;
		public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			file = s.SerializeObject<Path>(file, name: "file");
			volume = s.Serialize<float>(volume, name: "volume");
			delay = s.Serialize<float>(delay, name: "delay");
		}
	}
}
