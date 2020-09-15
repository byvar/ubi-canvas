using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTransition_Template<T> : CSerializable {
		public uint blend;
		public TransitionFlag flagsEnum;
		public uint flags;
		public uint blendFromTransition;
		public CArray<StringID> from;
		public CArray<StringID> to;
		public Generic<BlendTreeNodeTemplate<T>> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blend = s.Serialize<uint>(blend, name: "blend");
			if (Settings.s.game == Settings.Game.VH) {
				flags = s.Serialize<uint>(flags, name: "flags");
			} else if (Settings.s.game == Settings.Game.RA) {
				flagsEnum = s.Serialize<TransitionFlag>(flagsEnum, name: "flagsEnum");
			}
			blendFromTransition = s.Serialize<uint>(blendFromTransition, name: "blendFromTransition");
			from = s.SerializeObject<CArray<StringID>>(from, name: "from");
			to = s.SerializeObject<CArray<StringID>>(to, name: "to");
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				node = s.SerializeObject<Generic<BlendTreeNodeTemplate<T>>>(node, name: "node");
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

