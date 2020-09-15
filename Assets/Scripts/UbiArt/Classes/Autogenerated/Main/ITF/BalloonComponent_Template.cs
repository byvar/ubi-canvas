using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BalloonComponent_Template : ActorComponent_Template {
		[Serialize("aabbMin"        )] public Vec2d aabbMin;
		[Serialize("is3D"           )] public bool is3D;
		[Serialize("appearSoundGuid")] public SoundGUID appearSoundGuid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(aabbMin));
				SerializeField(s, nameof(is3D));
				SerializeField(s, nameof(appearSoundGuid));
			} else {
				SerializeField(s, nameof(aabbMin));
				SerializeField(s, nameof(is3D));
			}
		}
		public override uint? ClassCRC => 0xC29A3B3F;
	}
}

