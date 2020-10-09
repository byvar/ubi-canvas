using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_HangSpotComponent_Template : ActorComponent_Template {
		public float radius;
		public Vec2d phantomOffset;
		public float phantomRadius;
		public bool notifyToParentBind;
		public bool allowOneHangOnly;
		public bool hangEventTriggerOnce;
		public bool unHangEventTriggerOnce;
		public Generic<Event> onHangEvent;
		public Generic<Event> onUnhangEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				radius = s.Serialize<float>(radius, name: "radius");
				phantomOffset = s.SerializeObject<Vec2d>(phantomOffset, name: "phantomOffset");
				phantomRadius = s.Serialize<float>(phantomRadius, name: "phantomRadius");
				notifyToParentBind = s.Serialize<bool>(notifyToParentBind, name: "notifyToParentBind");
				allowOneHangOnly = s.Serialize<bool>(allowOneHangOnly, name: "allowOneHangOnly");
				onHangEvent = s.SerializeObject<Generic<Event>>(onHangEvent, name: "onHangEvent");
				onUnhangEvent = s.SerializeObject<Generic<Event>>(onUnhangEvent, name: "onUnhangEvent");
			} else {
				radius = s.Serialize<float>(radius, name: "radius");
				phantomOffset = s.SerializeObject<Vec2d>(phantomOffset, name: "phantomOffset");
				phantomRadius = s.Serialize<float>(phantomRadius, name: "phantomRadius");
				notifyToParentBind = s.Serialize<bool>(notifyToParentBind, name: "notifyToParentBind");
				allowOneHangOnly = s.Serialize<bool>(allowOneHangOnly, name: "allowOneHangOnly");
				hangEventTriggerOnce = s.Serialize<bool>(hangEventTriggerOnce, name: "hangEventTriggerOnce");
				unHangEventTriggerOnce = s.Serialize<bool>(unHangEventTriggerOnce, name: "unHangEventTriggerOnce");
				onHangEvent = s.SerializeObject<Generic<Event>>(onHangEvent, name: "onHangEvent");
				onUnhangEvent = s.SerializeObject<Generic<Event>>(onUnhangEvent, name: "onUnhangEvent");
			}
		}
		public override uint? ClassCRC => 0x241C3DBC;
	}
}

