using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class InputConverterComponent : ActorComponent {
		public StringID inputToListen;
		public Enum_conversion conversion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				inputToListen = s.SerializeObject<StringID>(inputToListen, name: "inputToListen");
				conversion = s.Serialize<Enum_conversion>(conversion, name: "conversion");
			}
		}
		public enum Enum_conversion {
			[Serialize("Conversion_SetAlpha")] Conversion_SetAlpha = 0,
		}
		public override uint? ClassCRC => 0x44114699;
	}
}

