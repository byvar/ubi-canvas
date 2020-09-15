using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_439_sub_B6D4B0 : ActorComponent_Template {
		[Serialize("animOpening"          )] public StringID animOpening;
		[Serialize("animOpen"             )] public StringID animOpen;
		[Serialize("animClosing"          )] public StringID animClosing;
		[Serialize("animClosed"           )] public StringID animClosed;
		[Serialize("animLocked"           )] public StringID animLocked;
		[Serialize("actorCounterPath"     )] public Path actorCounterPath;
		[Serialize("counterOffset"        )] public Vec2d counterOffset;
		[Serialize("actorNewIconPath"     )] public Path actorNewIconPath;
		[Serialize("newIconOffset"        )] public Vec2d newIconOffset;
		[Serialize("walkThroughDoorTarget")] public Vec3d walkThroughDoorTarget;
		[Serialize("enterColor"           )] public Color enterColor;
		[Serialize("walkOutDistance"      )] public float walkOutDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animOpening));
			SerializeField(s, nameof(animOpen));
			SerializeField(s, nameof(animClosing));
			SerializeField(s, nameof(animClosed));
			SerializeField(s, nameof(animLocked));
			SerializeField(s, nameof(actorCounterPath));
			SerializeField(s, nameof(counterOffset));
			SerializeField(s, nameof(actorNewIconPath));
			SerializeField(s, nameof(newIconOffset));
			SerializeField(s, nameof(walkThroughDoorTarget));
			SerializeField(s, nameof(enterColor));
			SerializeField(s, nameof(walkOutDistance));
		}
		public override uint? ClassCRC => 0x4E818C41;
	}
}

