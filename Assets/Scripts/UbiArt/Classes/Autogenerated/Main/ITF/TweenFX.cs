using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenFX : TweenInstruction {
		[Serialize("target")] public ObjectPath target;
		[Serialize("name"  )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(target));
			} else {
				SerializeField(s, nameof(target));
			}
		}
		public override uint? ClassCRC => 0x4927CB67;
	}
}

