using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_195_sub_781120 : CSerializable {
		public int isTrapped;
		public Path DRCTriggerPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isTrapped = s.Serialize<int>(isTrapped, name: "isTrapped");
			DRCTriggerPath = s.SerializeObject<Path>(DRCTriggerPath, name: "DRCTriggerPath");
		}
		public override uint? ClassCRC => 0xC62AF726;
	}
}

