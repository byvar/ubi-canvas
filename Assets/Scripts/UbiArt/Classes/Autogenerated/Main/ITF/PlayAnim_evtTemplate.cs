using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlayAnim_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("TypeAnim"     )] public type TypeAnim;
		[Serialize("Anim"         )] public Path Anim;
		[Serialize("Loop"         )] public bool Loop;
		[Serialize("Cycle"        )] public bool Cycle;
		[Serialize("PlayRate"     )] public float PlayRate;
		[Serialize("BeginMarker"  )] public StringID BeginMarker;
		[Serialize("EndMarker"    )] public StringID EndMarker;
		[Serialize("processEvents")] public bool processEvents;
		[Serialize("BlendFrames"  )] public int BlendFrames;
		[Serialize("Weight"       )] public Spline Weight;
		[Serialize("usePatches"   )] public BoolEventList usePatches;
		[Serialize("Anim"         )] public string AnimRO;
		[Serialize("BeginMarker"  )] public int BeginMarkerRO;
		[Serialize("EndMarker"    )] public int EndMarkerRO;
		[Serialize("Flip"         )] public BoolEventList Flip;
		[Serialize("Color"        )] public Spline Color;
		[Serialize("Alpha"        )] public Spline Alpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(TypeAnim));
				SerializeField(s, nameof(AnimRO));
				SerializeField(s, nameof(Loop));
				SerializeField(s, nameof(Cycle));
				SerializeField(s, nameof(PlayRate));
				SerializeField(s, nameof(BeginMarkerRO));
				SerializeField(s, nameof(EndMarkerRO));
				SerializeField(s, nameof(Flip));
				SerializeField(s, nameof(Weight));
				SerializeField(s, nameof(usePatches));
				SerializeField(s, nameof(Color));
				SerializeField(s, nameof(Alpha));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(TypeAnim));
				SerializeField(s, nameof(Anim));
				SerializeField(s, nameof(Loop));
				SerializeField(s, nameof(Cycle));
				SerializeField(s, nameof(PlayRate));
				SerializeField(s, nameof(BeginMarker));
				SerializeField(s, nameof(EndMarker));
				SerializeField(s, nameof(Weight));
				SerializeField(s, nameof(usePatches));
			} else {
				SerializeField(s, nameof(TypeAnim));
				SerializeField(s, nameof(Anim));
				SerializeField(s, nameof(Loop));
				SerializeField(s, nameof(Cycle));
				SerializeField(s, nameof(PlayRate));
				SerializeField(s, nameof(BeginMarker));
				SerializeField(s, nameof(EndMarker));
				SerializeField(s, nameof(processEvents));
				SerializeField(s, nameof(BlendFrames));
				SerializeField(s, nameof(Weight));
				SerializeField(s, nameof(usePatches));
			}
		}
		public enum type {
			[Serialize("type_anim"    )] anim = 1,
			[Serialize("type_action"  )] action = 2,
			[Serialize("type_sub_anim")] sub_anim = 3,
		}
		public override uint? ClassCRC => 0x0888A18E;
	}
}

