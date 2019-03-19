using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class MaskResolverComponent_Template : ActorComponent_Template {
		[Serialize("resolveFrontLightBuffer"        )] public bool resolveFrontLightBuffer;
		[Serialize("resolveFrontLightBufferInverted")] public bool resolveFrontLightBufferInverted;
		[Serialize("resolveBackLightBuffer"         )] public bool resolveBackLightBuffer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(resolveFrontLightBuffer));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(resolveFrontLightBufferInverted));
				}
				SerializeField(s, nameof(resolveBackLightBuffer));
			} else {
				SerializeField(s, nameof(resolveFrontLightBuffer));
				SerializeField(s, nameof(resolveFrontLightBufferInverted));
				SerializeField(s, nameof(resolveBackLightBuffer));
			}
		}
		public override uint? ClassCRC => 0x8B4B2DF2;
	}
}

