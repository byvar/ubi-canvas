using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AnimTreeNodePlayOnOff_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("nodeOn"     )] public Generic<BlendTreeNodeTemplate<AnimTreeResult>> nodeOn;
		[Serialize("nodeOff"    )] public Generic<BlendTreeNodeTemplate<AnimTreeResult>> nodeOff;
		[Serialize("transOn"    )] public AnimTreeNodePlayAnim_Template transOn;
		[Serialize("transOff"   )] public AnimTreeNodePlayAnim_Template transOff;
		[Serialize("criteriasOn")] public CList<CriteriaDesc> criteriasOn;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodeOn));
			SerializeField(s, nameof(nodeOff));
			SerializeField(s, nameof(transOn));
			SerializeField(s, nameof(transOff));
			SerializeField(s, nameof(criteriasOn));
		}
		public override uint? ClassCRC => 0x3AAD7849;
	}
}

