using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventQueryHunterNode : Event {
		public int flip;
		public int isHole;
		public uint numBulletsPerCycle;
		public uint numCycles;
		public uint index;
		public float finishRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flip = s.Serialize<int>(flip, name: "flip");
			isHole = s.Serialize<int>(isHole, name: "isHole");
			numBulletsPerCycle = s.Serialize<uint>(numBulletsPerCycle, name: "numBulletsPerCycle");
			numCycles = s.Serialize<uint>(numCycles, name: "numCycles");
			index = s.Serialize<uint>(index, name: "index");
			finishRadius = s.Serialize<float>(finishRadius, name: "finishRadius");
		}
		public override uint? ClassCRC => 0x0C89BCF3;
	}
}

