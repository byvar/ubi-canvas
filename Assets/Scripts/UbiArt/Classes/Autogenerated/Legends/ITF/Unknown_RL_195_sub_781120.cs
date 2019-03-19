using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_195_sub_781120 : CSerializable {
		[Serialize("isTrapped"     )] public int isTrapped;
		[Serialize("DRCTriggerPath")] public Path DRCTriggerPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isTrapped));
			SerializeField(s, nameof(DRCTriggerPath));
		}
		public override uint? ClassCRC => 0xC62AF726;
	}
}

