using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class FluidBankComponent_Template : GraphicComponent_Template {
		public CList<GFX_GridFluidModifierList> ModifierTemplates;
		public uint MaxActiveInstance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ModifierTemplates = s.SerializeObject<CList<GFX_GridFluidModifierList>>(ModifierTemplates, name: "ModifierTemplates");
			MaxActiveInstance = s.Serialize<uint>(MaxActiveInstance, name: "MaxActiveInstance");
		}
		public override uint? ClassCRC => 0x6F81A08D;
	}
}

