using UnityEngine;

namespace UbiArt.ITF {
	public partial class RedirectPatchBank_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("banks")] public BankChange_TemplateList banks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(banks));
		}
		public override uint? ClassCRC => 0x9099B849;
	}
}

