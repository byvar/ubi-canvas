using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodePlayOnOff_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("transOn"    )] public AnimTreeNodePlayAnim_Template transOn;
		[Serialize("transOff"   )] public AnimTreeNodePlayAnim_Template transOff;
		[Serialize("criteriasOn")] public CList<CriteriaDesc> criteriasOn;
		[Serialize("nodeName"   )] public StringID nodeName;
		[Serialize("nodeOn"     )] public Placeholder nodeOn;
		[Serialize("nodeOff"    )] public Placeholder nodeOff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(nodeOn));
				SerializeField(s, nameof(nodeOff));
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(criteriasOn));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(nodeOn));
				SerializeField(s, nameof(nodeOff));
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(criteriasOn));
			} else {
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(criteriasOn));
			}
		}
		public override uint? ClassCRC => 0x3AAD7849;
	}
}

