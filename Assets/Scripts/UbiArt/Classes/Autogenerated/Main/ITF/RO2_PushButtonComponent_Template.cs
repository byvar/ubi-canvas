using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PushButtonComponent_Template : ActorComponent_Template {
		public float onOffDuration;
		public float delay;
		public bool activateChildren;
		public bool isProgressive;
		public float progressiveSpeed;
		public CArray<uint> progressiveHitLevels;
		public bool stayOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				onOffDuration = s.Serialize<float>(onOffDuration, name: "onOffDuration");
				delay = s.Serialize<float>(delay, name: "delay");
				activateChildren = s.Serialize<bool>(activateChildren, name: "activateChildren");
				isProgressive = s.Serialize<bool>(isProgressive, name: "isProgressive");
				progressiveSpeed = s.Serialize<float>(progressiveSpeed, name: "progressiveSpeed");
				progressiveHitLevels = s.SerializeObject<CArray<uint>>(progressiveHitLevels, name: "progressiveHitLevels");
				stayOn = s.Serialize<bool>(stayOn, name: "stayOn");
			} else {
				onOffDuration = s.Serialize<float>(onOffDuration, name: "onOffDuration");
				delay = s.Serialize<float>(delay, name: "delay");
				activateChildren = s.Serialize<bool>(activateChildren, name: "activateChildren");
				isProgressive = s.Serialize<bool>(isProgressive, name: "isProgressive");
				progressiveSpeed = s.Serialize<float>(progressiveSpeed, name: "progressiveSpeed");
				progressiveHitLevels = s.SerializeObject<CArray<uint>>(progressiveHitLevels, name: "progressiveHitLevels");
				progressiveHitLevels = s.SerializeObject<CArray<uint>>(progressiveHitLevels, name: "progressiveHitLevels");
				stayOn = s.Serialize<bool>(stayOn, name: "stayOn");
			}
		}
		public override uint? ClassCRC => 0xC81F9119;
	}
}

