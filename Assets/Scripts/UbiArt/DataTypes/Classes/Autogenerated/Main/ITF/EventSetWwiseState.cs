namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class EventSetWwiseState : Event {
		public StringID WwiseStateGroupGUID;
		public StringID WwiseStateGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseStateGroupGUID = s.SerializeObject<StringID>(WwiseStateGroupGUID, name: "WwiseStateGroupGUID");
			WwiseStateGUID = s.SerializeObject<StringID>(WwiseStateGUID, name: "WwiseStateGUID");
		}
		public override uint? ClassCRC => 0xC7DCAC11;
	}
}

