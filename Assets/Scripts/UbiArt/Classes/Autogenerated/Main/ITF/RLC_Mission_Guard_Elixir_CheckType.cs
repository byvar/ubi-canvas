using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Elixir_CheckType : RLC_Mission_Guard {
		[Serialize("elixirType")] public uint elixirType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elixirType));
		}
		public override uint? ClassCRC => 0x5CE246BC;
	}
}

