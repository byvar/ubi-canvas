using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimNodeSwing : CSerializable {
		[Serialize("leafs"    )] public Placeholder leafs;
		[Serialize("childData")] public Placeholder childData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(leafs));
				SerializeField(s, nameof(childData));
			} else {
			}
		}
		public override uint? ClassCRC => 0x73BAE590;
	}
}

