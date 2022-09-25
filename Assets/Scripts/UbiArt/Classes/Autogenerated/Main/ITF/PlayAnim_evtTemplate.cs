using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayAnim_evtTemplate : SequenceEventWithActor_Template {
		public type TypeAnim;
		public Path Anim;
		public bool Loop;
		public bool Cycle;
		public float PlayRate;
		public StringID BeginMarker;
		public StringID EndMarker;
		public bool processEvents;
		public int BlendFrames;
		public Spline Weight;
		public BoolEventList usePatches;
		public string AnimRO;
		public int BeginMarkerRO;
		public int EndMarkerRO;
		public BoolEventList Flip;
		public Spline Color;
		public Spline Alpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				TypeAnim = s.Serialize<type>(TypeAnim, name: "TypeAnim");
				AnimRO = s.Serialize<string>(AnimRO, name: "Anim");
				Loop = s.Serialize<bool>(Loop, name: "Loop");
				Cycle = s.Serialize<bool>(Cycle, name: "Cycle");
				PlayRate = s.Serialize<float>(PlayRate, name: "PlayRate");
				BeginMarkerRO = s.Serialize<int>(BeginMarkerRO, name: "BeginMarker");
				EndMarkerRO = s.Serialize<int>(EndMarkerRO, name: "EndMarker");
				Flip = s.SerializeObject<BoolEventList>(Flip, name: "Flip");
				Weight = s.SerializeObject<Spline>(Weight, name: "Weight");
				usePatches = s.SerializeObject<BoolEventList>(usePatches, name: "usePatches");
				Color = s.SerializeObject<Spline>(Color, name: "Color");
				Alpha = s.SerializeObject<Spline>(Alpha, name: "Alpha");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				TypeAnim = s.Serialize<type>(TypeAnim, name: "TypeAnim");
				Anim = s.SerializeObject<Path>(Anim, name: "Anim");
				Loop = s.Serialize<bool>(Loop, name: "Loop");
				Cycle = s.Serialize<bool>(Cycle, name: "Cycle");
				PlayRate = s.Serialize<float>(PlayRate, name: "PlayRate");
				BeginMarker = s.SerializeObject<StringID>(BeginMarker, name: "BeginMarker");
				EndMarker = s.SerializeObject<StringID>(EndMarker, name: "EndMarker");
				Weight = s.SerializeObject<Spline>(Weight, name: "Weight");
				usePatches = s.SerializeObject<BoolEventList>(usePatches, name: "usePatches");
			} else {
				TypeAnim = s.Serialize<type>(TypeAnim, name: "TypeAnim");
				Anim = s.SerializeObject<Path>(Anim, name: "Anim");
				Loop = s.Serialize<bool>(Loop, name: "Loop");
				Cycle = s.Serialize<bool>(Cycle, name: "Cycle");
				PlayRate = s.Serialize<float>(PlayRate, name: "PlayRate");
				BeginMarker = s.SerializeObject<StringID>(BeginMarker, name: "BeginMarker");
				EndMarker = s.SerializeObject<StringID>(EndMarker, name: "EndMarker");
				processEvents = s.Serialize<bool>(processEvents, name: "processEvents");
				BlendFrames = s.Serialize<int>(BlendFrames, name: "BlendFrames");
				Weight = s.SerializeObject<Spline>(Weight, name: "Weight");
				usePatches = s.SerializeObject<BoolEventList>(usePatches, name: "usePatches");
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

