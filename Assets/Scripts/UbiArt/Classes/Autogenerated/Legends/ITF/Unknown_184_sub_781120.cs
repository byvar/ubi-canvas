using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_184_sub_781120 : CSerializable {
		[Serialize("isTrapped"     )] public bool isTrapped;
		[Serialize("DRCTriggerPath")] public Path DRCTriggerPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isTrapped));
			SerializeField(s, nameof(DRCTriggerPath));
		}
		public override uint? ClassCRC => 0xC62AF726;
	}
}

