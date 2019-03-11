using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FragmentsList : CSerializable {
		[Serialize("fragments")] public CArray<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fragments));
		}
	}
}

