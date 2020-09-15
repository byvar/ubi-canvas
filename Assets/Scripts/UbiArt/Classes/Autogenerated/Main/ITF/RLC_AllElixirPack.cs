using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AllElixirPack : RLC_DynamicStoreItem {
		public uint Price;
		public CList<RLC_ElixirPack> elixirPacks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<uint>(Price, name: "Price");
			elixirPacks = s.SerializeObject<CList<RLC_ElixirPack>>(elixirPacks, name: "elixirPacks");
		}
		public override uint? ClassCRC => 0x0A5C5981;
	}
}

