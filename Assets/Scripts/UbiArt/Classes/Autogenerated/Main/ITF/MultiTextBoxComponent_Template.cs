using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiTextBoxComponent_Template : ActorComponent_Template {
		[Serialize("styles")] public CList<FontTextArea.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(styles));
		}
		public override uint? ClassCRC => 0x732EAD76;
	}
}

