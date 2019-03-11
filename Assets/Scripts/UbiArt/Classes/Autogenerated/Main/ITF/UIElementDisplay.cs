using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIElementDisplay : Event {
		[Serialize("elementName")] public StringID elementName;
		[Serialize("display"    )] public bool display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elementName));
			SerializeField(s, nameof(display));
		}
		public override uint? ClassCRC => 0x3251B708;
	}
}

