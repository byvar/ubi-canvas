using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumsPoolComponent : ActorComponent {
		[Serialize("LumsMaxNb"     )] public uint LumsMaxNb;
		[Serialize("AllAtStart"    )] public bool AllAtStart;
		[Serialize("LumsSimulation")] public RO2_LumsPoolSimulation LumsSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LumsMaxNb));
			SerializeField(s, nameof(AllAtStart));
			SerializeField(s, nameof(LumsSimulation));
		}
		public override uint? ClassCRC => 0x4BAB11A6;
	}
}

