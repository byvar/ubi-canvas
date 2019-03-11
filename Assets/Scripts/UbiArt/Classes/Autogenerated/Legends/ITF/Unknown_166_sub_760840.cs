using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_166_sub_760840 : CSerializable {
		[Serialize("neededInput")] public Enum_neededInput neededInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(neededInput));
		}
		public enum Enum_neededInput {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x98398617;
	}
}

