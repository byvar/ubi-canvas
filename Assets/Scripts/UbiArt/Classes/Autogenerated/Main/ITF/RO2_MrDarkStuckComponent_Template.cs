using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MrDarkStuckComponent_Template : ActorComponent_Template {
		[Serialize("listenEvents"                      )] public CList<Generic<Event>> listenEvents;
		[Serialize("idleAnim"                          )] public StringID idleAnim;
		[Serialize("eventAnim"                         )] public StringID eventAnim;
		[Serialize("eventIdleAnim"                     )] public StringID eventIdleAnim;
		[Serialize("reactionAnim"                      )] public StringID reactionAnim;
		[Serialize("resetOnRetrigger"                  )] public bool resetOnRetrigger;
		[Serialize("stayOnEvent"                       )] public bool stayOnEvent;
		[Serialize("stayOnEventCheckpointSave"         )] public bool stayOnEventCheckpointSave;
		[Serialize("disableAfterEvent"                 )] public bool disableAfterEvent;
		[Serialize("useAnimatedComponentForAnimsFinish")] public bool useAnimatedComponentForAnimsFinish;
		[Serialize("useMRKtoAllowRestart"              )] public bool useMRKtoAllowRestart;
		[Serialize("acceptOnlyChargedPunch"            )] public bool acceptOnlyChargedPunch;
		[Serialize("eventToSend"                       )] public Generic<Event> eventToSend;
		[Serialize("swipeDotMin"                       )] public float swipeDotMin;
		[Serialize("swipeNormMin"                      )] public float swipeNormMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(listenEvents));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(eventAnim));
			SerializeField(s, nameof(eventIdleAnim));
			SerializeField(s, nameof(reactionAnim));
			SerializeField(s, nameof(resetOnRetrigger));
			SerializeField(s, nameof(stayOnEvent));
			SerializeField(s, nameof(stayOnEventCheckpointSave));
			SerializeField(s, nameof(disableAfterEvent));
			SerializeField(s, nameof(useAnimatedComponentForAnimsFinish));
			SerializeField(s, nameof(useMRKtoAllowRestart));
			SerializeField(s, nameof(acceptOnlyChargedPunch));
			SerializeField(s, nameof(eventToSend));
			SerializeField(s, nameof(swipeDotMin));
			SerializeField(s, nameof(swipeNormMin));
		}
		public override uint? ClassCRC => 0x782BE8F8;
	}
}

