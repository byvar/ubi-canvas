using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_UIFadeScreenComponent_Template : UIComponent_Template {
		[Serialize("types")] public Placeholder types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(types));
		}
		public override uint? ClassCRC => 0xB8D48AC1;
	}
}

