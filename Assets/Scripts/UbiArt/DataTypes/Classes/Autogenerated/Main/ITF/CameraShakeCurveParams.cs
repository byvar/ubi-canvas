namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class CameraShakeCurveParams : BaseCurveParams {
		public float frequency;
		public float amplitude;
		public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frequency = s.Serialize<float>(frequency, name: "frequency");
			amplitude = s.Serialize<float>(amplitude, name: "amplitude");
			offset = s.Serialize<float>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0xC2243BF4;
	}
}

