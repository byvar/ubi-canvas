using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventActivateComponent : Event {
		public bool active;
		public CListO<EventActivateComponent.sComponentName> SpecificComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			active = s.Serialize<bool>(active, name: "active");
			SpecificComponents = s.SerializeObject<CListO<EventActivateComponent.sComponentName>>(SpecificComponents, name: "SpecificComponents");
		}
		[Games(GameFlags.RA)]
		public partial class sComponentName : CSerializable {
			public StringID ComponentCRC;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				ComponentCRC = s.SerializeObject<StringID>(ComponentCRC, name: "ComponentCRC");
			}
		}
		public override uint? ClassCRC => 0x65D8C476;
	}
}

