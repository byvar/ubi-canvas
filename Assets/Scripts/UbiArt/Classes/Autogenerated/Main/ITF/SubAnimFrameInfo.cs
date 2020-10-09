using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class SubAnimFrameInfo : CSerializable {
		public int subAnimIndex;
		public float proceduralCursor;
		public float currentPlayRate;
		public float currentTime;
		public bool procedural;
		public bool looped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnimIndex = s.Serialize<int>(subAnimIndex, name: "subAnimIndex");
			proceduralCursor = s.Serialize<float>(proceduralCursor, name: "proceduralCursor");
			currentPlayRate = s.Serialize<float>(currentPlayRate, name: "currentPlayRate");
			currentTime = s.Serialize<float>(currentTime, name: "currentTime");
			procedural = s.Serialize<bool>(procedural, name: "procedural");
			looped = s.Serialize<bool>(looped, name: "looped");
		}
	}
}

