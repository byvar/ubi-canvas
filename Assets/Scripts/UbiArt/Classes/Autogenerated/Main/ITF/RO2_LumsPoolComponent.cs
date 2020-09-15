using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumsPoolComponent : ActorComponent {
		public uint LumsMaxNb;
		public bool AllAtStart;
		public RO2_LumsPoolSimulation LumsSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LumsMaxNb = s.Serialize<uint>(LumsMaxNb, name: "LumsMaxNb");
			AllAtStart = s.Serialize<bool>(AllAtStart, name: "AllAtStart");
			LumsSimulation = s.SerializeObject<RO2_LumsPoolSimulation>(LumsSimulation, name: "LumsSimulation");
		}
		public override uint? ClassCRC => 0x4BAB11A6;
	}
}

