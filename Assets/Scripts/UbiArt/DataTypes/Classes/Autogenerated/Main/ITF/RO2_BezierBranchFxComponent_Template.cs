namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchFxComponent_Template : RO2_BezierBranchComponent_Template {
		public StringID fxStart;
		public StringID fxLoop;
		public StringID fxStop;
		public StringID fxDefault;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxStart = s.SerializeObject<StringID>(fxStart, name: "fxStart");
			fxLoop = s.SerializeObject<StringID>(fxLoop, name: "fxLoop");
			fxStop = s.SerializeObject<StringID>(fxStop, name: "fxStop");
			fxDefault = s.SerializeObject<StringID>(fxDefault, name: "fxDefault");
		}
		public override uint? ClassCRC => 0x434D51D8;
	}
}

