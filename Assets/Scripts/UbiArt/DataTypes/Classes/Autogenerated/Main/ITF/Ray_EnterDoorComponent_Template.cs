namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EnterDoorComponent_Template : TriggerComponent_Template {
		public StringID entryPointId;
		public StringID exitPointId;
		public int noEntry;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			entryPointId = s.SerializeObject<StringID>(entryPointId, name: "entryPointId");
			exitPointId = s.SerializeObject<StringID>(exitPointId, name: "exitPointId");
			noEntry = s.Serialize<int>(noEntry, name: "noEntry");
		}
		public override uint? ClassCRC => 0x7A16849A;
	}
}

