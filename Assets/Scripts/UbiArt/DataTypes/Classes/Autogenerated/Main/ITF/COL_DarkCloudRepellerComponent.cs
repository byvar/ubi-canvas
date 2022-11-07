namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudRepellerComponent : CSerializable {
		public float radiusMax;
		public float radiusMin;
		public float cycleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radiusMax = s.Serialize<float>(radiusMax, name: "radiusMax");
			radiusMin = s.Serialize<float>(radiusMin, name: "radiusMin");
			cycleDuration = s.Serialize<float>(cycleDuration, name: "cycleDuration");
		}
		public override uint? ClassCRC => 0x706A533D;
	}
}

