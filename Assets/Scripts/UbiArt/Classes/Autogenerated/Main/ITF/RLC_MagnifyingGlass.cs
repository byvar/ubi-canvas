using System;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_MagnifyingGlass : CSerializable {
		[Serialize("WeightValues")] public CList<Pair<uint, float>> WeightValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WeightValues));
		}
		public override uint? ClassCRC => 0xC7FB20C3;
	}
}

