namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SasComponent : ActorComponent {
		public int initLeftDoorOpened;
		public int initRightDoorOpened;
		public SasDoor doorStateCurrent0;
		public SasDoor doorStateTarget0;
		public float doorStateCursor0;
		public SasDoor doorStateCurrent1;
		public SasDoor doorStateTarget1;
		public float doorStateCursor1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			initLeftDoorOpened = s.Serialize<int>(initLeftDoorOpened, name: "initLeftDoorOpened");
			initRightDoorOpened = s.Serialize<int>(initRightDoorOpened, name: "initRightDoorOpened");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				doorStateCurrent0 = s.Serialize<SasDoor>(doorStateCurrent0, name: "doorStateCurrent0");
				doorStateTarget0 = s.Serialize<SasDoor>(doorStateTarget0, name: "doorStateTarget0");
				doorStateCursor0 = s.Serialize<float>(doorStateCursor0, name: "doorStateCursor0");
				doorStateCurrent1 = s.Serialize<SasDoor>(doorStateCurrent1, name: "doorStateCurrent1");
				doorStateTarget1 = s.Serialize<SasDoor>(doorStateTarget1, name: "doorStateTarget1");
				doorStateCursor1 = s.Serialize<float>(doorStateCursor1, name: "doorStateCursor1");
			}
		}
		public enum SasDoor {
			[Serialize("SasDoor_Opened"  )] Opened = 0,
			[Serialize("SasDoor_Closed"  )] Closed = 1,
			[Serialize("SasDoor_Openning")] Openning = 2,
			[Serialize("SasDoor_Closing" )] Closing = 3,
		}
		public override uint? ClassCRC => 0xB7898B2D;
	}
}

