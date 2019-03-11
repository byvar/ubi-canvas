using UnityEngine;

namespace UbiArt.ITF {
	public partial class MonologComponent : DialogBaseComponent {
		[Serialize("textID")] public Enum_textID textID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(textID));
			}
		}
		public enum Enum_textID {
			[Serialize("invalid")] invalid = LocalisationId.Invalid,
		}
		public override uint? ClassCRC => 0x0DB39EE4;
	}
}

