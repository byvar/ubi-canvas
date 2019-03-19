using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class PloufComponent_Template : CSerializable {
		[Serialize("waterTime"      )] public float waterTime;
		[Serialize("ploufAlteration")] public float ploufAlteration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waterTime));
			SerializeField(s, nameof(ploufAlteration));
		}
		public override uint? ClassCRC => 0x55DE8D99;
	}
}

