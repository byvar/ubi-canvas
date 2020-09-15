using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AnimTreeNodePlayOnOff_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		public Generic<BlendTreeNodeTemplate<AnimTreeResult>> nodeOn;
		public Generic<BlendTreeNodeTemplate<AnimTreeResult>> nodeOff;
		public AnimTreeNodePlayAnim_Template transOn;
		public AnimTreeNodePlayAnim_Template transOff;
		public CList<CriteriaDesc> criteriasOn;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodeOn = s.SerializeObject<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>(nodeOn, name: "nodeOn");
			nodeOff = s.SerializeObject<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>(nodeOff, name: "nodeOff");
			transOn = s.SerializeObject<AnimTreeNodePlayAnim_Template>(transOn, name: "transOn");
			transOff = s.SerializeObject<AnimTreeNodePlayAnim_Template>(transOff, name: "transOff");
			criteriasOn = s.SerializeObject<CList<CriteriaDesc>>(criteriasOn, name: "criteriasOn");
		}
		public override uint? ClassCRC => 0x3AAD7849;
	}
}

