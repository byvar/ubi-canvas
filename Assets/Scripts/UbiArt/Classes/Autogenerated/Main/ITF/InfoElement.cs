using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class InfoElement : CSerializable {
		public bool isOccupied;
		public uint reward;
		public AnimationAtlas anim;
		public AnimationAtlas animBreak;
		public FragmentsList fragments;
		public int int__0;
		public uint uint__1;
		public AnimationAtlas AnimationAtlas__2;
		public AnimationAtlas AnimationAtlas__3;
		public FragmentsList FragmentsList__4;
		public AnimationAtlas AnimationAtlas__5;
		public AnimationAtlas AnimationAtlas__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				int__0 = s.Serialize<int>(int__0, name: "int__0");
				uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
				AnimationAtlas__2 = s.SerializeObject<AnimationAtlas>(AnimationAtlas__2, name: "AnimationAtlas__2");
				AnimationAtlas__3 = s.SerializeObject<AnimationAtlas>(AnimationAtlas__3, name: "AnimationAtlas__3");
				FragmentsList__4 = s.SerializeObject<FragmentsList>(FragmentsList__4, name: "FragmentsList__4");
				AnimationAtlas__5 = s.SerializeObject<AnimationAtlas>(AnimationAtlas__5, name: "AnimationAtlas__5");
				AnimationAtlas__6 = s.SerializeObject<AnimationAtlas>(AnimationAtlas__6, name: "AnimationAtlas__6");
			} else {
				isOccupied = s.Serialize<bool>(isOccupied, name: "isOccupied");
				reward = s.Serialize<uint>(reward, name: "reward");
				anim = s.SerializeObject<AnimationAtlas>(anim, name: "anim");
				animBreak = s.SerializeObject<AnimationAtlas>(animBreak, name: "animBreak");
				fragments = s.SerializeObject<FragmentsList>(fragments, name: "fragments");
			}
		}
	}
}

