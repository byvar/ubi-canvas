namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FxBankComponent_Template : GraphicComponent_Template {
		public CListO<FxDescriptor_Template> Fx;
		public CListO<InputDesc> inputs;
		public bool visibilityTest;
		public uint MaxActiveInstance = 20;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR) {
				Fx = s.SerializeObject<CListO<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
			} else if (s.Settings.Game == Game.COL) {
				Fx = s.SerializeObject<CListO<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				visibilityTest = s.Serialize<bool>(visibilityTest, name: "visibilityTest", options: CSerializerObject.Options.BoolAsByte);
				MaxActiveInstance = s.Serialize<uint>(MaxActiveInstance, name: "MaxActiveInstance");
			} else {
				Fx = s.SerializeObject<CListO<FxDescriptor_Template>>(Fx, name: "Fx");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				visibilityTest = s.Serialize<bool>(visibilityTest, name: "visibilityTest");
				MaxActiveInstance = s.Serialize<uint>(MaxActiveInstance, name: "MaxActiveInstance");
			}
		}
		public override uint? ClassCRC => 0x00C61D05;
	}
}

