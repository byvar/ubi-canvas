using UnityEngine;

namespace UbiArt.ITF {
	public partial class InputConverterComponent : ActorComponent {
		[Serialize("inputToListen")] public StringID inputToListen;
		[Serialize("conversion"   )] public Enum_conversion conversion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(inputToListen));
				SerializeField(s, nameof(conversion));
			}
		}
		public enum Enum_conversion {
			[Serialize("Conversion_SetAlpha")] Conversion_SetAlpha = 0,
		}
		public override uint? ClassCRC => 0x44114699;
	}
}

