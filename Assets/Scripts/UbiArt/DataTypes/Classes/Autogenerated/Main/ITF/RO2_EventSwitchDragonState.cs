namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventSwitchDragonState : Event {
		public uint DragonState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DragonState = s.Serialize<uint>(DragonState, name: "DragonState");
		}
		public override uint? ClassCRC => 0x967EE149;
	}
}

