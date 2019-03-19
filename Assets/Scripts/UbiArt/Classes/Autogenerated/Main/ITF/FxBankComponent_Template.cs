using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class FxBankComponent_Template : GraphicComponent_Template {
		[Serialize("Fx"                             )] public CList<FxDescriptor_Template> Fx;
		[Serialize("inputs"                         )] public CList<InputDesc> inputs;
		[Serialize("visibilityTest"                 )] public bool visibilityTest;
		[Serialize("MaxActiveInstance"              )] public uint MaxActiveInstance;
		[Serialize("CList<FxDescriptor_Template>__0")] public CList<FxDescriptor_Template> CList_FxDescriptor_Template__0;
		[Serialize("CList<InputDesc>__1"            )] public CList<InputDesc> CList_InputDesc__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(CList_FxDescriptor_Template__0));
				SerializeField(s, nameof(CList_InputDesc__1));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(inputs));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(Fx));
				SerializeField(s, nameof(visibilityTest), boolAsByte: true);
				SerializeField(s, nameof(MaxActiveInstance));
			} else {
				SerializeField(s, nameof(Fx));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(visibilityTest));
				SerializeField(s, nameof(MaxActiveInstance));
			}
		}
		public override uint? ClassCRC => 0x00C61D05;
	}
}

