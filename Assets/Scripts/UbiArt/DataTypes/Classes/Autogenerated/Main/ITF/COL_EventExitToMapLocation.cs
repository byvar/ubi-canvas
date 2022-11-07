namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventExitToMapLocation : Event {
		public bool unlock;
		public StringID mapLocationId;
		public PathRef mapPath;
		public uint checkpointIndex;
		public Placeholder checkpointObjectId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unlock = s.Serialize<bool>(unlock, name: "unlock", options: CSerializerObject.Options.BoolAsByte);
			mapLocationId = s.SerializeObject<StringID>(mapLocationId, name: "mapLocationId");
			mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
			checkpointIndex = s.Serialize<uint>(checkpointIndex, name: "checkpointIndex");
			checkpointObjectId = s.SerializeObject<Placeholder>(checkpointObjectId, name: "checkpointObjectId");
		}
		public override uint? ClassCRC => 0x8FEDB2CD;
	}
}

