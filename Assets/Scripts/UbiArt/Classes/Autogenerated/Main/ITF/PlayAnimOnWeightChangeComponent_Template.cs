using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayAnimOnWeightChangeComponent_Template : ActorComponent_Template {
		[Serialize("enterAnim"      )] public StringID enterAnim;
		[Serialize("enterAnimIdle"  )] public StringID enterAnimIdle;
		[Serialize("exitAnim"       )] public StringID exitAnim;
		[Serialize("exitAnimIdle"   )] public StringID exitAnimIdle;
		[Serialize("listenToTrigger")] public bool listenToTrigger;
		[Serialize("listenToWeight" )] public bool listenToWeight;
		[Serialize("listenToEvent"  )] public Generic<Event> listenToEvent;
		[Serialize("stayOnEnter"    )] public bool stayOnEnter;
		[Serialize("weightThreshold")] public float weightThreshold;
		[Serialize("onEnterEvent"   )] public Generic<Event> onEnterEvent;
		[Serialize("onExitEvent"    )] public Generic<Event> onExitEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterAnim));
			SerializeField(s, nameof(enterAnimIdle));
			SerializeField(s, nameof(exitAnim));
			SerializeField(s, nameof(exitAnimIdle));
			SerializeField(s, nameof(listenToTrigger));
			SerializeField(s, nameof(listenToWeight));
			SerializeField(s, nameof(listenToEvent));
			SerializeField(s, nameof(stayOnEnter));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(onEnterEvent));
			SerializeField(s, nameof(onExitEvent));
		}
		public override uint? ClassCRC => 0x47C0AF3E;
	}
}

