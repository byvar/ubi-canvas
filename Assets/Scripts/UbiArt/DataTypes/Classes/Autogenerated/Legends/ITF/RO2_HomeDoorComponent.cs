namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeDoorComponent : CSerializable {
		public Enum_neededInput neededInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			neededInput = s.Serialize<Enum_neededInput>(neededInput, name: "neededInput");
		}
		public enum Enum_neededInput {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x98398617;
	}
}

