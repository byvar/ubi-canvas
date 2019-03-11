using UnityEngine;

namespace UbiArt.ITF {
	public partial class ArenaDoorComponent_Template : ActorComponent_Template {
		[Serialize("openAnim")] public StringID openAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openAnim));
		}
		public override uint? ClassCRC => 0xCDC36415;
	}
}

