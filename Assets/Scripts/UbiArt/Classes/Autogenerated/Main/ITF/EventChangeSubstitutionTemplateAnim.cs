using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventChangeSubstitutionTemplateAnim : Event {
		public bool set;
		public uint templateIdToSet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			set = s.Serialize<bool>(set, name: "set");
			templateIdToSet = s.Serialize<uint>(templateIdToSet, name: "templateIdToSet");
		}
		public override uint? ClassCRC => 0x547A1E5B;
	}
}

