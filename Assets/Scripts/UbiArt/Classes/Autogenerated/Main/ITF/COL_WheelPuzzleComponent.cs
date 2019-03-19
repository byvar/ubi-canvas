using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WheelPuzzleComponent : CSerializable {
		[Serialize("initValue"  )] public int initValue;
		[Serialize("maxValue"   )] public int maxValue;
		[Serialize("sendTrigger")] public bool sendTrigger;
		[Serialize("loop"       )] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(initValue));
			SerializeField(s, nameof(maxValue));
			SerializeField(s, nameof(sendTrigger), boolAsByte: true);
			SerializeField(s, nameof(loop), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x2589E705;
	}
}

