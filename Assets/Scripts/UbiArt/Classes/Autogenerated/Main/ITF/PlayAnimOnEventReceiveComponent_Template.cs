using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayAnimOnEventReceiveComponent_Template : ActorComponent_Template {
		[Serialize("listenEvents"                      )] public CList<Event> listenEvents;
		[Serialize("useForLoop"                        )] public bool useForLoop;
		[Serialize("idleAnim"                          )] public StringID idleAnim;
		[Serialize("eventAnim"                         )] public StringID eventAnim;
		[Serialize("eventIdleAnim"                     )] public StringID eventIdleAnim;
		[Serialize("resetOnRetrigger"                  )] public bool resetOnRetrigger;
		[Serialize("stayOnEvent"                       )] public bool stayOnEvent;
		[Serialize("stayOnEventCheckpointSave"         )] public bool stayOnEventCheckpointSave;
		[Serialize("disableAfterEvent"                 )] public bool disableAfterEvent;
		[Serialize("useAnimatedComponentForAnimsFinish")] public bool useAnimatedComponentForAnimsFinish;
		[Serialize("useMRKtoAllowRestart"              )] public bool useMRKtoAllowRestart;
		[Serialize("acceptOnlyChargedPunch"            )] public bool acceptOnlyChargedPunch;
		[Serialize("eventToSend"                       )] public Generic<Event> eventToSend;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(listenEvents));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(eventAnim));
				SerializeField(s, nameof(eventIdleAnim));
				SerializeField(s, nameof(resetOnRetrigger));
				SerializeField(s, nameof(stayOnEvent));
				SerializeField(s, nameof(stayOnEventCheckpointSave));
				SerializeField(s, nameof(disableAfterEvent));
				SerializeField(s, nameof(useAnimatedComponentForAnimsFinish));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(listenEvents));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(eventAnim));
				SerializeField(s, nameof(eventIdleAnim));
				SerializeField(s, nameof(resetOnRetrigger));
				SerializeField(s, nameof(stayOnEvent));
				SerializeField(s, nameof(stayOnEventCheckpointSave));
				SerializeField(s, nameof(disableAfterEvent));
				SerializeField(s, nameof(useAnimatedComponentForAnimsFinish));
				SerializeField(s, nameof(useMRKtoAllowRestart));
				SerializeField(s, nameof(acceptOnlyChargedPunch));
				SerializeField(s, nameof(eventToSend));
			} else {
				SerializeField(s, nameof(listenEvents));
				SerializeField(s, nameof(useForLoop));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(eventAnim));
				SerializeField(s, nameof(eventIdleAnim));
				SerializeField(s, nameof(resetOnRetrigger));
				SerializeField(s, nameof(stayOnEvent));
				SerializeField(s, nameof(stayOnEventCheckpointSave));
				SerializeField(s, nameof(disableAfterEvent));
				SerializeField(s, nameof(useAnimatedComponentForAnimsFinish));
				SerializeField(s, nameof(useMRKtoAllowRestart));
				SerializeField(s, nameof(acceptOnlyChargedPunch));
				SerializeField(s, nameof(eventToSend));
			}
		}
		public override uint? ClassCRC => 0xD7767023;
	}
}

