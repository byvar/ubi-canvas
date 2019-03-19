using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EyeDoorComponent_Template : RO2_DoorComponent_Template {
		[Serialize("eyePath"   )] public Path eyePath;
		[Serialize("eyePoly"   )] public StringID eyePoly;
		[Serialize("eyeZOffset")] public float eyeZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eyePath));
			SerializeField(s, nameof(eyePoly));
			SerializeField(s, nameof(eyeZOffset));
		}
		public override uint? ClassCRC => 0x9D0BFE2A;
	}
}

