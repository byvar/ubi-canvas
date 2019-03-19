using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RedirectPatchBank_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("banks")] public BankChange_TemplateList banks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(banks));
			}
		}
		public override uint? ClassCRC => 0x9099B849;
	}
}

