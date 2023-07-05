namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PushButtonComponent : ActorComponent {
		public uint activator;
		public uint triggerCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activator = s.Serialize<uint>(activator, name: "activator");
				triggerCount = s.Serialize<uint>(triggerCount, name: "triggerCount");
			}
		}
		public override uint? ClassCRC => 0x85C4E907;
	}
}

