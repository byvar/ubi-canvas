using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class SubAnimFrameInfo : CSerializable {
		[Serialize("subAnimIndex"    )] public int subAnimIndex;
		[Serialize("proceduralCursor")] public float proceduralCursor;
		[Serialize("currentPlayRate" )] public float currentPlayRate;
		[Serialize("currentTime"     )] public float currentTime;
		[Serialize("procedural"      )] public bool procedural;
		[Serialize("looped"          )] public bool looped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnimIndex));
			SerializeField(s, nameof(proceduralCursor));
			SerializeField(s, nameof(currentPlayRate));
			SerializeField(s, nameof(currentTime));
			SerializeField(s, nameof(procedural));
			SerializeField(s, nameof(looped));
		}
	}
}

