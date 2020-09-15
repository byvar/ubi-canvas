using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsComponent : ActorComponent {
		public uint lumsGiven;
		public bool needActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumsGiven = s.Serialize<uint>(lumsGiven, name: "lumsGiven");
			needActivation = s.Serialize<bool>(needActivation, name: "needActivation");
		}
		public override uint? ClassCRC => 0x72C8CA61;
	}
}

