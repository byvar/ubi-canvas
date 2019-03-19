using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightMessageIcon_Template : CSerializable {
		[Serialize("transitionTime")] public float transitionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(transitionTime));
		}
		public override uint? ClassCRC => 0x21AEE445;
	}
}

