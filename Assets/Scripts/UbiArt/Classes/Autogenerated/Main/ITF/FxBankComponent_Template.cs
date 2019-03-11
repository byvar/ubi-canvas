using UnityEngine;

namespace UbiArt.ITF {
	public partial class FxBankComponent_Template : GraphicComponent_Template {
		[Serialize("Fx"               )] public CList<FxDescriptor_Template> Fx;
		[Serialize("inputs"           )] public CList<InputDesc> inputs;
		[Serialize("visibilityTest"   )] public bool visibilityTest;
		[Serialize("MaxActiveInstance")] public uint MaxActiveInstance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(inputs));
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

