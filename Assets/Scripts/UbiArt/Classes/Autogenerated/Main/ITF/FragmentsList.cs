using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class FragmentsList : CSerializable {
		public CListP<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fragments = s.SerializeObject<CListP<uint>>(fragments, name: "fragments");
		}
	}
}

