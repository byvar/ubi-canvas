using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionRescuedDisappear_Template : BTAction_Template {
		[Serialize("happyAnim")] public StringID happyAnim;
		[Serialize("spawnFX"  )] public Path spawnFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(happyAnim));
			SerializeField(s, nameof(spawnFX));
		}
		public override uint? ClassCRC => 0xA52CAE49;
	}
}

