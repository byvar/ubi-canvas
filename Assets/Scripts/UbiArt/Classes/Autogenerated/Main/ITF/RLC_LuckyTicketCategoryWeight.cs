using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketCategoryWeight : CSerializable {
		[Serialize("category")] public Enum_category category;
		[Serialize("weight"  )] public uint weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(category));
			SerializeField(s, nameof(weight));
		}
		public enum Enum_category {
			[Serialize("Normal" )] Normal = 0,
			[Serialize("Jackpot")] Jackpot = 1,
			[Serialize("Egg"    )] Egg = 2,
		}
	}
}

