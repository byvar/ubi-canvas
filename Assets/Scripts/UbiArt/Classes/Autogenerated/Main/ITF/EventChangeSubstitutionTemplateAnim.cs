using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventChangeSubstitutionTemplateAnim : Event {
		[Serialize("set"            )] public bool set;
		[Serialize("templateIdToSet")] public uint templateIdToSet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(set));
			SerializeField(s, nameof(templateIdToSet));
		}
		public override uint? ClassCRC => 0x547A1E5B;
	}
}

