namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventLumsCageColor : Event {
		public bool isRed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isRed = s.Serialize<bool>(isRed, name: "isRed");
		}
		public override uint? ClassCRC => 0x8BFB1E0E;
	}
}

