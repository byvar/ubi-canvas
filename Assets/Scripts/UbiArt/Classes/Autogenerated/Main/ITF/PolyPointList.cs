using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PolyPointList : CSerializable {
		public CList<PolyLineEdge> LocalPoints;
		public bool Loop;
		public float Length;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LocalPoints = s.SerializeObject<CList<PolyLineEdge>>(LocalPoints, name: "LocalPoints");
			Loop = s.Serialize<bool>(Loop, name: "Loop");
			if (s.HasFlags(SerializeFlags.Flags10)) {
				Length = s.Serialize<float>(Length, name: "Length");
			}
		}
	}
}

