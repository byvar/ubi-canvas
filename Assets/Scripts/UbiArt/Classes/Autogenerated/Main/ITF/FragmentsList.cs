using UnityEngine;

namespace UbiArt.ITF {
	public partial class FragmentsList : CSerializable {
		[Serialize("fragments")] public CList<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fragments));
		}
	}
}

