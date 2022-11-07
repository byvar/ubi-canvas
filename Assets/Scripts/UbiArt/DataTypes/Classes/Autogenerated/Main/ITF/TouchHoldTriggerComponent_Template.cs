namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchHoldTriggerComponent_Template : ActorComponent_Template {
		public bool ListenToSwipe;
		public StringID input;
		public bool catchFrontEnabled;
		public bool noInteraction;
		public Generic<Event> tapGaugeFullEvent;
		public Generic<Event> tapGaugeEmptyEvent;
		public float tapGaugeFullValue;
		public float tapGaugeEmptyValue;
		public float tapGaugeFillTapValue;
		public float tapGaugeEmptyValuePerSec;
		public float tapGaugeHoldAsTapDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				ListenToSwipe = s.Serialize<bool>(ListenToSwipe, name: "ListenToSwipe");
				input = s.SerializeObject<StringID>(input, name: "input");
				catchFrontEnabled = s.Serialize<bool>(catchFrontEnabled, name: "catchFrontEnabled");
				noInteraction = s.Serialize<bool>(noInteraction, name: "noInteraction");
				tapGaugeFullEvent = s.SerializeObject<Generic<Event>>(tapGaugeFullEvent, name: "tapGaugeFullEvent");
				tapGaugeEmptyEvent = s.SerializeObject<Generic<Event>>(tapGaugeEmptyEvent, name: "tapGaugeEmptyEvent");
				tapGaugeFullValue = s.Serialize<float>(tapGaugeFullValue, name: "tapGaugeFullValue");
				tapGaugeEmptyValue = s.Serialize<float>(tapGaugeEmptyValue, name: "tapGaugeEmptyValue");
				tapGaugeFillTapValue = s.Serialize<float>(tapGaugeFillTapValue, name: "tapGaugeFillTapValue");
				tapGaugeEmptyValuePerSec = s.Serialize<float>(tapGaugeEmptyValuePerSec, name: "tapGaugeEmptyValuePerSec");
				tapGaugeHoldAsTapDuration = s.Serialize<float>(tapGaugeHoldAsTapDuration, name: "tapGaugeHoldAsTapDuration");
			} else {
				ListenToSwipe = s.Serialize<bool>(ListenToSwipe, name: "ListenToSwipe");
				input = s.SerializeObject<StringID>(input, name: "input");
				catchFrontEnabled = s.Serialize<bool>(catchFrontEnabled, name: "catchFrontEnabled");
				noInteraction = s.Serialize<bool>(noInteraction, name: "noInteraction");
			}
		}
		public override uint? ClassCRC => 0x1B4A038F;
	}
}

