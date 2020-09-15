using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_InfoElement : CSerializable {
		public bool isOccupied;
		public uint reward;
		public AnimationAtlas anim;
		public AnimationAtlas animBreak;
		public RO2_FragmentsList fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isOccupied = s.Serialize<bool>(isOccupied, name: "isOccupied");
			reward = s.Serialize<uint>(reward, name: "reward");
			anim = s.SerializeObject<AnimationAtlas>(anim, name: "anim");
			animBreak = s.SerializeObject<AnimationAtlas>(animBreak, name: "animBreak");
			fragments = s.SerializeObject<RO2_FragmentsList>(fragments, name: "fragments");
		}
	}
}

