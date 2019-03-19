using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HangSpotComponent_Template : ActorComponent_Template {
		[Serialize("radius"                )] public float radius;
		[Serialize("phantomOffset"         )] public Vector2 phantomOffset;
		[Serialize("phantomRadius"         )] public float phantomRadius;
		[Serialize("notifyToParentBind"    )] public bool notifyToParentBind;
		[Serialize("allowOneHangOnly"      )] public bool allowOneHangOnly;
		[Serialize("hangEventTriggerOnce"  )] public bool hangEventTriggerOnce;
		[Serialize("unHangEventTriggerOnce")] public bool unHangEventTriggerOnce;
		[Serialize("onHangEvent"           )] public Generic<Event> onHangEvent;
		[Serialize("onUnhangEvent"         )] public Generic<Event> onUnhangEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(phantomOffset));
				SerializeField(s, nameof(phantomRadius));
				SerializeField(s, nameof(notifyToParentBind));
				SerializeField(s, nameof(allowOneHangOnly));
				SerializeField(s, nameof(onHangEvent));
				SerializeField(s, nameof(onUnhangEvent));
			} else {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(phantomOffset));
				SerializeField(s, nameof(phantomRadius));
				SerializeField(s, nameof(notifyToParentBind));
				SerializeField(s, nameof(allowOneHangOnly));
				SerializeField(s, nameof(hangEventTriggerOnce));
				SerializeField(s, nameof(unHangEventTriggerOnce));
				SerializeField(s, nameof(onHangEvent));
				SerializeField(s, nameof(onUnhangEvent));
			}
		}
		public override uint? ClassCRC => 0x241C3DBC;
	}
}

