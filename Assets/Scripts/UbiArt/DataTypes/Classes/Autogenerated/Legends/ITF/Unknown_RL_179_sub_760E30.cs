namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_179_sub_760E30 : ActorComponent {
		public int initLeftDoorOpened;
		public int initRightDoorOpened;
		public DoorState doorStateCurrent0;
		public DoorState doorStateTarget0;
		public float doorStateCursor0;
		public DoorState doorStateCurrent1;
		public DoorState doorStateTarget1;
		public float doorStateCursor1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			initLeftDoorOpened = s.Serialize<int>(initLeftDoorOpened, name: "initLeftDoorOpened");
			initRightDoorOpened = s.Serialize<int>(initRightDoorOpened, name: "initRightDoorOpened");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				doorStateCurrent0 = s.Serialize<DoorState>(doorStateCurrent0, name: "doorStateCurrent0");
				doorStateTarget0 = s.Serialize<DoorState>(doorStateTarget0, name: "doorStateTarget0");
				doorStateCursor0 = s.Serialize<float>(doorStateCursor0, name: "doorStateCursor0");
				doorStateCurrent1 = s.Serialize<DoorState>(doorStateCurrent1, name: "doorStateCurrent1");
				doorStateTarget1 = s.Serialize<DoorState>(doorStateTarget1, name: "doorStateTarget1");
				doorStateCursor1 = s.Serialize<float>(doorStateCursor1, name: "doorStateCursor1");
			}
		}
		public enum DoorState {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xB7898B2D;
	}
}

