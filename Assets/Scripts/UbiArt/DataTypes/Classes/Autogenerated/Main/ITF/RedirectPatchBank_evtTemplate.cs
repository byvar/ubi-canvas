using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class RedirectPatchBank_evtTemplate : SequenceEventWithActor_Template {
		public BankChange_TemplateList banks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				banks = s.SerializeObject<BankChange_TemplateList>(banks, name: "banks");
			}
		}
		public override uint? ClassCRC => 0x9099B849;
	}
}

