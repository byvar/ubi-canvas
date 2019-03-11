using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerComponent : ActorComponent {
		[Serialize("mode"                        )] public Mode mode;
		[Serialize("triggerOnceDone"             )] public bool triggerOnceDone;
		[Serialize("countdown"                   )] public float countdown;
		[Serialize("DBG_DrawCountdown"           )] public bool DBG_DrawCountdown;
		[Serialize("AutoActivation"              )] public bool AutoActivation;
		[Serialize("NoConditionEvent"            )] public Generic<Event> NoConditionEvent;
		[Serialize("onEnterMoreEvent"            )] public CList<Event> onEnterMoreEvent;
		[Serialize("onExitMoreEvent"             )] public CList<Event> onExitMoreEvent;
		[Serialize("moreEventSendBroadcast"      )] public bool moreEventSendBroadcast;
		[Serialize("moreEventSendGameManager"    )] public bool moreEventSendGameManager;
		[Serialize("activatedOnGo"               )] public bool activatedOnGo;
		[Serialize("specificTutoShieldDialog"    )] public bool specificTutoShieldDialog;
		[Serialize("disableIfMapAlreadyCompleted")] public bool disableIfMapAlreadyCompleted;
		[Serialize("triggerActivator"            )] public bool triggerActivator;
		[Serialize("retriggerOnCheckpoint"       )] public bool retriggerOnCheckpoint;
		[Serialize("activator"                   )] public uint activator;
		[Serialize("mode"                        )] public Enum_mode mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(retriggerOnCheckpoint));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
					SerializeField(s, nameof(activator));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(mode));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
					SerializeField(s, nameof(activator));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(mode));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(countdown));
				SerializeField(s, nameof(DBG_DrawCountdown));
				SerializeField(s, nameof(AutoActivation));
				SerializeField(s, nameof(NoConditionEvent));
				SerializeField(s, nameof(onEnterMoreEvent));
				SerializeField(s, nameof(onExitMoreEvent));
				SerializeField(s, nameof(moreEventSendBroadcast));
				SerializeField(s, nameof(moreEventSendGameManager));
				SerializeField(s, nameof(activatedOnGo));
				SerializeField(s, nameof(specificTutoShieldDialog));
				SerializeField(s, nameof(disableIfMapAlreadyCompleted));
				SerializeField(s, nameof(triggerActivator));
			}
		}
		public enum Mode {
			[Serialize("Mode_Once"            )] Once = 1,
			[Serialize("Mode_OnceAndRetrigger")] OnceAndRetrigger = 2,
			[Serialize("Mode_OnceAndReset"    )] OnceAndReset = 3,
			[Serialize("Mode_Multiple"        )] Multiple = 4,
		}
		public enum Enum_mode {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x5E302A40;
	}
}

