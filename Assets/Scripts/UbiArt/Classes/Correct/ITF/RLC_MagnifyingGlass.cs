using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MagnifyingGlass : CSerializable {
		public CList<Pair<uint, float>> WeightValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WeightValues = s.SerializeObject<CList<Pair<uint, float>>>(WeightValues, name: "WeightValues");
		}
		public override uint? ClassCRC => 0xC7FB20C3;
	}
}

