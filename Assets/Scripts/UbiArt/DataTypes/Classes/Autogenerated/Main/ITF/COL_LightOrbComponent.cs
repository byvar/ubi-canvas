namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbComponent : CSerializable {
		public float orbCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			orbCount = s.Serialize<float>(orbCount, name: "orbCount");
		}
		public override uint? ClassCRC => 0xA5478EE5;
	}
}

