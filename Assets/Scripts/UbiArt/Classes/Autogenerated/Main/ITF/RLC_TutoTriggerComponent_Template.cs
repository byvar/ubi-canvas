using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TutoTriggerComponent_Template : ActorComponent_Template {
		[Serialize("SlowDTCurve"      )] public Spline SlowDTCurve;
		[Serialize("WwiseGUID_onEnter")] public StringID WwiseGUID_onEnter;
		[Serialize("WwiseGUID_onExit" )] public StringID WwiseGUID_onExit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SlowDTCurve));
			SerializeField(s, nameof(WwiseGUID_onEnter));
			SerializeField(s, nameof(WwiseGUID_onExit));
		}
		public override uint? ClassCRC => 0x259D5702;
	}
}

