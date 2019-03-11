using UnityEngine;

namespace UbiArt.ITF {
	public partial class Animation3DTree : BlendTree<Animation3DTreeResult> {
		[Serialize("nodes"         )] public Placeholder nodes;
		[Serialize("transitions"   )] public Placeholder transitions;
		[Serialize("additiveLayers")] public Placeholder additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(transitions));
				SerializeField(s, nameof(additiveLayers));
			} else {
			}
		}
		public override uint? ClassCRC => 0x2FF4CFD5;
	}
}

