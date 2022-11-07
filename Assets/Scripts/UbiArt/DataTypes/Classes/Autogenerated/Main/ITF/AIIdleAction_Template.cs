namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIIdleAction_Template : AIAction_Template {
		public float minTime;
		public float maxTime;
		public bool startTimerOnMetronome;
		public float syncRatio;
		public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minTime = s.Serialize<float>(minTime, name: "minTime");
			maxTime = s.Serialize<float>(maxTime, name: "maxTime");
			startTimerOnMetronome = s.Serialize<bool>(startTimerOnMetronome, name: "startTimerOnMetronome");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
		}
		public override uint? ClassCRC => 0x5926CA92;
	}
}

