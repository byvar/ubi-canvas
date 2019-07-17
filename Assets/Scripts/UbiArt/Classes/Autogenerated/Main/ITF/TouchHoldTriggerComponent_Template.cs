using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TouchHoldTriggerComponent_Template : ActorComponent_Template {
		[Serialize("ListenToSwipe"            )] public bool ListenToSwipe;
		[Serialize("input"                    )] public StringID input;
		[Serialize("catchFrontEnabled"        )] public bool catchFrontEnabled;
		[Serialize("noInteraction"            )] public bool noInteraction;
		[Serialize("tapGaugeFullEvent"        )] public Generic<Event> tapGaugeFullEvent;
		[Serialize("tapGaugeEmptyEvent"       )] public Generic<Event> tapGaugeEmptyEvent;
		[Serialize("tapGaugeFullValue"        )] public float tapGaugeFullValue;
		[Serialize("tapGaugeEmptyValue"       )] public float tapGaugeEmptyValue;
		[Serialize("tapGaugeFillTapValue"     )] public float tapGaugeFillTapValue;
		[Serialize("tapGaugeEmptyValuePerSec" )] public float tapGaugeEmptyValuePerSec;
		[Serialize("tapGaugeHoldAsTapDuration")] public float tapGaugeHoldAsTapDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(ListenToSwipe));
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(catchFrontEnabled));
				SerializeField(s, nameof(noInteraction));
				SerializeField(s, nameof(tapGaugeFullEvent));
				SerializeField(s, nameof(tapGaugeEmptyEvent));
				SerializeField(s, nameof(tapGaugeFullValue));
				SerializeField(s, nameof(tapGaugeEmptyValue));
				SerializeField(s, nameof(tapGaugeFillTapValue));
				SerializeField(s, nameof(tapGaugeEmptyValuePerSec));
				SerializeField(s, nameof(tapGaugeHoldAsTapDuration));
			} else {
				SerializeField(s, nameof(ListenToSwipe));
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(catchFrontEnabled));
				SerializeField(s, nameof(noInteraction));
			}
		}
		public override uint? ClassCRC => 0x1B4A038F;
	}
}

