using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodePlayOnOff : BlendTreeNode<AnimTreeResult> {
		[Serialize("transOff" )] public AnimTreeNodePlayAnim transOff;
		[Serialize("transOn"  )] public AnimTreeNodePlayAnim transOn;
		[Serialize("criterias")] public CList<Criteria> criterias;
		[Serialize("animOn"   )] public Placeholder animOn;
		[Serialize("animOff"  )] public Placeholder animOff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animOn));
				SerializeField(s, nameof(animOff));
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(criterias));
			} else {
				SerializeField(s, nameof(transOff));
				SerializeField(s, nameof(transOn));
				SerializeField(s, nameof(criterias));
			}
		}
		public override uint? ClassCRC => 0x2F6D97A7;
	}
}

