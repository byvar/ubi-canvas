using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR)]
	public partial class InfoElement : CSerializable {
		[Serialize("isOccupied"       )] public bool isOccupied;
		[Serialize("reward"           )] public uint reward;
		[Serialize("anim"             )] public AnimationAtlas anim;
		[Serialize("animBreak"        )] public AnimationAtlas animBreak;
		[Serialize("fragments"        )] public FragmentsList fragments;
		[Serialize("int__0"           )] public int int__0;
		[Serialize("uint__1"          )] public uint uint__1;
		[Serialize("AnimationAtlas__2")] public AnimationAtlas AnimationAtlas__2;
		[Serialize("AnimationAtlas__3")] public AnimationAtlas AnimationAtlas__3;
		[Serialize("FragmentsList__4" )] public FragmentsList FragmentsList__4;
		[Serialize("AnimationAtlas__5")] public AnimationAtlas AnimationAtlas__5;
		[Serialize("AnimationAtlas__6")] public AnimationAtlas AnimationAtlas__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(AnimationAtlas__2));
				SerializeField(s, nameof(AnimationAtlas__3));
				SerializeField(s, nameof(FragmentsList__4));
				SerializeField(s, nameof(AnimationAtlas__5));
				SerializeField(s, nameof(AnimationAtlas__6));
			} else {
				SerializeField(s, nameof(isOccupied));
				SerializeField(s, nameof(reward));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(animBreak));
				SerializeField(s, nameof(fragments));
			}
		}
	}
}

