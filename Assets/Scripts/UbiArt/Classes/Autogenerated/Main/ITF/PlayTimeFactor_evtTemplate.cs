using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayTimeFactor_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("TimeFactorSpline")] public Spline TimeFactorSpline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TimeFactorSpline));
		}
		public override uint? ClassCRC => 0x7C7901F3;
	}
}

