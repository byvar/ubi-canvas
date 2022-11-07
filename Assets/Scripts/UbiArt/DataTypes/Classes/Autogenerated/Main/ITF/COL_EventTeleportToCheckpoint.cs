namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventTeleportToCheckpoint : Event {
		[Description("ObjectId of the target checkpoint")]
		public Placeholder checkpointObjectId;
		public bool whiteFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			checkpointObjectId = s.SerializeObject<Placeholder>(checkpointObjectId, name: "checkpointObjectId");
			whiteFade = s.Serialize<bool>(whiteFade, name: "whiteFade", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xECBB3974;
	}
}

