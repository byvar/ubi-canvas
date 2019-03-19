using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AllElixirPack : RLC_DynamicStoreItem {
		[Serialize("Price"      )] public uint Price;
		[Serialize("elixirPacks")] public CList<RLC_ElixirPack> elixirPacks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(elixirPacks));
		}
		public override uint? ClassCRC => 0x0A5C5981;
	}
}

