using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventQueryHunterNode : Event {
		[Serialize("flip"              )] public bool flip;
		[Serialize("isHole"            )] public bool isHole;
		[Serialize("numBulletsPerCycle")] public uint numBulletsPerCycle;
		[Serialize("numCycles"         )] public uint numCycles;
		[Serialize("index"             )] public uint index;
		[Serialize("finishRadius"      )] public float finishRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flip));
			SerializeField(s, nameof(isHole));
			SerializeField(s, nameof(numBulletsPerCycle));
			SerializeField(s, nameof(numCycles));
			SerializeField(s, nameof(index));
			SerializeField(s, nameof(finishRadius));
		}
		public override uint? ClassCRC => 0x0C89BCF3;
	}
}

