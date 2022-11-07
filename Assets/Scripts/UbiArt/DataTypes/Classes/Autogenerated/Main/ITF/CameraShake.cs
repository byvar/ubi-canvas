namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class CameraShake : CSerializable {
		public StringID name;
		public float intensity;
		public float duration;
		public float easeInDuration;
		public float easeOutDuration;
		public CameraShakeCurveParams shakeX;
		public CameraShakeCurveParams shakeY;
		public CameraShakeCurveParams shakeZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			intensity = s.Serialize<float>(intensity, name: "intensity");
			duration = s.Serialize<float>(duration, name: "duration");
			easeInDuration = s.Serialize<float>(easeInDuration, name: "easeInDuration");
			easeOutDuration = s.Serialize<float>(easeOutDuration, name: "easeOutDuration");
			shakeX = s.SerializeObject<CameraShakeCurveParams>(shakeX, name: "shakeX");
			shakeY = s.SerializeObject<CameraShakeCurveParams>(shakeY, name: "shakeY");
			shakeZ = s.SerializeObject<CameraShakeCurveParams>(shakeZ, name: "shakeZ");
		}
	}
}

