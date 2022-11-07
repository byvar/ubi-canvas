namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCoordinatorEvent : CSerializable {
		public uint sender;
		public int completed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
			completed = s.Serialize<int>(completed, name: "completed");
		}
		public override uint? ClassCRC => 0x872B4A68;
	}
}

