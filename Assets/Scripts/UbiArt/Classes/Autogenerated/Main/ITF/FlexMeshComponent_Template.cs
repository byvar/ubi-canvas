using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FlexMeshComponent_Template : GraphicComponent_Template {
		public CList<FlexMeshData> flexList;
		public bool useActorFlip;
		public bool useComponentAlpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				useActorFlip = s.Serialize<bool>(useActorFlip, name: "useActorFlip", options: CSerializerObject.Options.BoolAsByte);
				useComponentAlpha = s.Serialize<bool>(useComponentAlpha, name: "useComponentAlpha", options: CSerializerObject.Options.BoolAsByte);
			} else {
				flexList = s.SerializeObject<CList<FlexMeshData>>(flexList, name: "flexList");
				useActorFlip = s.Serialize<bool>(useActorFlip, name: "useActorFlip");
				useComponentAlpha = s.Serialize<bool>(useComponentAlpha, name: "useComponentAlpha");
			}
		}
		public override uint? ClassCRC => 0x7B3F8DEE;
	}
}

