using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AnimTreeNodePlayOnOff : BlendTreeNode<AnimTreeResult> {
		public Generic<BlendTreeNode<AnimTreeResult>> animOn;
		public Generic<BlendTreeNode<AnimTreeResult>> animOff;
		public AnimTreeNodePlayAnim transOff;
		public AnimTreeNodePlayAnim transOn;
		public CListO<Criteria> criterias;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else {
				animOn = s.SerializeObject<Generic<BlendTreeNode<AnimTreeResult>>>(animOn, name: "animOn");
				animOff = s.SerializeObject<Generic<BlendTreeNode<AnimTreeResult>>>(animOff, name: "animOff");
				transOff = s.SerializeObject<AnimTreeNodePlayAnim>(transOff, name: "transOff");
				transOn = s.SerializeObject<AnimTreeNodePlayAnim>(transOn, name: "transOn");
				criterias = s.SerializeObject<CListO<Criteria>>(criterias, name: "criterias");
			}
		}
		public override uint? ClassCRC => 0x2F6D97A7;
	}
}

