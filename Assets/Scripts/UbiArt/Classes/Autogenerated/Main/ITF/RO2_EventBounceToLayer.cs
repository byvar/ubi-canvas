using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventBounceToLayer : Event {
		[Serialize("bounceHeight"           )] public float bounceHeight;
		[Serialize("bounceHeight2"          )] public float bounceHeight2;
		[Serialize("bounceSpeed"            )] public float bounceSpeed;
		[Serialize("targetActor"            )] public ObjectRef targetActor;
		[Serialize("targetPos"              )] public Vector3 targetPos;
		[Serialize("targetOffset"           )] public Vector2 targetOffset;
		[Serialize("hurt"                   )] public bool hurt;
		[Serialize("skipped"                )] public bool skipped;
		[Serialize("useTargetActorScenePosZ")] public bool useTargetActorScenePosZ;
		[Serialize("useBounceHeight"        )] public bool useBounceHeight;
		[Serialize("targetActor"            )] public uint targetActor;
		[Serialize("hurt"                   )] public uint hurt;
		[Serialize("float__0"               )] public float float__0;
		[Serialize("float__1"               )] public float float__1;
		[Serialize("float__2"               )] public float float__2;
		[Serialize("Vector3__3"             )] public Vector3 Vector3__3;
		[Serialize("Vector2__4"             )] public Vector2 Vector2__4;
		[Serialize("bool__5"                )] public bool bool__5;
		[Serialize("bool__6"                )] public bool bool__6;
		[Serialize("bool__7"                )] public bool bool__7;
		[Serialize("bool__8"                )] public bool bool__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bounceHeight));
				SerializeField(s, nameof(bounceHeight2));
				SerializeField(s, nameof(bounceSpeed));
				SerializeField(s, nameof(targetActor));
				SerializeField(s, nameof(targetPos));
				SerializeField(s, nameof(targetOffset));
				SerializeField(s, nameof(hurt));
				SerializeField(s, nameof(skipped));
				SerializeField(s, nameof(useTargetActorScenePosZ));
				SerializeField(s, nameof(useBounceHeight));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(Vector3__3));
				SerializeField(s, nameof(Vector2__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
			} else {
				SerializeField(s, nameof(bounceHeight));
				SerializeField(s, nameof(bounceHeight2));
				SerializeField(s, nameof(bounceSpeed));
				SerializeField(s, nameof(targetActor));
				SerializeField(s, nameof(targetPos));
				SerializeField(s, nameof(targetOffset));
				SerializeField(s, nameof(hurt));
				SerializeField(s, nameof(skipped));
				SerializeField(s, nameof(useTargetActorScenePosZ));
				SerializeField(s, nameof(useBounceHeight));
			}
		}
		public override uint? ClassCRC => 0xE0E48A5E;
	}
}

