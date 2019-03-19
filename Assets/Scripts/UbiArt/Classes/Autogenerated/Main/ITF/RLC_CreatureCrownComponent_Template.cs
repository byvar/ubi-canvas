using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureCrownComponent_Template : ActorComponent_Template {
		[Serialize("crownTextureBank"    )] public TextureBankPath crownTextureBank;
		[Serialize("patchChanges"        )] public CMap<StringID, StringID> patchChanges;
		[Serialize("seasonalPatchChanges")] public CMap<StringID, StringID> seasonalPatchChanges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(crownTextureBank));
			SerializeField(s, nameof(patchChanges));
			SerializeField(s, nameof(seasonalPatchChanges));
		}
		public override uint? ClassCRC => 0x6880219D;
	}
}

