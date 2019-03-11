using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIFadeScreenComponent_Template : UIComponent_Template {
		[Serialize("types"   )] public CList<UIFadeEntry> types;
		[Serialize("animSize")] public Vector2 animSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(types));
			SerializeField(s, nameof(animSize));
		}
		public override uint? ClassCRC => 0xAD25C355;
	}
}

