namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventSyncActorUpdate : Event {
		public bool wantFreeze;
		public uint startAtFrame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wantFreeze = s.Serialize<bool>(wantFreeze, name: "wantFreeze");
			startAtFrame = s.Serialize<uint>(startAtFrame, name: "startAtFrame");
		}
		public override uint? ClassCRC => 0x001A132B;
	}
}

