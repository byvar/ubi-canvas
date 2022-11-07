namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WheelPuzzleComponent : CSerializable {
		public int initValue;
		public int maxValue;
		public bool sendTrigger;
		public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			initValue = s.Serialize<int>(initValue, name: "initValue");
			maxValue = s.Serialize<int>(maxValue, name: "maxValue");
			sendTrigger = s.Serialize<bool>(sendTrigger, name: "sendTrigger", options: CSerializerObject.Options.BoolAsByte);
			loop = s.Serialize<bool>(loop, name: "loop", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x2589E705;
	}
}

