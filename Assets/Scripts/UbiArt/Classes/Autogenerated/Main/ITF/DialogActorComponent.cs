using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DialogActorComponent : ActorComponent {
		[Serialize("enableDialog"      )] public bool enableDialog;
		[Serialize("offset"            )] public Vec2d offset;
		[Serialize("is3D"              )] public bool is3D;
		[Serialize("widthTextAreaMax"  )] public float widthTextAreaMax;
		[Serialize("offSetCorrectionPx")] public Vec2d offSetCorrectionPx;
		[Serialize("managerOffsetDelta")] public Vec2d managerOffsetDelta;
		[Serialize("textOffset"        )] public Vec2d textOffset;
		[Serialize("snapToScreen"      )] public int snapToScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(enableDialog));
				SerializeField(s, nameof(textOffset));
				SerializeField(s, nameof(snapToScreen));
				SerializeField(s, nameof(is3D));
				SerializeField(s, nameof(offSetCorrectionPx));
			} else {
				SerializeField(s, nameof(enableDialog));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(is3D));
				SerializeField(s, nameof(widthTextAreaMax));
				SerializeField(s, nameof(offSetCorrectionPx));
				SerializeField(s, nameof(managerOffsetDelta));
			}
		}
		public override uint? ClassCRC => 0x19FA44DD;
	}
}

