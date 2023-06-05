namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeDoorComponent : CSerializable {
		public InputTrigger neededInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			neededInput = s.Serialize<InputTrigger>(neededInput, name: "neededInput");
		}
		public enum InputTrigger {
			[Serialize("InputTrigger_None")] None = 0,
			[Serialize("InputTrigger_Up"  )] Up = 1,
			[Serialize("InputTrigger_Down")] Down = 2,
		}
		public override uint? ClassCRC => 0x98398617;
	}
}

