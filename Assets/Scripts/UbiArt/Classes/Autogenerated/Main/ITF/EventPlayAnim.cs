using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventPlayAnim : Event {
		[Serialize("AnimToPlay"      )] public StringID AnimToPlay;
		[Serialize("isAdditive"      )] public bool isAdditive;
		[Serialize("AdditiveWeight"  )] public float AdditiveWeight;
		[Serialize("AdditiveUsePatch")] public bool AdditiveUsePatch;
		[Serialize("NbBlendFrame"    )] public uint NbBlendFrame;
		[Serialize("ResetAnim"       )] public bool ResetAnim;
		[Serialize("AnimPriority"    )] public uint AnimPriority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(AnimToPlay));
				SerializeField(s, nameof(NbBlendFrame));
				SerializeField(s, nameof(ResetAnim));
				SerializeField(s, nameof(AnimPriority));
			} else {
				SerializeField(s, nameof(AnimToPlay));
				SerializeField(s, nameof(isAdditive));
				SerializeField(s, nameof(AdditiveWeight));
				SerializeField(s, nameof(AdditiveUsePatch));
				SerializeField(s, nameof(NbBlendFrame));
				SerializeField(s, nameof(ResetAnim));
				SerializeField(s, nameof(AnimPriority));
			}
		}
		public override uint? ClassCRC => 0x546A94AF;
	}
}

