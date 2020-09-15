using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class FragmentsList : CSerializable {
		public CList<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fragments = s.SerializeObject<CList<uint>>(fragments, name: "fragments");
		}
	}
}

