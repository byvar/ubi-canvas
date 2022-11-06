using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class PloufComponent_Template : CSerializable {
		public float waterTime;
		public float ploufAlteration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waterTime = s.Serialize<float>(waterTime, name: "waterTime");
			ploufAlteration = s.Serialize<float>(ploufAlteration, name: "ploufAlteration");
		}
		public override uint? ClassCRC => 0x46841093;
	}
}

