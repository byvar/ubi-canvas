namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class PlayTimeFactor_evtTemplate : SequenceEventWithActor_Template {
		public Spline TimeFactorSpline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TimeFactorSpline = s.SerializeObject<Spline>(TimeFactorSpline, name: "TimeFactorSpline");
		}
		public override uint? ClassCRC => 0x7C7901F3;
	}
}

