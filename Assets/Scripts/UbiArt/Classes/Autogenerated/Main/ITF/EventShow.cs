using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventShow : Event {
		public float alpha;
		public float transitionTime;
		public bool overrideColor;
		public bool alpharatio;
		public Color color;
		public bool pauseOnEnd;
		public bool destroyOnEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO
				|| Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

