namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TimeSavingPack : RLC_DynamicStoreItem {
		public uint offerIndex;
		public online.TimeInterval timeSavingDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offerIndex = s.Serialize<uint>(offerIndex, name: "offerIndex");
			timeSavingDuration = s.SerializeObject<online.TimeInterval>(timeSavingDuration, name: "timeSavingDuration");
		}
		public override uint? ClassCRC => 0x2A9A352A;
	}
}

