using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolyPointList : CSerializable {
		[Serialize("LocalPoints")] public CList<PolyLineEdge> LocalPoints;
		[Serialize("Loop"       )] public bool Loop;
		[Serialize("Length"     )] public float Length;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LocalPoints));
			SerializeField(s, nameof(Loop));
			if (s.HasFlags(SerializeFlags.Flags10)) {
				SerializeField(s, nameof(Length));
			}
		}
	}
}

