using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_341_sub_ACC0F0 : CSerializable {
		[Serialize("gravityMultiplier")] public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityMultiplier));
		}
		public override uint? ClassCRC => 0x4A1E5871;
	}
}

