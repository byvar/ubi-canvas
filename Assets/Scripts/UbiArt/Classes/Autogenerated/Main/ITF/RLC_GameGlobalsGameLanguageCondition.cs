using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_GameGlobalsGameLanguageCondition : online.GameGlobalsCondition {
		public uint language;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			language = s.Serialize<uint>(language, name: "language");
		}
		public override uint? ClassCRC => 0x26E1B1D3;
	}
}

