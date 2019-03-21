using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_UIFadeScreenComponent_Template : UIComponent_Template {
		[Serialize("types"   )] public CList<UIFadeEntry> types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(types));
			SerializeField(s, nameof(animSize));
		}
		public override uint? ClassCRC => 0xC7834786;
	}
}

