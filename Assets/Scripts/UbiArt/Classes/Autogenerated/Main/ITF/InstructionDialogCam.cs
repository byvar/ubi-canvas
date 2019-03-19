using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class InstructionDialogCam : InstructionDialog {
		[Serialize("typeCamera")] public Enum_typeCamera typeCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(typeCamera));
		}
		public enum Enum_typeCamera {
			[Serialize("engine")] engine = 0,
			[Serialize("actor" )] actor = 1,
			[Serialize("dialog")] dialog = 2,
		}
		public override uint? ClassCRC => 0x6355CB11;
	}
}

