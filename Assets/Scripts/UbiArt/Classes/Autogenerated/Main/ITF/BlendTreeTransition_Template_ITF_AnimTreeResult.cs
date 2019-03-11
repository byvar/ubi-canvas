using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeTransition_Template<AnimTreeResult> : CSerializable {
		[Serialize("blend"              )] public uint blend;
		[Serialize("flags"              )] public Enum_flags flags;
		[Serialize("blendFromTransition")] public uint blendFromTransition;
		[Serialize("from"               )] public Placeholder from;
		[Serialize("to"                 )] public Placeholder to;
		[Serialize("node"               )] public Placeholder node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(blend));
				SerializeField(s, nameof(blendFromTransition));
				SerializeField(s, nameof(from));
				SerializeField(s, nameof(to));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(node));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(blend));
				SerializeField(s, nameof(blendFromTransition));
				SerializeField(s, nameof(from));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(node));
				}
			} else {
				SerializeField(s, nameof(blend));
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(blendFromTransition));
			}
		}
		public enum Enum_flags {
			[Serialize("TranstionFlag_Progressive")] TranstionFlag_Progressive = 1,
		}
		public override uint? ClassCRC => 0x5F47DD70;
	}
}

