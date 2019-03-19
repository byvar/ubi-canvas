using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSetCurrentObjective_Template : CSerializable {
		[Serialize("objective")] public Placeholder objective;
		[Serialize("primary"  )] public bool primary;
		[Serialize("reset"    )] public bool reset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(objective));
			SerializeField(s, nameof(primary), boolAsByte: true);
			SerializeField(s, nameof(reset), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xE356C1F4;
	}
}

