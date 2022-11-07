namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TutoTriggerComponent_Template : ActorComponent_Template {
		public Spline SlowDTCurve;
		public StringID WwiseGUID_onEnter;
		public StringID WwiseGUID_onExit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SlowDTCurve = s.SerializeObject<Spline>(SlowDTCurve, name: "SlowDTCurve");
			WwiseGUID_onEnter = s.SerializeObject<StringID>(WwiseGUID_onEnter, name: "WwiseGUID_onEnter");
			WwiseGUID_onExit = s.SerializeObject<StringID>(WwiseGUID_onExit, name: "WwiseGUID_onExit");
		}
		public override uint? ClassCRC => 0x259D5702;
	}
}

