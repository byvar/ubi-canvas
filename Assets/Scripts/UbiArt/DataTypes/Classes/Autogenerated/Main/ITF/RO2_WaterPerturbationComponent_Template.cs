namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_WaterPerturbationComponent_Template : ActorComponent_Template {
		public Path fxFile;
		public float noiseAmplitudeX = 2f;
		public float noiseFrequencyX = 1f;
		public float noisePersistenceX = 0.4f;
		public uint noiseNbOctaveX = 4;
		public float noiseAmplitudeY = 1f;
		public float noiseFrequencyY = 1f;
		public float noisePersistenceY = 0.4f;
		public uint noiseNbOctaveY = 4;
		public float noiseTimeMultiplier = 6f;
		public float radius = 1f;
		public float waterMultiplier = 1f;
		public float weight = 1f;
		public bool queryPosition = false;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxFile = s.SerializeObject<Path>(fxFile, name: "fxFile");
			noiseAmplitudeX = s.Serialize<float>(noiseAmplitudeX, name: "noiseAmplitudeX");
			noiseFrequencyX = s.Serialize<float>(noiseFrequencyX, name: "noiseFrequencyX");
			noisePersistenceX = s.Serialize<float>(noisePersistenceX, name: "noisePersistenceX");
			noiseNbOctaveX = s.Serialize<uint>(noiseNbOctaveX, name: "noiseNbOctaveX");
			noiseAmplitudeY = s.Serialize<float>(noiseAmplitudeY, name: "noiseAmplitudeY");
			noiseFrequencyY = s.Serialize<float>(noiseFrequencyY, name: "noiseFrequencyY");
			noisePersistenceY = s.Serialize<float>(noisePersistenceY, name: "noisePersistenceY");
			noiseNbOctaveY = s.Serialize<uint>(noiseNbOctaveY, name: "noiseNbOctaveY");
			noiseTimeMultiplier = s.Serialize<float>(noiseTimeMultiplier, name: "noiseTimeMultiplier");
			radius = s.Serialize<float>(radius, name: "radius");
			waterMultiplier = s.Serialize<float>(waterMultiplier, name: "waterMultiplier");
			weight = s.Serialize<float>(weight, name: "weight");
			queryPosition = s.Serialize<bool>(queryPosition, name: "queryPosition");
		}
		public override uint? ClassCRC => 0x2FA610E3;
	}
}

