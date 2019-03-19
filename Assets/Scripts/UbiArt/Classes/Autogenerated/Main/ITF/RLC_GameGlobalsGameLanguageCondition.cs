using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsGameLanguageCondition : online.GameGlobalsCondition {
		[Serialize("language")] public uint language;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(language));
		}
		public override uint? ClassCRC => 0x26E1B1D3;
	}
}

