using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTransition_Template<T> : CSerializable {
		[Serialize("blend"              )] public uint blend;
		[Serialize("flags"              )] public TransitionFlag flagsEnum;
		[Serialize("flags"              )] public uint flags;
		[Serialize("blendFromTransition")] public uint blendFromTransition;
		[Serialize("from"               )] public CArray<StringID> from;
		[Serialize("to"                 )] public CArray<StringID> to;
		[Serialize("node"               )] public Generic<BlendTreeNodeTemplate<T>> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blend));
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(flags));
			} else if (Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(flagsEnum));
			}
			SerializeField(s, nameof(blendFromTransition));
			SerializeField(s, nameof(from));
			SerializeField(s, nameof(to));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(node));
			}
		}
		[Flags]
		public enum TransitionFlag {
			None = 0,
			[Serialize("TranstionFlag_Progressive")] Progressive = 1,
		}
		public override uint? ClassCRC => 0x5F47DD70;
	}
}

