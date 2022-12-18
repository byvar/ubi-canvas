namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GameObjectComponent_Template : CSerializable {
		public uint networkDT;
		public uint networkUpdateSleepTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			networkDT = s.Serialize<uint>(networkDT, name: "networkDT");
			networkUpdateSleepTime = s.Serialize<uint>(networkUpdateSleepTime, name: "networkUpdateSleepTime");
		}
		public override uint? ClassCRC => 0xA26D279A;
	}
}

