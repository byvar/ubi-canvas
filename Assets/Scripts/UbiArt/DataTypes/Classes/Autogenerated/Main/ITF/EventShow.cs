namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventShow : Event {
		public float alpha = 1f;
		public float transitionTime;
		public bool overrideColor;
		public bool alpharatio = true;
		public Color color = Color.White;
		public bool pauseOnEnd;
		public bool destroyOnEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO
				|| s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				alpha = s.Serialize<float>(alpha, name: "alpha");
				transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
				overrideColor = s.Serialize<bool>(overrideColor, name: "overrideColor");
				color = s.SerializeObject<Color>(color, name: "color");
				pauseOnEnd = s.Serialize<bool>(pauseOnEnd, name: "pauseOnEnd");
				destroyOnEnd = s.Serialize<bool>(destroyOnEnd, name: "destroyOnEnd");
			} else {
				alpha = s.Serialize<float>(alpha, name: "alpha");
				transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
				overrideColor = s.Serialize<bool>(overrideColor, name: "overrideColor");
				alpharatio = s.Serialize<bool>(alpharatio, name: "alpharatio");
				color = s.SerializeObject<Color>(color, name: "color");
				pauseOnEnd = s.Serialize<bool>(pauseOnEnd, name: "pauseOnEnd");
				destroyOnEnd = s.Serialize<bool>(destroyOnEnd, name: "destroyOnEnd");
			}
		}
		public override uint? ClassCRC => 0x06A5D850;
	}
}

