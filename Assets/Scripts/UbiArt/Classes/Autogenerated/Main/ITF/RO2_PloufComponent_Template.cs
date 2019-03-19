using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PloufComponent_Template : ActorComponent_Template {
		[Serialize("waterTime"      )] public float waterTime;
		[Serialize("ploufAlteration")] public float ploufAlteration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waterTime));
			SerializeField(s, nameof(ploufAlteration));
		}
		public override uint? ClassCRC => 0xF60E18A8;
	}
}

