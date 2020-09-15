using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class InstructionDialogCam : InstructionDialog {
		public Enum_typeCamera typeCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			typeCamera = s.Serialize<Enum_typeCamera>(typeCamera, name: "typeCamera");
		}
		public enum Enum_typeCamera {
			[Serialize("engine")] engine = 0,
			[Serialize("actor" )] actor = 1,
			[Serialize("dialog")] dialog = 2,
		}
		public override uint? ClassCRC => 0x6355CB11;
	}
}

