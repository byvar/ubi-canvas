using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FxBankComponent_Template : GraphicComponent_Template {
		public CList<FxDescriptor_Template> Fx;
		public CList<InputDesc> inputs;
		public bool visibilityTest;
		public uint MaxActiveInstance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				Fx = s.SerializeObject<CList<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
			} else if (Settings.s.game == Settings.Game.COL) {
				Fx = s.SerializeObject<CList<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				visibilityTest = s.Serialize<bool>(visibilityTest, name: "visibilityTest", options: CSerializerObject.Options.BoolAsByte);
				MaxActiveInstance = s.Serialize<uint>(MaxActiveInstance, name: "MaxActiveInstance");
			} else {
				Fx = s.SerializeObject<CList<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				visibilityTest = s.Serialize<bool>(visibilityTest, name: "visibilityTest");
				MaxActiveInstance = s.Serialize<uint>(MaxActiveInstance, name: "MaxActiveInstance");
			}
		}
		public override uint? ClassCRC => 0x00C61D05;
	}
}

