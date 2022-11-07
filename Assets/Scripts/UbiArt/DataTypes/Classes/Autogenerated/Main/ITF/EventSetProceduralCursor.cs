namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventSetProceduralCursor : Event {
		public float proceduralCursor;
		public StringID animName;
		public bool isAdditive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			proceduralCursor = s.Serialize<float>(proceduralCursor, name: "proceduralCursor");
			animName = s.SerializeObject<StringID>(animName, name: "animName");
			isAdditive = s.Serialize<bool>(isAdditive, name: "isAdditive");
		}
		public override uint? ClassCRC => 0x884E9D1F;
	}
}

