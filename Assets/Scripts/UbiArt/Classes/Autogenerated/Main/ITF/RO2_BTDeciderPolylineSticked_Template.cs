using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTDeciderPolylineSticked_Template : BTDecider_Template {
		[Serialize("sticked")] public bool sticked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sticked));
		}
		public override uint? ClassCRC => 0x43861DF9;
	}
}

