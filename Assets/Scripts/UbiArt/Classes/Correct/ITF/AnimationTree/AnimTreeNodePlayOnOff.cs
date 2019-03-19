using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AnimTreeNodePlayOnOff : BlendTreeNode<AnimTreeResult> {
		[Serialize("animOn")] public Generic<BlendTreeNode<AnimTreeResult>> animOn;
		[Serialize("animOff")] public Generic<BlendTreeNode<AnimTreeResult>> animOff;
		[Serialize("transOff" )] public AnimTreeNodePlayAnim transOff;
		[Serialize("transOn"  )] public AnimTreeNodePlayAnim transOn;
		[Serialize("criterias")] public CList<Criteria> criterias;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else {
				SerializeField(s, nameof(animOn));
				SerializeField(s, nameof(animOff));
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(criterias));
			}
		}
		public override uint? ClassCRC => 0x2F6D97A7;
	}
}

