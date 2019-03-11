using UnityEngine;

namespace UbiArt.ITF {
	public partial class TODOComponent_Template : ActorComponent_Template {
		[Serialize("textPath")] public Path textPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(textPath));
			} else {
			}
		}
		public override uint? ClassCRC => 0x3C0BDF51;
	}
}

