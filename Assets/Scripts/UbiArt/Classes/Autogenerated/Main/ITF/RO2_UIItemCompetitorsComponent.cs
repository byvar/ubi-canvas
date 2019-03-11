using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_UIItemCompetitorsComponent : UIComponent {
		[Serialize("firstPlayerOffset")] public float firstPlayerOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(firstPlayerOffset));
		}
		public override uint? ClassCRC => 0xCB815F05;
	}
}

