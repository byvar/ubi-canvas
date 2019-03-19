using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DialogActorComponent_Template : ActorComponent_Template {
		[Serialize("balloonPath"     )] public Path balloonPath;
		[Serialize("balloon3DPath"   )] public Path balloon3DPath;
		[Serialize("actorSnapBone"   )] public StringID actorSnapBone;
		[Serialize("widthTextAreaMax")] public float widthTextAreaMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(balloonPath));
				SerializeField(s, nameof(balloon3DPath));
				SerializeField(s, nameof(actorSnapBone));
				SerializeField(s, nameof(widthTextAreaMax));
			} else {
				SerializeField(s, nameof(balloonPath));
				SerializeField(s, nameof(balloon3DPath));
				SerializeField(s, nameof(actorSnapBone));
			}
		}
		public override uint? ClassCRC => 0xFC758052;
	}
}

