using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EyeDoorComponent_Template : RO2_DoorComponent_Template {
		public Path eyePath;
		public StringID eyePoly;
		public float eyeZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eyePath = s.SerializeObject<Path>(eyePath, name: "eyePath");
			eyePoly = s.SerializeObject<StringID>(eyePoly, name: "eyePoly");
			eyeZOffset = s.Serialize<float>(eyeZOffset, name: "eyeZOffset");
		}
		public override uint? ClassCRC => 0x9D0BFE2A;
	}
}

