using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventActivateComponent : Event {
		[Serialize("active"            )] public bool active;
		[Serialize("SpecificComponents")] public CList<EventActivateComponent.sComponentName> SpecificComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(active));
			SerializeField(s, nameof(SpecificComponents));
		}
		public partial class sComponentName : CSerializable {
			[Serialize("ComponentCRC")] public StringID ComponentCRC;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(ComponentCRC));
			}
		}
		public override uint? ClassCRC => 0x65D8C476;
	}
}

