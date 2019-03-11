using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuSoundComponent_Template : ActorComponent_Template {
		[Serialize("pageConfigList")] public CList<UIMenuPageSoundConfig> pageConfigList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pageConfigList));
		}
		public override uint? ClassCRC => 0x1C3ACDE0;
	}
}

