using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCoordinator_Template : CSerializable {
		public StringID coordinatorName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			coordinatorName = s.SerializeObject<StringID>(coordinatorName, name: "coordinatorName");
		}
		public override uint? ClassCRC => 0xB1092FEE;
	}
}

