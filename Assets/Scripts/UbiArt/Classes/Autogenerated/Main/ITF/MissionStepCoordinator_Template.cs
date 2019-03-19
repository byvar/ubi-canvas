using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCoordinator_Template : CSerializable {
		[Serialize("coordinatorName")] public StringID coordinatorName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(coordinatorName));
		}
		public override uint? ClassCRC => 0x7F982FA2;
	}
}

