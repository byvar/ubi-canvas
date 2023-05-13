namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class PlayerNumberBusMix : CSerializable {
		public uint playerMin;
		public uint playerMax;
		public BusMix mix;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerMin = s.Serialize<uint>(playerMin, name: "playerMin");
			playerMax = s.Serialize<uint>(playerMax, name: "playerMax");
			mix = s.SerializeObject<BusMix>(mix, name: "mix");
		}
	}
}

