using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogActorComponent_Template : ActorComponent_Template {
		[Serialize("balloonPath"  )] public Path balloonPath;
		[Serialize("balloon3DPath")] public Path balloon3DPath;
		[Serialize("actorSnapBone")] public StringID actorSnapBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(balloonPath));
			SerializeField(s, nameof(balloon3DPath));
			SerializeField(s, nameof(actorSnapBone));
		}
		public override uint? ClassCRC => 0xFC758052;
	}
}

