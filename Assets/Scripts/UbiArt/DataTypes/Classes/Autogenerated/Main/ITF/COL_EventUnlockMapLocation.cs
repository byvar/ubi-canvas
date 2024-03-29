namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventUnlockMapLocation : Event {
		public StringID mapLocationId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapLocationId = s.SerializeObject<StringID>(mapLocationId, name: "mapLocationId");
		}
		public override uint? ClassCRC => 0xB676855D;
	}
}

