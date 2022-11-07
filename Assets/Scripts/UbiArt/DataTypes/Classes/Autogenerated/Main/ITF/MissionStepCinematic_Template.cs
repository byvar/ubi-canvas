namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCinematic_Template : CSerializable {
		public Placeholder id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<Placeholder>(id, name: "id");
		}
		public override uint? ClassCRC => 0xA239F616;
	}
}

