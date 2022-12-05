using System;
namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTransition_Template<T> : CSerializable {
		public uint blend;
		public TransitionFlag flagsEnum;
		public uint flags;
		public uint blendFromTransition = 4;
		public CArrayO<StringID> from;
		public CArrayO<StringID> to;
		public Generic<BlendTreeNodeTemplate<T>> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blend = s.Serialize<uint>(blend, name: "blend");
			if (s.Settings.game == Settings.Game.VH) {
				flags = s.Serialize<uint>(flags, name: "flags");
			} else if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				flagsEnum = s.Serialize<TransitionFlag>(flagsEnum, name: "flags");
			}
			blendFromTransition = s.Serialize<uint>(blendFromTransition, name: "blendFromTransition");
			from = s.SerializeObject<CArrayO<StringID>>(from, name: "from");
			to = s.SerializeObject<CArrayO<StringID>>(to, name: "to");
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

