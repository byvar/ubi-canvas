namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterPerturbationComponent_Template : ActorComponent_Template {
		public Path fxFile;
		public float noiseAmplitudeX;
		public float noiseFrequencyX;
		public float noisePersistenceX;
		public uint noiseNbOctaveX;
		public float noiseAmplitudeY;
		public float noiseFrequencyY;
		public float noisePersistenceY;
		public uint noiseNbOctaveY;
		public float noiseTimeMultiplier;
		public float radius;
		public float waterMultiplier;
		public float weight;
		public int queryPosition;
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
			queryPosition = s.Serialize<int>(queryPosition, name: "queryPosition");
		}
		public override uint? ClassCRC => 0x167BF2CB;
	}
}

