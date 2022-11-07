namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PushButtonComponent : CSerializable {
		public uint activator;
		public Enum_triggerCount triggerCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activator = s.Serialize<uint>(activator, name: "activator");
				triggerCount = s.Serialize<Enum_triggerCount>(triggerCount, name: "triggerCount");
			}
		}
		public enum Enum_triggerCount {
		}
		public override uint? ClassCRC => 0x85C4E907;
	}
}

