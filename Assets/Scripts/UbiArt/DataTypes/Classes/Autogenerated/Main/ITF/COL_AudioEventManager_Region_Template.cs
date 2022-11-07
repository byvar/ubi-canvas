namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_Region_Template : CSerializable {
		public StringID regionName;
		public StringID bankGuid;
		public StringID musicStateBattle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			regionName = s.SerializeObject<StringID>(regionName, name: "regionName");
			bankGuid = s.SerializeObject<StringID>(bankGuid, name: "bankGuid");
			musicStateBattle = s.SerializeObject<StringID>(musicStateBattle, name: "musicStateBattle");
		}
		public override uint? ClassCRC => 0x574EA746;
	}
}

