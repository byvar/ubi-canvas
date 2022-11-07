namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionActivateActor_Template : CSerializable {
		public Placeholder Id;
		public int activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Id = s.SerializeObject<Placeholder>(Id, name: "Id");
			activate = s.Serialize<int>(activate, name: "activate");
		}
		public override uint? ClassCRC => 0x512A1BA6;
	}
}

