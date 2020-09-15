using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_FragmentsList : CSerializable {
		public CArray<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fragments = s.SerializeObject<CArray<uint>>(fragments, name: "fragments");
		}
	}
}

