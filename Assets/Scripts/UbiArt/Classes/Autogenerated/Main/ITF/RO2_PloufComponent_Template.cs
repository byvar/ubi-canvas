using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PloufComponent_Template : ActorComponent_Template {
		public float waterTime;
		public float ploufAlteration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waterTime = s.Serialize<float>(waterTime, name: "waterTime");
			ploufAlteration = s.Serialize<float>(ploufAlteration, name: "ploufAlteration");
		}
		public override uint? ClassCRC => 0xF60E18A8;
	}
}

